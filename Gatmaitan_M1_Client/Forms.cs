using System;
using System.Collections.Generic;
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

        public Forms()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7211/"); // ✅ updated base address
        }

        private async void Forms_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            await LoadItemsAsync();
        }

        private void SetupDataGridView()
        {
            dgvItems.AutoGenerateColumns = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.MultiSelect = false;

            dgvItems.Columns.Clear();
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name", Width = 150 });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Code", DataPropertyName = "Code", Width = 100 });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Brand", DataPropertyName = "Brand", Width = 120 });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Unit Price", DataPropertyName = "UnitPrice", Width = 100 });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantity", DataPropertyName = "Quantity", Width = 80 });
        }

        private async Task LoadItemsAsync()
        {
            var response = await _httpClient.GetAsync("api/items");
            if (response.IsSuccessStatusCode)
            {
                var items = await response.Content.ReadFromJsonAsync<List<Item>>();
                dgvItems.DataSource = items;
            }
            else
            {
                MessageBox.Show("Failed to load items");
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCode.Text))
                {
                    MessageBox.Show("Name and Code are required!");
                    return;
                }

                decimal.TryParse(txtUnitPrice.Text, out decimal price);

                var newItem = new Item
                {
                    Name = txtName.Text,
                    Code = txtCode.Text,
                    Brand = txtBrand.Text,
                    UnitPrice = price,
                    Quantity = int.TryParse(txtQuantity.Text, out int qty) ? qty : 0
                };

                var json = JsonSerializer.Serialize(newItem);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("api/items", content);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Item added successfully!");
                ClearFields();
                await LoadItemsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtCode.Text = "";
            txtBrand.Text = "";
            txtUnitPrice.Text = "";
            txtQuantity.Text = "";
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to update.");
                return;
            }

            try
            {
                var selectedItem = (Item)dgvItems.SelectedRows[0].DataBoundItem;
                decimal.TryParse(txtUnitPrice.Text, out decimal price);

                selectedItem.Name = txtName.Text;
                selectedItem.Code = txtCode.Text;
                selectedItem.Brand = txtBrand.Text;
                selectedItem.UnitPrice = price;
                selectedItem.Quantity = int.TryParse(txtQuantity.Text, out int qty) ? qty : 0;

                var json = JsonSerializer.Serialize(selectedItem);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"api/items/{selectedItem.Code}", content);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Item updated successfully!");
                ClearFields();
                await LoadItemsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating item: " + ex.Message);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            try
            {
                var selectedItem = (Item)dgvItems.SelectedRows[0].DataBoundItem;

                var response = await _httpClient.DeleteAsync($"api/items/{selectedItem.Code}");
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Item deleted successfully!");
                await LoadItemsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message);
            }
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadItemsAsync();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string code = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(code))
            {
                await LoadItemsAsync();
                return;
            }

            var response = await _httpClient.GetAsync($"api/items/{code}");
            if (response.IsSuccessStatusCode)
            {
                var item = await response.Content.ReadFromJsonAsync<Item>();
                dgvItems.DataSource = new List<Item> { item };
            }
            else
            {
                MessageBox.Show("Item not found.");
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtOrderItemCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
