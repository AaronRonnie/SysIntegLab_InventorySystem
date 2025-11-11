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

        // Search functionality
        private List<Item> allItems = new List<Item>();
        private List<Order> allOrders = new List<Order>();
        private List<Shipping> allShippings = new List<Shipping>();

        // Color Scheme
        private Color PRIMARY_COLOR = Color.FromArgb(41, 128, 185); // Blue
        private Color SECONDARY_COLOR = Color.FromArgb(52, 152, 219); // Light Blue
        private Color ACCENT_COLOR = Color.FromArgb(46, 204, 113); // Green
        private Color DANGER_COLOR = Color.FromArgb(231, 76, 60); // Red
        private Color DARK_BG = Color.FromArgb(44, 62, 80); // Dark Grey
        private Color LIGHT_BG = Color.FromArgb(236, 240, 241); // Light Grey
        private Color TEXT_COLOR = Color.FromArgb(52, 73, 94); // Dark Text

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
                AddSearchTextBoxes();
                await InitializeSampleDataAsync();
                await RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during initialization: {ex.Message}\n\nMake sure the backend is running on https://localhost:7211/", "Initialization Error");
            }
        }

        // ==================== THEME & STYLING ====================
        private void ApplyTheme()
        {
            try
            {
                // Form styling
                this.BackColor = LIGHT_BG;
                this.ForeColor = TEXT_COLOR;

                // Apply to all controls
                StyleAllControls(this);
            }
            catch (Exception ex)
            {
                // Silently fail - theme is nice to have but not required
            }
        }

        private void StyleAllControls(Control parent)
        {
            try
            {
                foreach (Control control in parent.Controls)
                {
                    if (control is Button btn)
                    {
                        btn.BackColor = PRIMARY_COLOR;
                        btn.ForeColor = Color.White;
                        btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Cursor = Cursors.Hand;
                    }
                    else if (control is TextBox txt)
                    {
                        txt.BackColor = Color.White;
                        txt.ForeColor = TEXT_COLOR;
                        txt.BorderStyle = BorderStyle.FixedSingle;
                        txt.Font = new Font("Segoe UI", 10);
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

                    // Recursively style child controls
                    if (control.HasChildren)
                    {
                        StyleAllControls(control);
                    }
                }
            }
            catch
            {
                // Continue even if styling fails
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            try
            {
                if (dgv == null) return;

                dgv.BackgroundColor = Color.White;
                dgv.ForeColor = TEXT_COLOR;
                dgv.RowHeadersVisible = false;
                dgv.AllowUserToResizeRows = false;
                dgv.RowTemplate.Height = 30;
                dgv.AutoResizeRows();

                // Header styling
                dgv.ColumnHeadersDefaultCellStyle.BackColor = PRIMARY_COLOR;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // Row styling
                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.DefaultCellStyle.ForeColor = TEXT_COLOR;
                dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv.DefaultCellStyle.Padding = new Padding(5);

                // Alternating row colors
                dgv.AlternatingRowsDefaultCellStyle.BackColor = LIGHT_BG;

                // Grid lines
                dgv.GridColor = Color.FromArgb(189, 195, 199);
                dgv.BorderStyle = BorderStyle.FixedSingle;

                // Selection styling
                dgv.DefaultCellStyle.SelectionBackColor = SECONDARY_COLOR;
                dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            catch
            {
                // Continue even if styling fails
            }
        }

        // ==================== SEARCH FUNCTIONALITY ====================
        private void AddSearchTextBoxes()
        {
            try
            {
                // Find tab pages - more flexible approach
                TabPage inventoryTab = this.Controls.OfType<TabControl>().FirstOrDefault()?.TabPages["tabPageInventory"] 
                    ?? this.Controls.OfType<TabControl>().FirstOrDefault()?.TabPages[0];
                
                TabPage ordersTab = this.Controls.OfType<TabControl>().FirstOrDefault()?.TabPages["tabPageOrdering"] 
                    ?? this.Controls.OfType<TabControl>().FirstOrDefault()?.TabPages[1];
                
                TabPage shippingTab = this.Controls.OfType<TabControl>().FirstOrDefault()?.TabPages["tabPageShipping"] 
                    ?? this.Controls.OfType<TabControl>().FirstOrDefault()?.TabPages[2];

                if (inventoryTab != null)
                {
                    var searchLabelInv = new Label
                    {
                        Text = "🔍 Search:",
                        Location = new System.Drawing.Point(10, 10),
                        AutoSize = true,
                        Font = new System.Drawing.Font("Segoe UI", 11, FontStyle.Bold),
                        ForeColor = PRIMARY_COLOR
                    };

                    var searchBoxInv = new TextBox
                    {
                        Name = "txtSearchInventory",
                        Location = new System.Drawing.Point(95, 8),
                        Width = 200,
                        Height = 28,
                        Font = new System.Drawing.Font("Segoe UI", 10),
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    searchBoxInv.TextChanged += TxtSearchInventory_TextChanged;

                    inventoryTab.Controls.Add(searchBoxInv);
                    inventoryTab.Controls.Add(searchLabelInv);
                }

                if (ordersTab != null)
                {
                    var searchLabelOrder = new Label
                    {
                        Text = "🔍 Search:",
                        Location = new System.Drawing.Point(10, 10),
                        AutoSize = true,
                        Font = new System.Drawing.Font("Segoe UI", 11, FontStyle.Bold),
                        ForeColor = PRIMARY_COLOR
                    };

                    var searchBoxOrder = new TextBox
                    {
                        Name = "txtSearchOrders",
                        Location = new System.Drawing.Point(95, 8),
                        Width = 200,
                        Height = 28,
                        Font = new System.Drawing.Font("Segoe UI", 10),
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    searchBoxOrder.TextChanged += TxtSearchOrders_TextChanged;

                    ordersTab.Controls.Add(searchBoxOrder);
                    ordersTab.Controls.Add(searchLabelOrder);
                }

                if (shippingTab != null)
                {
                    var searchLabelShip = new Label
                    {
                        Text = "🔍 Search:",
                        Location = new System.Drawing.Point(10, 10),
                        AutoSize = true,
                        Font = new System.Drawing.Font("Segoe UI", 11, FontStyle.Bold),
                        ForeColor = PRIMARY_COLOR
                    };

                    var searchBoxShip = new TextBox
                    {
                        Name = "txtSearchShipping",
                        Location = new System.Drawing.Point(95, 8),
                        Width = 200,
                        Height = 28,
                        Font = new System.Drawing.Font("Segoe UI", 10),
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    searchBoxShip.TextChanged += TxtSearchShipping_TextChanged;

                    shippingTab.Controls.Add(searchBoxShip);
                    shippingTab.Controls.Add(searchLabelShip);
                }
            }
            catch (Exception ex)
            {
                // Silently fail - search is nice to have but not required
            }
        }

        // Search handlers
        private void TxtSearchInventory_TextChanged(object sender, EventArgs e)
        {
            var searchBox = sender as TextBox;
            if (searchBox == null) return;

            string searchTerm = searchBox.Text.ToLower();
            var filteredItems = allItems.Where(x =>
                (x.Name?.ToLower() ?? "").Contains(searchTerm) ||
                (x.Code?.ToLower() ?? "").Contains(searchTerm) ||
                (x.Brand?.ToLower() ?? "").Contains(searchTerm)
            ).ToList();

            items = filteredItems;
            if (dgvItems != null)
                dgvItems.DataSource = new BindingSource { DataSource = items };
        }

        private void TxtSearchOrders_TextChanged(object sender, EventArgs e)
        {
            var searchBox = sender as TextBox;
            if (searchBox == null) return;

            string searchTerm = searchBox.Text.ToLower();
            var filteredOrders = allOrders.Where(x =>
                (x.ItemName?.ToLower() ?? "").Contains(searchTerm) ||
                (x.ItemCode?.ToLower() ?? "").Contains(searchTerm) ||
                (x.OrderedBy?.ToLower() ?? "").Contains(searchTerm)
            ).ToList();

            orders = filteredOrders;
            if (dgvOrders != null)
                dgvOrders.DataSource = new BindingSource { DataSource = orders };
        }

        private void TxtSearchShipping_TextChanged(object sender, EventArgs e)
        {
            var searchBox = sender as TextBox;
            if (searchBox == null) return;

            string searchTerm = searchBox.Text.ToLower();
            var filteredShippings = allShippings.Where(x =>
                (x.ItemName?.ToLower() ?? "").Contains(searchTerm) ||
                (x.ItemCode?.ToLower() ?? "").Contains(searchTerm) ||
                (x.ShippedTo?.ToLower() ?? "").Contains(searchTerm) ||
                (x.Status?.ToLower() ?? "").Contains(searchTerm)
            ).ToList();

            shippings = filteredShippings;
            if (dgvShippings != null)
                dgvShippings.DataSource = new BindingSource { DataSource = shippings };
        }

        // ==================== INITIALIZATION ====================
        private void SetupAllDataGridViews()
        {
            SetupInventoryDataGridView();
            SetupOrderDataGridView();
            SetupShippingDataGridView();
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
                        {
                            await _httpClient.PostAsJsonAsync("api/shippings", ship);
                        }
                    }
                }
            }
            catch
            {
                // Continue even if sample data fails
            }
        }

        private async Task RefreshAllData()
        {
            await LoadItemsAsync();
            await LoadOrdersAsync();
            await LoadShippingsAsync();
        }

        // ==================== SETUP DATAGRIDS ====================
        private void SetupInventoryDataGridView()
        {
            try
            {
                if (dgvItems == null) return;
                dgvItems.AutoGenerateColumns = false;
                dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvItems.MultiSelect = false;
                dgvItems.Columns.Clear();

                // Column widths - FIXED
                dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id", Width = 50, ReadOnly = true });
                dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name", Width = 120 });
                dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Code", DataPropertyName = "Code", Width = 100 });
                dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Brand", DataPropertyName = "Brand", Width = 100 });
                dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Unit Price", DataPropertyName = "UnitPrice", Width = 110 });
                dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantity", DataPropertyName = "Quantity", Width = 100 });

                StyleDataGridView(dgvItems);
                dgvItems.CellClick += DgvItems_CellClick;
            }
            catch
            {
                // Continue even if setup fails
            }
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

                // Column widths - FIXED
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id", Width = 50, ReadOnly = true });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Item Code", DataPropertyName = "ItemCode", Width = 100 });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Item Name", DataPropertyName = "ItemName", Width = 110 });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ordered By", DataPropertyName = "OrderedBy", Width = 110 });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantity", DataPropertyName = "OrderedQuantity", Width = 85 });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Unit Price", DataPropertyName = "UnitPrice", Width = 100 });
                dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total", DataPropertyName = "TotalPrice", Width = 100 });

                StyleDataGridView(dgvOrders);
                dgvOrders.CellClick += DgvOrders_CellClick;
            }
            catch
            {
                // Continue even if setup fails
            }
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

                // Column widths - FIXED
                dgvShippings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id", Width = 50, ReadOnly = true });
                dgvShippings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Item Code", DataPropertyName = "ItemCode", Width = 100 });
                dgvShippings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Item Name", DataPropertyName = "ItemName", Width = 110 });
                dgvShippings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ordered By", DataPropertyName = "OrderedBy", Width = 110 });
                dgvShippings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ship To", DataPropertyName = "ShippedTo", Width = 120 });
                dgvShippings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status", Width = 100 });

                StyleDataGridView(dgvShippings);
                dgvShippings.CellClick += DgvShippings_CellClick;
            }
            catch
            {
                // Continue even if setup fails
            }
        }

        // ==================== LOAD DATA ====================
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
            catch
            {
                // Continue even if loading fails
            }
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
            catch
            {
                // Continue even if loading fails
            }
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
            catch
            {
                // Continue even if loading fails
            }
        }

        // ==================== INVENTORY TAB ====================
        private void DgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvItems.Rows[e.RowIndex].DataBoundItem is Item item)
                {
                    selectedItem = item;
                    txtName.Text = item.Name ?? "";
                    txtCode.Text = item.Code ?? "";
                    txtBrand.Text = item.Brand ?? "";
                    txtUnitPrice.Text = item.UnitPrice.ToString("F2");
                    txtQuantity.Text = item.Quantity.ToString();
                }
            }
            catch { }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Please enter Name and Code.");
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter valid Unit Price.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter valid Quantity.");
                return;
            }

            var newItem = new Item
            {
                Name = txtName.Text.Trim(),
                Code = txtCode.Text.Trim(),
                Brand = txtBrand.Text.Trim(),
                UnitPrice = price,
                Quantity = qty
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/items", newItem);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Item added successfully!");
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
                MessageBox.Show("Please select an item to update.");
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter valid Unit Price.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter valid Quantity.");
                return;
            }

            selectedItem.Name = txtName.Text.Trim();
            selectedItem.Code = txtCode.Text.Trim();
            selectedItem.Brand = txtBrand.Text.Trim();
            selectedItem.UnitPrice = price;
            selectedItem.Quantity = qty;

            try
            {
                var response = await _httpClient.PutAsJsonAsync($"api/items/{selectedItem.Id}", selectedItem);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Item updated!");
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
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            if (MessageBox.Show("Delete this item?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                var response = await _httpClient.DeleteAsync($"api/items/{selectedItem.Id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Item deleted!");
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
            MessageBox.Show("Items refreshed!");
        }

        private void BtnCancelItem_Click(object sender, EventArgs e)
        {
            ClearItemFields();
        }

        private void ClearItemFields()
        {
            txtName.Clear();
            txtCode.Clear();
            txtBrand.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            selectedItem = null;
        }

        // ==================== ORDERS TAB ====================
        private void DgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvOrders.Rows[e.RowIndex].DataBoundItem is Order order)
                {
                    selectedOrder = order;
                    PopulateOrderFields(selectedOrder);
                }
            }
            catch { }
        }

        private void PopulateOrderFields(Order order)
        {
            txtOrderItemCode.Text = order.ItemCode ?? "";
            txtOrderItemName.Text = order.ItemName ?? "";
            txtOrderedBy.Text = order.OrderedBy ?? "";
            txtOrderQuantity.Text = order.OrderedQuantity.ToString();
            txtOrderUnitPrice.Text = order.UnitPrice.ToString("F2");
        }

        private async void BtnAddOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderItemCode.Text) || string.IsNullOrWhiteSpace(txtOrderedBy.Text))
            {
                MessageBox.Show("Please enter Item Code and Ordered By.");
                return;
            }

            if (!int.TryParse(txtOrderQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter valid Quantity.");
                return;
            }

            var item = allItems.FirstOrDefault(x => x.Code == txtOrderItemCode.Text.Trim());
            if (item == null)
            {
                MessageBox.Show("Item not found in inventory.");
                return;
            }

            if (item.Quantity < quantity)
            {
                MessageBox.Show($"Insufficient stock! Only {item.Quantity} available.");
                return;
            }

            decimal unitPrice = item.UnitPrice;
            decimal totalPrice = unitPrice * quantity;

            var newOrder = new Order
            {
                ItemCode = txtOrderItemCode.Text.Trim(),
                ItemName = item.Name,
                OrderedBy = txtOrderedBy.Text.Trim(),
                OrderedQuantity = quantity,
                UnitPrice = unitPrice,
                TotalPrice = totalPrice,
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
                    
                    MessageBox.Show("Order created! Inventory reduced. Shipping auto-generated.\n\nClick 'Load Items' to see updated inventory.");
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
                MessageBox.Show("Please select an order to update.");
                return;
            }

            if (!int.TryParse(txtOrderQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter valid Quantity.");
                return;
            }

            selectedOrder.OrderedBy = txtOrderedBy.Text.Trim();
            selectedOrder.OrderedQuantity = quantity;
            selectedOrder.TotalPrice = selectedOrder.UnitPrice * quantity;

            try
            {
                var response = await _httpClient.PutAsJsonAsync($"api/orders/{selectedOrder.Id}", selectedOrder);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Order updated!");
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
                MessageBox.Show("Please select an order to delete/cancel.");
                return;
            }

            var result = MessageBox.Show(
                "Cancel this order?\n\nThis will:\n- Delete the order\n- Restore inventory quantity\n\nClick 'Load Items' after to see changes.",
                "Cancel Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                var adjustment = new { ItemCode = selectedOrder.ItemCode, Quantity = selectedOrder.OrderedQuantity };
                var restoreResponse = await _httpClient.PostAsJsonAsync("api/items/restore-quantity", adjustment);
                
                if (!restoreResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Failed to restore inventory. Order not cancelled.");
                    return;
                }

                var deleteResponse = await _httpClient.DeleteAsync($"api/orders/{selectedOrder.Id}");
                if (deleteResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Order cancelled! Inventory restored.\n\nClick 'Load Items' to see updated inventory.");
                    await LoadOrdersAsync();
                    ClearOrderFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void BtnLoadOrders_Click(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
            MessageBox.Show("Orders refreshed!");
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            ClearOrderFields();
        }

        private void ClearOrderFields()
        {
            txtOrderItemCode.Clear();
            txtOrderItemName.Clear();
            txtOrderedBy.Clear();
            txtOrderQuantity.Clear();
            txtOrderUnitPrice.Clear();
            selectedOrder = null;
        }

        // ==================== SHIPPING TAB ====================
        private void DgvShippings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvShippings.Rows[e.RowIndex].DataBoundItem is Shipping shipping)
                {
                    selectedShipping = shipping;
                    PopulateShippingFields(selectedShipping);
                }
            }
            catch { }
        }

        private void PopulateShippingFields(Shipping shipping)
        {
            txtShipItemCode.Text = shipping.ItemCode ?? "";
            txtShipItemName.Text = shipping.ItemName ?? "";
            txtShipOrderedBy.Text = shipping.OrderedBy ?? "";
            txtShipTo.Text = shipping.ShippedTo ?? "";
            if (cmbShippingStatus != null)
                cmbShippingStatus.SelectedItem = shipping.Status ?? "Pending";
        }

        private void ClearShippingFields()
        {
            txtShipItemCode.Clear();
            txtShipItemName.Clear();
            txtShipOrderedBy.Clear();
            txtShipTo.Clear();
            if (cmbShippingStatus != null)
                cmbShippingStatus.SelectedIndex = -1;
            selectedShipping = null;
        }

        private async void BtnAddShipping_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Shipping records are auto-generated when orders are created.\n\n" +
                "Suggested workflow:\n" +
                "1. Create an order in the Orders tab\n" +
                "2. A shipping record is auto-created here\n" +
                "3. Use UPDATE to fill in destination and status\n" +
                "4. Use DELETE only if shipping is cancelled",
                "How to Use Shipping Tab",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private async void BtnUpdateShipping_Click(object sender, EventArgs e)
        {
            if (selectedShipping == null)
            {
                MessageBox.Show("Please select a shipping record to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtShipTo.Text) && cmbShippingStatus.SelectedItem?.ToString() != "Cancelled")
            {
                MessageBox.Show("Please enter destination (Ship To) or set status to Cancelled.");
                return;
            }

            string newStatus = cmbShippingStatus?.SelectedItem?.ToString() ?? "Pending";
            string oldStatus = selectedShipping.Status;

            if (newStatus == "Cancelled" && oldStatus != "Cancelled")
            {
                var result = MessageBox.Show(
                    "You are cancelling this shipment.\n\n" +
                    "This will:\n" +
                    "- Delete the associated order\n" +
                    "- Restore inventory quantity\n\n" +
                    "Click 'Load Orders' and 'Load Items' after to see changes.",
                    "Cancel Shipment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;

                try
                {
                    var associatedOrder = allOrders.FirstOrDefault(o => 
                        o.ItemCode == selectedShipping.ItemCode && 
                        o.OrderedBy == selectedShipping.OrderedBy);

                    if (associatedOrder != null)
                    {
                        var adjustment = new { ItemCode = selectedShipping.ItemCode, Quantity = selectedShipping.Quantity };
                        var restoreResponse = await _httpClient.PostAsJsonAsync("api/items/restore-quantity", adjustment);
                        
                        if (!restoreResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Failed to restore inventory.");
                            return;
                        }

                        var deleteOrderResponse = await _httpClient.DeleteAsync($"api/orders/{associatedOrder.Id}");
                        
                        if (!deleteOrderResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Failed to delete associated order.");
                            return;
                        }
                    }

                    selectedShipping.ShippedTo = txtShipTo.Text.Trim();
                    selectedShipping.Status = "Cancelled";

                    var updateResponse = await _httpClient.PutAsJsonAsync($"api/shippings/{selectedShipping.Id}", selectedShipping);
                    if (updateResponse.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Shipment cancelled!\n\n" +
                                      "Associated order deleted and inventory restored.\n\n" +
                                      "Click 'Load Orders' in Orders tab and 'Load Items' in Inventory tab to see changes.");
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
                selectedShipping.ShippedTo = txtShipTo.Text.Trim();
                selectedShipping.Status = newStatus;

                try
                {
                    var response = await _httpClient.PutAsJsonAsync($"api/shippings/{selectedShipping.Id}", selectedShipping);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Shipping record updated successfully!");
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
                MessageBox.Show("Please select a shipping record to delete.");
                return;
            }

            var result = MessageBox.Show(
                "Delete this shipping record?\n\n" +
                "Only delete if the shipment is cancelled.\n" +
                "For completed shipments, update the status instead.",
                "Delete Shipping",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                var response = await _httpClient.DeleteAsync($"api/shippings/{selectedShipping.Id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Shipping record deleted!");
                    await LoadShippingsAsync();
                    ClearShippingFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void BtnLoadShippings_Click(object sender, EventArgs e)
        {
            await LoadShippingsAsync();
            MessageBox.Show("Shipping records refreshed!");
        }

        private void BtnCancelShipping_Click(object sender, EventArgs e)
        {
            ClearShippingFields();
        }
    }
}
