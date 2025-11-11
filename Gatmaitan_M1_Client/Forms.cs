using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gatmaitan_M1_Client.Models;

namespace Gatmaitan_M1_Client
{
    public partial class Forms : Form
    {
        private readonly HttpClient _httpClient;
        private List<Item> items = new List<Item>();
        private List<Order> orders = new List<Order>();
        private List<Shipping> shippings = new List<Shipping>();
        private Item selectedItem = null;
        private Order selectedOrder = null;
        private Shipping selectedShipping = null;

        private List<Item> allItems = new List<Item>();
        private List<Order> allOrders = new List<Order>();
        private List<Shipping> allShippings = new List<Shipping>();

        private Color PRIMARY_COLOR = Color.FromArgb(41, 128, 185);
        private Color SECONDARY_COLOR = Color.FromArgb(52, 152, 219);
        private Color LIGHT_BG = Color.FromArgb(236, 240, 241);
        private Color TEXT_COLOR = Color.FromArgb(52, 73, 94);

        public Forms()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7211/");
            _httpClient.Timeout = TimeSpan.FromSeconds(10);
        }

        private async void Forms_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                SetupAllDataGridViews();
                AddSearchBoxes();
                await InitializeSampleDataAsync();
                await RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ApplyTheme()
        {
            try
            {
                this.BackColor = LIGHT_BG;
                this.ForeColor = TEXT_COLOR;
                this.Font = new Font("Segoe UI", 10);
                StyleAllControls(this);
            }
            catch { }
        }

        private void StyleAllControls(Control parent)
        {
            try
            {
                foreach (Control control in parent.Controls)
                {
                    StyleControl(control);
                    if (control.HasChildren)
                        StyleAllControls(control);
                }
            }
            catch { }
        }

        private void StyleControl(Control control)
        {
            try
            {
                if (control is Button btn)
                {
                    btn.BackColor = PRIMARY_COLOR;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                    btn.Height = 38;
                    btn.AutoSize = false;
                }
                else if (control is TextBox txt)
                {
                    txt.BackColor = Color.White;
                    txt.ForeColor = TEXT_COLOR;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.Font = new Font("Segoe UI", 10);
                    txt.Height = 30;
                }
                else if (control is ComboBox cmb)
                {
                    cmb.BackColor = Color.White;
                    cmb.ForeColor = TEXT_COLOR;
                    cmb.Font = new Font("Segoe UI", 10);
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = TEXT_COLOR;
                    lbl.Font = new Font("Segoe UI", 10);
                }
                else if (control is DataGridView dgv)
                {
                    StyleDataGridView(dgv);
                }
            }
            catch { }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            try
            {
                if (dgv == null) return;

                dgv.BackgroundColor = Color.White;
                dgv.ForeColor = TEXT_COLOR;
                dgv.RowHeadersVisible = false;
                dgv.RowTemplate.Height = 32;
                dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                dgv.ColumnHeadersDefaultCellStyle.BackColor = PRIMARY_COLOR;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.DefaultCellStyle.ForeColor = TEXT_COLOR;
                dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv.DefaultCellStyle.Padding = new Padding(5);

                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 250, 255);
                dgv.GridColor = Color.FromArgb(200, 210, 220);
                dgv.BorderStyle = BorderStyle.FixedSingle;

                dgv.DefaultCellStyle.SelectionBackColor = SECONDARY_COLOR;
                dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            catch { }
        }

