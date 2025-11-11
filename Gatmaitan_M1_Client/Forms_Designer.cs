namespace Gatmaitan_M1_Client
{
    partial class Forms
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.tabPageOrdering = new System.Windows.Forms.TabPage();
            this.tabPageShipping = new System.Windows.Forms.TabPage();

            // Inventory Tab Controls
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.labelTitleInv = new System.Windows.Forms.Label();
            this.groupBoxInventory = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();

            // Orders Tab Controls
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.labelTitleOrder = new System.Windows.Forms.Label();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.labelOrderItemCode = new System.Windows.Forms.Label();
            this.txtOrderItemCode = new System.Windows.Forms.TextBox();
            this.labelOrderItemName = new System.Windows.Forms.Label();
            this.txtOrderItemName = new System.Windows.Forms.TextBox();
            this.labelOrderedBy = new System.Windows.Forms.Label();
            this.txtOrderedBy = new System.Windows.Forms.TextBox();
            this.labelOrderQuantity = new System.Windows.Forms.Label();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.labelOrderUnitPrice = new System.Windows.Forms.Label();
            this.txtOrderUnitPrice = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnLoadOrders = new System.Windows.Forms.Button();

            // Shipping Tab Controls
            this.dgvShippings = new System.Windows.Forms.DataGridView();
            this.labelTitleShip = new System.Windows.Forms.Label();
            this.groupBoxShipping = new System.Windows.Forms.GroupBox();
            this.labelShipItemCode = new System.Windows.Forms.Label();
            this.txtShipItemCode = new System.Windows.Forms.TextBox();
            this.labelShipItemName = new System.Windows.Forms.Label();
            this.txtShipItemName = new System.Windows.Forms.TextBox();
            this.labelShipOrderedBy = new System.Windows.Forms.Label();
            this.txtShipOrderedBy = new System.Windows.Forms.TextBox();
            this.labelShipTo = new System.Windows.Forms.Label();
            this.txtShipTo = new System.Windows.Forms.TextBox();
            this.labelShippingStatus = new System.Windows.Forms.Label();
            this.cmbShippingStatus = new System.Windows.Forms.ComboBox();
            this.btnAddShipping = new System.Windows.Forms.Button();
            this.btnUpdateShipping = new System.Windows.Forms.Button();
            this.btnDeleteShipping = new System.Windows.Forms.Button();
            this.btnCancelShipping = new System.Windows.Forms.Button();
            this.btnLoadShippings = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippings)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            this.tabPageOrdering.SuspendLayout();
            this.tabPageShipping.SuspendLayout();
            this.groupBoxInventory.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            this.groupBoxShipping.SuspendLayout();
            this.SuspendLayout();

            // Main Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Forms";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Forms_Load);

            // Tab Control
            this.tabControlMain.Controls.Add(this.tabPageInventory);
            this.tabControlMain.Controls.Add(this.tabPageOrdering);
            this.tabControlMain.Controls.Add(this.tabPageShipping);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1200, 700);
            this.tabControlMain.TabIndex = 0;

            // ==================== INVENTORY TAB ====================
            this.tabPageInventory.Controls.Add(this.dgvItems);
            this.tabPageInventory.Controls.Add(this.labelTitleInv);
            this.tabPageInventory.Controls.Add(this.groupBoxInventory);
            this.tabPageInventory.Location = new System.Drawing.Point(4, 25);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventory.Size = new System.Drawing.Size(1192, 671);
            this.tabPageInventory.TabIndex = 0;
            this.tabPageInventory.Text = "Inventory";
            this.tabPageInventory.UseVisualStyleBackColor = true;

            // Inventory Label
            this.labelTitleInv.AutoSize = true;
            this.labelTitleInv.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitleInv.Location = new System.Drawing.Point(10, 10);
            this.labelTitleInv.Name = "labelTitleInv";
            this.labelTitleInv.Size = new System.Drawing.Size(150, 32);
            this.labelTitleInv.TabIndex = 0;
            this.labelTitleInv.Text = "Inventory Items";

            // Inventory DataGridView
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(10, 50);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(600, 300);
            this.dgvItems.TabIndex = 1;

            // Inventory GroupBox
            this.groupBoxInventory.Controls.Add(this.labelName);
            this.groupBoxInventory.Controls.Add(this.txtName);
            this.groupBoxInventory.Controls.Add(this.labelCode);
            this.groupBoxInventory.Controls.Add(this.txtCode);
            this.groupBoxInventory.Controls.Add(this.labelBrand);
            this.groupBoxInventory.Controls.Add(this.txtBrand);
            this.groupBoxInventory.Controls.Add(this.labelUnitPrice);
            this.groupBoxInventory.Controls.Add(this.txtUnitPrice);
            this.groupBoxInventory.Controls.Add(this.labelQuantity);
            this.groupBoxInventory.Controls.Add(this.txtQuantity);
            this.groupBoxInventory.Controls.Add(this.btnAdd);
            this.groupBoxInventory.Controls.Add(this.btnUpdate);
            this.groupBoxInventory.Controls.Add(this.btnDelete);
            this.groupBoxInventory.Controls.Add(this.btnCancelItem);
            this.groupBoxInventory.Controls.Add(this.btnLoad);
            this.groupBoxInventory.Location = new System.Drawing.Point(630, 50);
            this.groupBoxInventory.Name = "groupBoxInventory";
            this.groupBoxInventory.Size = new System.Drawing.Size(550, 300);
            this.groupBoxInventory.TabIndex = 2;
            this.groupBoxInventory.TabStop = false;
            this.groupBoxInventory.Text = "Item Details";

            // Name
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";

            this.txtName.Location = new System.Drawing.Point(120, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;

            // Code
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(10, 55);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(44, 16);
            this.labelCode.TabIndex = 2;
            this.labelCode.Text = "Code:";

            this.txtCode.Location = new System.Drawing.Point(120, 55);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 22);
            this.txtCode.TabIndex = 3;

            // Brand
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(10, 85);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(47, 16);
            this.labelBrand.TabIndex = 4;
            this.labelBrand.Text = "Brand:";

            this.txtBrand.Location = new System.Drawing.Point(120, 85);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(200, 22);
            this.txtBrand.TabIndex = 5;

            // Unit Price
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(10, 115);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(75, 16);
            this.labelUnitPrice.TabIndex = 6;
            this.labelUnitPrice.Text = "Unit Price:";

            this.txtUnitPrice.Location = new System.Drawing.Point(120, 115);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(200, 22);
            this.txtUnitPrice.TabIndex = 7;

            // Quantity
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(10, 145);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(67, 16);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Quantity:";

            this.txtQuantity.Location = new System.Drawing.Point(120, 145);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtQuantity.TabIndex = 9;

            // Buttons
            this.btnAdd.Location = new System.Drawing.Point(10, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(120, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(230, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            this.btnCancelItem.Location = new System.Drawing.Point(340, 180);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(100, 30);
            this.btnCancelItem.TabIndex = 13;
            this.btnCancelItem.Text = "Clear";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.BtnCancelItem_Click);

            this.btnLoad.Location = new System.Drawing.Point(10, 220);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(430, 30);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load Items";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);

            // ==================== ORDERS TAB ====================
            this.tabPageOrdering.Controls.Add(this.dgvOrders);
            this.tabPageOrdering.Controls.Add(this.labelTitleOrder);
            this.tabPageOrdering.Controls.Add(this.groupBoxOrder);
            this.tabPageOrdering.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrdering.Name = "tabPageOrdering";
            this.tabPageOrdering.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrdering.Size = new System.Drawing.Size(1192, 671);
            this.tabPageOrdering.TabIndex = 1;
            this.tabPageOrdering.Text = "Orders";
            this.tabPageOrdering.UseVisualStyleBackColor = true;

            // Orders Label
            this.labelTitleOrder.AutoSize = true;
            this.labelTitleOrder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitleOrder.Location = new System.Drawing.Point(10, 10);
            this.labelTitleOrder.Name = "labelTitleOrder";
            this.labelTitleOrder.Size = new System.Drawing.Size(80, 32);
            this.labelTitleOrder.TabIndex = 0;
            this.labelTitleOrder.Text = "Orders";

            // Orders DataGridView
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(10, 50);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.Size = new System.Drawing.Size(600, 300);
            this.dgvOrders.TabIndex = 1;

            // Orders GroupBox
            this.groupBoxOrder.Controls.Add(this.labelOrderItemCode);
            this.groupBoxOrder.Controls.Add(this.txtOrderItemCode);
            this.groupBoxOrder.Controls.Add(this.labelOrderItemName);
            this.groupBoxOrder.Controls.Add(this.txtOrderItemName);
            this.groupBoxOrder.Controls.Add(this.labelOrderedBy);
            this.groupBoxOrder.Controls.Add(this.txtOrderedBy);
            this.groupBoxOrder.Controls.Add(this.labelOrderQuantity);
            this.groupBoxOrder.Controls.Add(this.txtOrderQuantity);
            this.groupBoxOrder.Controls.Add(this.labelOrderUnitPrice);
            this.groupBoxOrder.Controls.Add(this.txtOrderUnitPrice);
            this.groupBoxOrder.Controls.Add(this.btnAddOrder);
            this.groupBoxOrder.Controls.Add(this.btnUpdateOrder);
            this.groupBoxOrder.Controls.Add(this.btnDeleteOrder);
            this.groupBoxOrder.Controls.Add(this.btnCancelOrder);
            this.groupBoxOrder.Controls.Add(this.btnLoadOrders);
            this.groupBoxOrder.Location = new System.Drawing.Point(630, 50);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(550, 350);
            this.groupBoxOrder.TabIndex = 2;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Order Details";

            // Order Item Code
            this.labelOrderItemCode.AutoSize = true;
            this.labelOrderItemCode.Location = new System.Drawing.Point(10, 25);
            this.labelOrderItemCode.Name = "labelOrderItemCode";
            this.labelOrderItemCode.Size = new System.Drawing.Size(73, 16);
            this.labelOrderItemCode.TabIndex = 0;
            this.labelOrderItemCode.Text = "Item Code:";

            this.txtOrderItemCode.Location = new System.Drawing.Point(120, 25);
            this.txtOrderItemCode.Name = "txtOrderItemCode";
            this.txtOrderItemCode.Size = new System.Drawing.Size(200, 22);
            this.txtOrderItemCode.TabIndex = 1;

            // Order Item Name
            this.labelOrderItemName.AutoSize = true;
            this.labelOrderItemName.Location = new System.Drawing.Point(10, 55);
            this.labelOrderItemName.Name = "labelOrderItemName";
            this.labelOrderItemName.Size = new System.Drawing.Size(77, 16);
            this.labelOrderItemName.TabIndex = 2;
            this.labelOrderItemName.Text = "Item Name:";

            this.txtOrderItemName.Location = new System.Drawing.Point(120, 55);
            this.txtOrderItemName.Name = "txtOrderItemName";
            this.txtOrderItemName.ReadOnly = true;
            this.txtOrderItemName.Size = new System.Drawing.Size(200, 22);
            this.txtOrderItemName.TabIndex = 3;

            // Ordered By
            this.labelOrderedBy.AutoSize = true;
            this.labelOrderedBy.Location = new System.Drawing.Point(10, 85);
            this.labelOrderedBy.Name = "labelOrderedBy";
            this.labelOrderedBy.Size = new System.Drawing.Size(79, 16);
            this.labelOrderedBy.TabIndex = 4;
            this.labelOrderedBy.Text = "Ordered By:";

            this.txtOrderedBy.Location = new System.Drawing.Point(120, 85);
            this.txtOrderedBy.Name = "txtOrderedBy";
            this.txtOrderedBy.Size = new System.Drawing.Size(200, 22);
            this.txtOrderedBy.TabIndex = 5;

            // Order Quantity
            this.labelOrderQuantity.AutoSize = true;
            this.labelOrderQuantity.Location = new System.Drawing.Point(10, 115);
            this.labelOrderQuantity.Name = "labelOrderQuantity";
            this.labelOrderQuantity.Size = new System.Drawing.Size(67, 16);
            this.labelOrderQuantity.TabIndex = 6;
            this.labelOrderQuantity.Text = "Quantity:";

            this.txtOrderQuantity.Location = new System.Drawing.Point(120, 115);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtOrderQuantity.TabIndex = 7;

            // Order Unit Price
            this.labelOrderUnitPrice.AutoSize = true;
            this.labelOrderUnitPrice.Location = new System.Drawing.Point(10, 145);
            this.labelOrderUnitPrice.Name = "labelOrderUnitPrice";
            this.labelOrderUnitPrice.Size = new System.Drawing.Size(75, 16);
            this.labelOrderUnitPrice.TabIndex = 8;
            this.labelOrderUnitPrice.Text = "Unit Price:";

            this.txtOrderUnitPrice.Location = new System.Drawing.Point(120, 145);
            this.txtOrderUnitPrice.Name = "txtOrderUnitPrice";
            this.txtOrderUnitPrice.ReadOnly = true;
            this.txtOrderUnitPrice.Size = new System.Drawing.Size(200, 22);
            this.txtOrderUnitPrice.TabIndex = 9;

            // Order Buttons
            this.btnAddOrder.Location = new System.Drawing.Point(10, 180);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(100, 30);
            this.btnAddOrder.TabIndex = 10;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);

            this.btnUpdateOrder.Location = new System.Drawing.Point(120, 180);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateOrder.TabIndex = 11;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.BtnUpdateOrder_Click);

            this.btnDeleteOrder.Location = new System.Drawing.Point(230, 180);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteOrder.TabIndex = 12;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.BtnDeleteOrder_Click);

            this.btnCancelOrder.Location = new System.Drawing.Point(340, 180);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(100, 30);
            this.btnCancelOrder.TabIndex = 13;
            this.btnCancelOrder.Text = "Clear";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.BtnCancelOrder_Click);

            this.btnLoadOrders.Location = new System.Drawing.Point(10, 220);
            this.btnLoadOrders.Name = "btnLoadOrders";
            this.btnLoadOrders.Size = new System.Drawing.Size(430, 30);
            this.btnLoadOrders.TabIndex = 14;
            this.btnLoadOrders.Text = "Load Orders";
            this.btnLoadOrders.UseVisualStyleBackColor = true;
            this.btnLoadOrders.Click += new System.EventHandler(this.BtnLoadOrders_Click);

            // ==================== SHIPPING TAB ====================
            this.tabPageShipping.Controls.Add(this.dgvShippings);
            this.tabPageShipping.Controls.Add(this.labelTitleShip);
            this.tabPageShipping.Controls.Add(this.groupBoxShipping);
            this.tabPageShipping.Location = new System.Drawing.Point(4, 25);
            this.tabPageShipping.Name = "tabPageShipping";
            this.tabPageShipping.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShipping.Size = new System.Drawing.Size(1192, 671);
            this.tabPageShipping.TabIndex = 2;
            this.tabPageShipping.Text = "Shipping";
            this.tabPageShipping.UseVisualStyleBackColor = true;

            // Shipping Label
            this.labelTitleShip.AutoSize = true;
            this.labelTitleShip.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitleShip.Location = new System.Drawing.Point(10, 10);
            this.labelTitleShip.Name = "labelTitleShip";
            this.labelTitleShip.Size = new System.Drawing.Size(108, 32);
            this.labelTitleShip.TabIndex = 0;
            this.labelTitleShip.Text = "Shipping";

            // Shipping DataGridView
            this.dgvShippings.AllowUserToAddRows = false;
            this.dgvShippings.AllowUserToDeleteRows = false;
            this.dgvShippings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShippings.Location = new System.Drawing.Point(10, 50);
            this.dgvShippings.Name = "dgvShippings";
            this.dgvShippings.ReadOnly = true;
            this.dgvShippings.RowHeadersWidth = 51;
            this.dgvShippings.Size = new System.Drawing.Size(600, 300);
            this.dgvShippings.TabIndex = 1;

            // Shipping GroupBox
            this.groupBoxShipping.Controls.Add(this.labelShipItemCode);
            this.groupBoxShipping.Controls.Add(this.txtShipItemCode);
            this.groupBoxShipping.Controls.Add(this.labelShipItemName);
            this.groupBoxShipping.Controls.Add(this.txtShipItemName);
            this.groupBoxShipping.Controls.Add(this.labelShipOrderedBy);
            this.groupBoxShipping.Controls.Add(this.txtShipOrderedBy);
            this.groupBoxShipping.Controls.Add(this.labelShipTo);
            this.groupBoxShipping.Controls.Add(this.txtShipTo);
            this.groupBoxShipping.Controls.Add(this.labelShippingStatus);
            this.groupBoxShipping.Controls.Add(this.cmbShippingStatus);
            this.groupBoxShipping.Controls.Add(this.btnAddShipping);
            this.groupBoxShipping.Controls.Add(this.btnUpdateShipping);
            this.groupBoxShipping.Controls.Add(this.btnDeleteShipping);
            this.groupBoxShipping.Controls.Add(this.btnCancelShipping);
            this.groupBoxShipping.Controls.Add(this.btnLoadShippings);
            this.groupBoxShipping.Location = new System.Drawing.Point(630, 50);
            this.groupBoxShipping.Name = "groupBoxShipping";
            this.groupBoxShipping.Size = new System.Drawing.Size(550, 350);
            this.groupBoxShipping.TabIndex = 2;
            this.groupBoxShipping.TabStop = false;
            this.groupBoxShipping.Text = "Shipping Details";

            // Ship Item Code
            this.labelShipItemCode.AutoSize = true;
            this.labelShipItemCode.Location = new System.Drawing.Point(10, 25);
            this.labelShipItemCode.Name = "labelShipItemCode";
            this.labelShipItemCode.Size = new System.Drawing.Size(73, 16);
            this.labelShipItemCode.TabIndex = 0;
            this.labelShipItemCode.Text = "Item Code:";

            this.txtShipItemCode.Location = new System.Drawing.Point(120, 25);
            this.txtShipItemCode.Name = "txtShipItemCode";
            this.txtShipItemCode.ReadOnly = true;
            this.txtShipItemCode.Size = new System.Drawing.Size(200, 22);
            this.txtShipItemCode.TabIndex = 1;

            // Ship Item Name
            this.labelShipItemName.AutoSize = true;
            this.labelShipItemName.Location = new System.Drawing.Point(10, 55);
            this.labelShipItemName.Name = "labelShipItemName";
            this.labelShipItemName.Size = new System.Drawing.Size(77, 16);
            this.labelShipItemName.TabIndex = 2;
            this.labelShipItemName.Text = "Item Name:";

            this.txtShipItemName.Location = new System.Drawing.Point(120, 55);
            this.txtShipItemName.Name = "txtShipItemName";
            this.txtShipItemName.ReadOnly = true;
            this.txtShipItemName.Size = new System.Drawing.Size(200, 22);
            this.txtShipItemName.TabIndex = 3;

            // Ship Ordered By
            this.labelShipOrderedBy.AutoSize = true;
            this.labelShipOrderedBy.Location = new System.Drawing.Point(10, 85);
            this.labelShipOrderedBy.Name = "labelShipOrderedBy";
            this.labelShipOrderedBy.Size = new System.Drawing.Size(79, 16);
            this.labelShipOrderedBy.TabIndex = 4;
            this.labelShipOrderedBy.Text = "Ordered By:";

            this.txtShipOrderedBy.Location = new System.Drawing.Point(120, 85);
            this.txtShipOrderedBy.Name = "txtShipOrderedBy";
            this.txtShipOrderedBy.ReadOnly = true;
            this.txtShipOrderedBy.Size = new System.Drawing.Size(200, 22);
            this.txtShipOrderedBy.TabIndex = 5;

            // Ship To
            this.labelShipTo.AutoSize = true;
            this.labelShipTo.Location = new System.Drawing.Point(10, 115);
            this.labelShipTo.Name = "labelShipTo";
            this.labelShipTo.Size = new System.Drawing.Size(62, 16);
            this.labelShipTo.TabIndex = 6;
            this.labelShipTo.Text = "Ship To:";

            this.txtShipTo.Location = new System.Drawing.Point(120, 115);
            this.txtShipTo.Name = "txtShipTo";
            this.txtShipTo.Size = new System.Drawing.Size(200, 22);
            this.txtShipTo.TabIndex = 7;

            // Shipping Status
            this.labelShippingStatus.AutoSize = true;
            this.labelShippingStatus.Location = new System.Drawing.Point(10, 145);
            this.labelShippingStatus.Name = "labelShippingStatus";
            this.labelShippingStatus.Size = new System.Drawing.Size(52, 16);
            this.labelShippingStatus.TabIndex = 8;
            this.labelShippingStatus.Text = "Status:";

            this.cmbShippingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShippingStatus.FormattingEnabled = true;
            this.cmbShippingStatus.Items.AddRange(new object[] { "Pending", "In Transit", "Delivered", "Cancelled" });
            this.cmbShippingStatus.Location = new System.Drawing.Point(120, 145);
            this.cmbShippingStatus.Name = "cmbShippingStatus";
            this.cmbShippingStatus.Size = new System.Drawing.Size(200, 24);
            this.cmbShippingStatus.TabIndex = 9;

            // Shipping Buttons
            this.btnAddShipping.Location = new System.Drawing.Point(10, 180);
            this.btnAddShipping.Name = "btnAddShipping";
            this.btnAddShipping.Size = new System.Drawing.Size(100, 30);
            this.btnAddShipping.TabIndex = 10;
            this.btnAddShipping.Text = "Add";
            this.btnAddShipping.UseVisualStyleBackColor = true;
            this.btnAddShipping.Click += new System.EventHandler(this.BtnAddShipping_Click);

            this.btnUpdateShipping.Location = new System.Drawing.Point(120, 180);
            this.btnUpdateShipping.Name = "btnUpdateShipping";
            this.btnUpdateShipping.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateShipping.TabIndex = 11;
            this.btnUpdateShipping.Text = "Update";
            this.btnUpdateShipping.UseVisualStyleBackColor = true;
            this.btnUpdateShipping.Click += new System.EventHandler(this.BtnUpdateShipping_Click);

            this.btnDeleteShipping.Location = new System.Drawing.Point(230, 180);
            this.btnDeleteShipping.Name = "btnDeleteShipping";
            this.btnDeleteShipping.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteShipping.TabIndex = 12;
            this.btnDeleteShipping.Text = "Delete";
            this.btnDeleteShipping.UseVisualStyleBackColor = true;
            this.btnDeleteShipping.Click += new System.EventHandler(this.BtnDeleteShipping_Click);

            this.btnCancelShipping.Location = new System.Drawing.Point(340, 180);
            this.btnCancelShipping.Name = "btnCancelShipping";
            this.btnCancelShipping.Size = new System.Drawing.Size(100, 30);
            this.btnCancelShipping.TabIndex = 13;
            this.btnCancelShipping.Text = "Clear";
            this.btnCancelShipping.UseVisualStyleBackColor = true;
            this.btnCancelShipping.Click += new System.EventHandler(this.BtnCancelShipping_Click);

            this.btnLoadShippings.Location = new System.Drawing.Point(10, 220);
            this.btnLoadShippings.Name = "btnLoadShippings";
            this.btnLoadShippings.Size = new System.Drawing.Size(430, 30);
            this.btnLoadShippings.TabIndex = 14;
            this.btnLoadShippings.Text = "Load Shipping";
            this.btnLoadShippings.UseVisualStyleBackColor = true;
            this.btnLoadShippings.Click += new System.EventHandler(this.BtnLoadShippings_Click);

            // Resume layout
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippings)).EndInit();
            this.groupBoxInventory.ResumeLayout(false);
            this.groupBoxInventory.PerformLayout();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.groupBoxShipping.ResumeLayout(false);
            this.groupBoxShipping.PerformLayout();
            this.tabPageInventory.ResumeLayout(false);
            this.tabPageInventory.PerformLayout();
            this.tabPageOrdering.ResumeLayout(false);
            this.tabPageOrdering.PerformLayout();
            this.tabPageShipping.ResumeLayout(false);
            this.tabPageShipping.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPageOrdering;
        private System.Windows.Forms.TabPage tabPageShipping;

        // Inventory controls
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label labelTitleInv;
        private System.Windows.Forms.GroupBox groupBoxInventory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.Button btnLoad;

        // Orders controls
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label labelTitleOrder;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.Label labelOrderItemCode;
        private System.Windows.Forms.TextBox txtOrderItemCode;
        private System.Windows.Forms.Label labelOrderItemName;
        private System.Windows.Forms.TextBox txtOrderItemName;
        private System.Windows.Forms.Label labelOrderedBy;
        private System.Windows.Forms.TextBox txtOrderedBy;
        private System.Windows.Forms.Label labelOrderQuantity;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.Label labelOrderUnitPrice;
        private System.Windows.Forms.TextBox txtOrderUnitPrice;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnLoadOrders;

        // Shipping controls
        private System.Windows.Forms.DataGridView dgvShippings;
        private System.Windows.Forms.Label labelTitleShip;
        private System.Windows.Forms.GroupBox groupBoxShipping;
        private System.Windows.Forms.Label labelShipItemCode;
        private System.Windows.Forms.TextBox txtShipItemCode;
        private System.Windows.Forms.Label labelShipItemName;
        private System.Windows.Forms.TextBox txtShipItemName;
        private System.Windows.Forms.Label labelShipOrderedBy;
        private System.Windows.Forms.TextBox txtShipOrderedBy;
        private System.Windows.Forms.Label labelShipTo;
        private System.Windows.Forms.TextBox txtShipTo;
        private System.Windows.Forms.Label labelShippingStatus;
        private System.Windows.Forms.ComboBox cmbShippingStatus;
        private System.Windows.Forms.Button btnAddShipping;
        private System.Windows.Forms.Button btnUpdateShipping;
        private System.Windows.Forms.Button btnDeleteShipping;
        private System.Windows.Forms.Button btnCancelShipping;
        private System.Windows.Forms.Button btnLoadShippings;
    }
}