        private void AddSearchBoxes()
        {
            try
            {
                var tabControl = this.Controls.OfType<TabControl>().FirstOrDefault();
                if (tabControl == null) return;

                for (int tabIndex = 0; tabIndex < tabControl.TabPages.Count && tabIndex < 3; tabIndex++)
                {
                    TabPage tab = tabControl.TabPages[tabIndex];
                    
                    int rightPosition = tab.Width - 260;
                    if (rightPosition < 400) rightPosition = 400;

                    var searchLabel = new Label
                    {
                        Text = "🔍 Search:",
                        Location = new Point(rightPosition - 80, 12),
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        ForeColor = PRIMARY_COLOR
                    };

                    var searchBox = new TextBox
                    {
                        Location = new Point(rightPosition, 10),
                        Width = 250,
                        Height = 28,
                        Font = new Font("Segoe UI", 10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    tab.Controls.Add(searchLabel);
                    tab.Controls.Add(searchBox);

                    if (tabIndex == 0)
                    {
                        searchBox.Name = "txtSearchInventory";
                        searchBox.TextChanged += TxtSearchInventory_TextChanged;
                    }
                    else if (tabIndex == 1)
                    {
                        searchBox.Name = "txtSearchOrders";
                        searchBox.TextChanged += TxtSearchOrders_TextChanged;
                    }
                    else if (tabIndex == 2)
                    {
                        searchBox.Name = "txtSearchShipping";
                        searchBox.TextChanged += TxtSearchShipping_TextChanged;
                    }
                }
            }
            catch { }
        }

        private void TxtSearchInventory_TextChanged(object sender, EventArgs e)
        {
            var searchBox = sender as TextBox;
            if (searchBox == null) return;

            string searchTerm = searchBox.Text.ToLower();
            var filtered = allItems.Where(x =>
                (x.Name?.ToLower() ?? "").Contains(searchTerm) ||
                (x.Code?.ToLower() ?? "").Contains(searchTerm) ||
                (x.Brand?.ToLower() ?? "").Contains(searchTerm)
            ).ToList();

            items = filtered;
            if (dgvItems != null)
                dgvItems.DataSource = new BindingSource { DataSource = items };
        }

        private void TxtSearchOrders_TextChanged(object sender, EventArgs e)
        {
            var searchBox = sender as TextBox;
            if (searchBox == null) return;

            string searchTerm = searchBox.Text.ToLower();
            var filtered = allOrders.Where(x =>
                (x.ItemName?.ToLower() ?? "").Contains(searchTerm) ||
                (x.ItemCode?.ToLower() ?? "").Contains(searchTerm) ||
                (x.OrderedBy?.ToLower() ?? "").Contains(searchTerm)
            ).ToList();

            orders = filtered;
            if (dgvOrders != null)
                dgvOrders.DataSource = new BindingSource { DataSource = orders };
        }

        private void TxtSearchShipping_TextChanged(object sender, EventArgs e)
        {
            var searchBox = sender as TextBox;
            if (searchBox == null) return;

            string searchTerm = searchBox.Text.ToLower();
            var filtered = allShippings.Where(x =>
                (x.ItemName?.ToLower() ?? "").Contains(searchTerm) ||
                (x.ItemCode?.ToLower() ?? "").Contains(searchTerm) ||
                (x.ShippedTo?.ToLower() ?? "").Contains(searchTerm) ||
                (x.Status?.ToLower() ?? "").Contains(searchTerm)
            ).ToList();

            shippings = filtered;
            if (dgvShippings != null)
                dgvShippings.DataSource = new BindingSource { DataSource = shippings };
        }

        private void SetupAllDataGridViews()
        {
            SetupInventoryDataGridView();
            SetupOrderDataGridView();
            SetupShippingDataGridView();
        }

        private void SetupInventoryDataGridView()
        {
            try
            {
                if (dgvItems == null) return;
                dgvItems.AutoGenerateColumns = false;
                dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvItems.MultiSelect = false;
                dgvItems.Columns.Clear();

                dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id", Width = 50, ReadOnly = true });
                dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name", Width = 130 });
                dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Code", DataPropertyName = "Code", Width = 100 });
                dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Brand", DataPropertyName = "Brand", Width = 100 });
                dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Unit Price", DataPropertyName = "UnitPrice", Width = 120 });
                dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantity", DataPropertyName = "Quantity", Width = 100 });

                StyleDataGridView(dgvItems);
                dgvItems.CellClick += DgvItems_CellClick;
            }
            catch { }
        }

        private void SetupOrderDataGridView()
        {
            try
            {
                if (dgvOrders == null) return;
                dgvOrders.AutoGenerateColumns = false;
                dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvOrders.MultiSelect = false;
                dgvOrders.Columns.Clear();

                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id", Width = 50, ReadOnly = true });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Item Code", DataPropertyName = "ItemCode", Width = 100 });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Item Name", DataPropertyName = "ItemName", Width = 110 });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ordered By", DataPropertyName = "OrderedBy", Width = 110 });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Qty", DataPropertyName = "OrderedQuantity", Width = 70 });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Unit Price", DataPropertyName = "UnitPrice", Width = 100 });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total", DataPropertyName = "TotalPrice", Width = 100 });

                StyleDataGridView(dgvOrders);
                dgvOrders.CellClick += DgvOrders_CellClick;
            }
            catch { }
        }

        private void SetupShippingDataGridView()
        {
            try
            {
                if (dgvShippings == null) return;
                dgvShippings.AutoGenerateColumns = false;
                dgvShippings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvShippings.MultiSelect = false;
                dgvShippings.Columns.Clear();

                dgvShippings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id", Width = 50, ReadOnly = true });
                dgvShippings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Item Code", DataPropertyName = "ItemCode", Width = 100 });
                dgvShippings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Item Name", DataPropertyName = "ItemName", Width = 110 });
                dgvShippings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ordered By", DataPropertyName = "OrderedBy", Width = 110 });
                dgvShippings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ship To", DataPropertyName = "ShippedTo", Width = 120 });
                dgvShippings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status", Width = 100 });

                StyleDataGridView(dgvShippings);
                dgvShippings.CellClick += DgvShippings_CellClick;
            }
            catch { }
        }

        private async Task InitializeSampleDataAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/items");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var existingItems = JsonSerializer.Deserialize<List<Item>>(content, options) ?? new List<Item>();
                    if (existingItems.Count == 0)
                    {
                        var sampleShippings = new List<Shipping>
                        {
                            new Shipping { ItemCode = "ITM001", ItemName = "Laptop", OrderedBy = "John Doe", ShippedTo = "Manila", Status = "Pending", Quantity = 2 }
                        };
                        foreach (var ship in sampleShippings)
                            await _httpClient.PostAsJsonAsync("api/shippings", ship);
                    }
                }
            }
            catch { }
        }

        private async Task RefreshAllData()
        {
            await LoadItemsAsync();
            await LoadOrdersAsync();
            await LoadShippingsAsync();
        }

        private async Task LoadItemsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/items");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    allItems = JsonSerializer.Deserialize<List<Item>>(content, options) ?? new List<Item>();
                    items = new List<Item>(allItems);
                    if (dgvItems != null)
                        dgvItems.DataSource = new BindingSource { DataSource = items };
                }
            }
            catch { }
        }

        private async Task LoadOrdersAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/orders");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    allOrders = JsonSerializer.Deserialize<List<Order>>(content, options) ?? new List<Order>();
                    orders = new List<Order>(allOrders);
                    if (dgvOrders != null)
                        dgvOrders.DataSource = new BindingSource { DataSource = orders };
                }
            }
            catch { }
        }

        private async Task LoadShippingsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/shippings");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    allShippings = JsonSerializer.Deserialize<List<Shipping>>(content, options) ?? new List<Shipping>();
                    shippings = new List<Shipping>(allShippings);
                    if (dgvShippings != null)
                        dgvShippings.DataSource = new BindingSource { DataSource = shippings };
                }
            }
            catch { }
        }

        private void DgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvItems.Rows[e.RowIndex].DataBoundItem is Item item)
                {
                    selectedItem = item;
                    if (txtName != null) txtName.Text = item.Name ?? "";
                    if (txtCode != null) txtCode.Text = item.Code ?? "";
                    if (txtBrand != null) txtBrand.Text = item.Brand ?? "";
                    if (txtUnitPrice != null) txtUnitPrice.Text = item.UnitPrice.ToString("F2");
                    if (txtQuantity != null) txtQuantity.Text = item.Quantity.ToString();
                }
            }
            catch { }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName?.Text) || string.IsNullOrWhiteSpace(txtCode?.Text))
            {
                MessageBox.Show("Enter Name and Code.");
                return;
            }

            if (!decimal.TryParse(txtUnitPrice?.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Enter valid Unit Price.");
                return;
            }

            if (!int.TryParse(txtQuantity?.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Enter valid Quantity.");
                return;
            }

            var newItem = new Item
            {
                Name = txtName.Text.Trim(),
                Code = txtCode.Text.Trim(),
                Brand = txtBrand?.Text.Trim() ?? "",
                UnitPrice = price,
                Quantity = qty
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/items", newItem);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Item added!");
                    await LoadItemsAsync();
                    ClearItemFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedItem == null)
            {
                MessageBox.Show("Select an item.");
                return;
            }

            if (!decimal.TryParse(txtUnitPrice?.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Valid Unit Price.");
                return;
            }

            if (!int.TryParse(txtQuantity?.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Valid Quantity.");
                return;
            }

            selectedItem.Name = txtName?.Text.Trim() ?? "";
            selectedItem.Code = txtCode?.Text.Trim() ?? "";
            selectedItem.Brand = txtBrand?.Text.Trim() ?? "";
            selectedItem.UnitPrice = price;
            selectedItem.Quantity = qty;

            try
            {
                var response = await _httpClient.PutAsJsonAsync($"api/items/{selectedItem.Id}", selectedItem);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Updated!");
                    await LoadItemsAsync();
                    ClearItemFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedItem == null)
            {
                MessageBox.Show("Select an item.");
                return;
            }

            if (MessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                var response = await _httpClient.DeleteAsync($"api/items/{selectedItem.Id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Deleted!");
                    await LoadItemsAsync();
                    ClearItemFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void BtnLoad_Click(object sender, EventArgs e)
        {
            await LoadItemsAsync();
            MessageBox.Show("Refreshed!");
        }

        private void BtnCancelItem_Click(object sender, EventArgs e)
        {
            ClearItemFields();
        }

        private void ClearItemFields()
        {
            if (txtName != null) txtName.Clear();
            if (txtCode != null) txtCode.Clear();
            if (txtBrand != null) txtBrand.Clear();
            if (txtUnitPrice != null) txtUnitPrice.Clear();
            if (txtQuantity != null) txtQuantity.Clear();
            selectedItem = null;
        }

        private void DgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvOrders.Rows[e.RowIndex].DataBoundItem is Order order)
                {
                    selectedOrder = order;
                    if (txtOrderItemCode != null) txtOrderItemCode.Text = order.ItemCode ?? "";
                    if (txtOrderItemName != null) txtOrderItemName.Text = order.ItemName ?? "";
                    if (txtOrderedBy != null) txtOrderedBy.Text = order.OrderedBy ?? "";
                    if (txtOrderQuantity != null) txtOrderQuantity.Text = order.OrderedQuantity.ToString();
                    if (txtOrderUnitPrice != null) txtOrderUnitPrice.Text = order.UnitPrice.ToString("F2");
                }
            }
            catch { }
        }

        private async void BtnAddOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderItemCode?.Text) || string.IsNullOrWhiteSpace(txtOrderedBy?.Text))
            {
                MessageBox.Show("Enter Item Code and Ordered By.");
                return;
            }

            if (!int.TryParse(txtOrderQuantity?.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter valid Quantity.");
                return;
            }

            var item = allItems.FirstOrDefault(x => x.Code == txtOrderItemCode.Text.Trim());
            if (item == null)
            {
                MessageBox.Show("Item not found.");
                return;
            }

            if (item.Quantity < quantity)
            {
                MessageBox.Show($"Insufficient stock! Only {item.Quantity} available.");
                return;
            }

            var newOrder = new Order
            {
                ItemCode = txtOrderItemCode.Text.Trim(),
                ItemName = item.Name,
                OrderedBy = txtOrderedBy.Text.Trim(),
                OrderedQuantity = quantity,
                UnitPrice = item.UnitPrice,
                TotalPrice = item.UnitPrice * quantity,
                OrderedDate = DateTime.Now
            };

            try
            {
                var orderResponse = await _httpClient.PostAsJsonAsync("api/orders", newOrder);
                if (orderResponse.IsSuccessStatusCode)
                {
                    var adjustment = new { ItemCode = item.Code, Quantity = quantity };
                    await _httpClient.PostAsJsonAsync("api/items/reduce-quantity", adjustment);

                    var newShipping = new Shipping
                    {
                        ItemCode = newOrder.ItemCode,
                        ItemName = newOrder.ItemName,
                        OrderedBy = newOrder.OrderedBy,
                        ShippedTo = "",
                        Status = "Pending",
                        Quantity = quantity,
                        ShippedDate = DateTime.Now
                    };

                    await _httpClient.PostAsJsonAsync("api/shippings", newShipping);
                    MessageBox.Show("Order created!");
                    await LoadOrdersAsync();
                    await LoadShippingsAsync();
                    ClearOrderFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void BtnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null)
            {
                MessageBox.Show("Select an order.");
                return;
            }

            if (!int.TryParse(txtOrderQuantity?.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Valid Quantity.");
                return;
            }

            selectedOrder.OrderedBy = txtOrderedBy?.Text.Trim() ?? "";
            selectedOrder.OrderedQuantity = quantity;
            selectedOrder.TotalPrice = selectedOrder.UnitPrice * quantity;

            try
            {
                var response = await _httpClient.PutAsJsonAsync($"api/orders/{selectedOrder.Id}", selectedOrder);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Updated!");
                    await LoadOrdersAsync();
                    ClearOrderFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null)
            {
                MessageBox.Show("Select an order.");
                return;
            }

            if (MessageBox.Show("Cancel?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                var adjustment = new { ItemCode = selectedOrder.ItemCode, Quantity = selectedOrder.OrderedQuantity };
                await _httpClient.PostAsJsonAsync("api/items/restore-quantity", adjustment);
                await _httpClient.DeleteAsync($"api/orders/{selectedOrder.Id}");
                MessageBox.Show("Cancelled!");
                await LoadOrdersAsync();
                ClearOrderFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void BtnLoadOrders_Click(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
            MessageBox.Show("Refreshed!");
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            ClearOrderFields();
        }

        private void ClearOrderFields()
        {
            if (txtOrderItemCode != null) txtOrderItemCode.Clear();
            if (txtOrderItemName != null) txtOrderItemName.Clear();
            if (txtOrderedBy != null) txtOrderedBy.Clear();
            if (txtOrderQuantity != null) txtOrderQuantity.Clear();
            if (txtOrderUnitPrice != null) txtOrderUnitPrice.Clear();
            selectedOrder = null;
        }

        private void DgvShippings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvShippings.Rows[e.RowIndex].DataBoundItem is Shipping shipping)
                {
                    selectedShipping = shipping;
                    if (txtShipItemCode != null) txtShipItemCode.Text = shipping.ItemCode ?? "";
                    if (txtShipItemName != null) txtShipItemName.Text = shipping.ItemName ?? "";
                    if (txtShipOrderedBy != null) txtShipOrderedBy.Text = shipping.OrderedBy ?? "";
                    if (txtShipTo != null) txtShipTo.Text = shipping.ShippedTo ?? "";
                    if (cmbShippingStatus != null) cmbShippingStatus.SelectedItem = shipping.Status ?? "Pending";
                }
            }
            catch { }
        }

        private void ClearShippingFields()
        {
            if (txtShipItemCode != null) txtShipItemCode.Clear();
            if (txtShipItemName != null) txtShipItemName.Clear();
            if (txtShipOrderedBy != null) txtShipOrderedBy.Clear();
            if (txtShipTo != null) txtShipTo.Clear();
            if (cmbShippingStatus != null) cmbShippingStatus.SelectedIndex = -1;
            selectedShipping = null;
        }

        private async void BtnUpdateShipping_Click(object sender, EventArgs e)
        {
            if (selectedShipping == null)
            {
                MessageBox.Show("Select a record.");
                return;
            }

            string newStatus = cmbShippingStatus?.SelectedItem?.ToString() ?? "Pending";
            string oldStatus = selectedShipping.Status;

            if (newStatus == "Cancelled" && oldStatus != "Cancelled")
            {
                if (MessageBox.Show("Cancel shipment? Order will be deleted.", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                try
                {
                    var order = allOrders.FirstOrDefault(o => 
                        o.ItemCode == selectedShipping.ItemCode && 
                        o.OrderedBy == selectedShipping.OrderedBy);

                    if (order != null)
                    {
                        var adjustment = new { ItemCode = selectedShipping.ItemCode, Quantity = selectedShipping.Quantity };
                        await _httpClient.PostAsJsonAsync("api/items/restore-quantity", adjustment);
                        await _httpClient.DeleteAsync($"api/orders/{order.Id}");
                    }

                    selectedShipping.ShippedTo = txtShipTo?.Text.Trim() ?? "";
                    selectedShipping.Status = "Cancelled";

                    var response = await _httpClient.PutAsJsonAsync($"api/shippings/{selectedShipping.Id}", selectedShipping);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cancelled!");
                        await LoadShippingsAsync();
                        ClearShippingFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                selectedShipping.ShippedTo = txtShipTo?.Text.Trim() ?? "";
                selectedShipping.Status = newStatus;

                try
                {
                    var response = await _httpClient.PutAsJsonAsync($"api/shippings/{selectedShipping.Id}", selectedShipping);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Updated!");
                        await LoadShippingsAsync();
                        ClearShippingFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private async void BtnDeleteShipping_Click(object sender, EventArgs e)
        {
            if (selectedShipping == null)
            {
                MessageBox.Show("Select a record.");
                return;
            }

            if (MessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                await _httpClient.DeleteAsync($"api/shippings/{selectedShipping.Id}");
                MessageBox.Show("Deleted!");
                await LoadShippingsAsync();
                ClearShippingFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void BtnLoadShippings_Click(object sender, EventArgs e)
        {
            await LoadShippingsAsync();
            MessageBox.Show("Refreshed!");
        }

        private void BtnCancelShipping_Click(object sender, EventArgs e)
        {
            ClearShippingFields();
        }

        private async void BtnAddShipping_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Auto-created with orders.", "Info");
        }
    }
}
