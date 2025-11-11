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
            // Tab Control
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.tabPageOrdering = new System.Windows.Forms.TabPage();
            this.tabPageShipping = new System.Windows.Forms.TabPage();

            // INVENTORY TAB CONTROLS
            this.labelTitleInv = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.groupBoxItemDetails = new System.Windows.Forms.GroupBox();
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();

            // ORDERING TAB CONTROLS
            this.labelTitleOrder = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.groupBoxOrderDetails = new System.Windows.Forms.GroupBox();
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
            this.btnLoadOrders = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();

            // SHIPPING TAB CONTROLS
            this.labelTitleShip = new System.Windows.Forms.Label();
            this.dgvShippings = new System.Windows.Forms.DataGridView();
            this.groupBoxShippingDetails = new System.Windows.Forms.GroupBox();
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
            this.btnLoadShippings = new System.Windows.Forms.Button();
            this.btnCancelShipping = new System.Windows.Forms.Button();

            // SUSPEND LAYOUT
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippings)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            this.tabPageOrdering.SuspendLayout();
            this.tabPageShipping.SuspendLayout();
            this.groupBoxItemDetails.SuspendLayout();
            this.groupBoxOrderDetails.SuspendLayout();
            this.groupBoxShippingDetails.SuspendLayout();
            this.SuspendLayout();

            // ==================== TAB CONTROL ====================
            this.tabControlMain.Controls.Add(this.tabPageInventory);
            this.tabControlMain.Controls.Add(this.tabPageOrdering);
            this.tabControlMain.Controls.Add(this.tabPageShipping);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1050, 650);
            this.tabControlMain.TabIndex = 0;

            // ==================== INVENTORY TAB ====================
            this.tabPageInventory.Controls.Add(this.labelTitleInv);
            this.tabPageInventory.Controls.Add(this.dgvItems);
            this.tabPageInventory.Controls.Add(this.groupBoxItemDetails);
            this.tabPageInventory.Location = new System.Drawing.Point(4, 24);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageInventory.Size = new System.Drawing.Size(1042, 622);
            this.tabPageInventory.TabIndex = 0;
            this.tabPageInventory.Text = "Inventory";
            this.tabPageInventory.UseVisualStyleBackColor = true;

            // Title Label
            this.labelTitleInv.AutoSize = true;
            this.labelTitleInv.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitleInv.Location = new System.Drawing.Point(10, 10);
            this.labelTitleInv.Name = "labelTitleInv";
            this.labelTitleInv.Size = new System.Drawing.Size(150, 25);
            this.labelTitleInv.TabIndex = 0;
            this.labelTitleInv.Text = "Inventory Items";

            // DataGridView
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(10, 40);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(600, 560);
            this.dgvItems.TabIndex = 1;

            // GroupBox
            this.groupBoxItemDetails.Controls.Add(this.labelName);
            this.groupBoxItemDetails.Controls.Add(this.txtName);
            this.groupBoxItemDetails.Controls.Add(this.labelCode);
            this.groupBoxItemDetails.Controls.Add(this.txtCode);
            this.groupBoxItemDetails.Controls.Add(this.labelBrand);
            this.groupBoxItemDetails.Controls.Add(this.txtBrand);
            this.groupBoxItemDetails.Controls.Add(this.labelUnitPrice);
            this.groupBoxItemDetails.Controls.Add(this.txtUnitPrice);
            this.groupBoxItemDetails.Controls.Add(this.labelQuantity);
            this.groupBoxItemDetails.Controls.Add(this.txtQuantity);
            this.groupBoxItemDetails.Controls.Add(this.btnAdd);
            this.groupBoxItemDetails.Controls.Add(this.btnUpdate);
            this.groupBoxItemDetails.Controls.Add(this.btnDelete);
            this.groupBoxItemDetails.Controls.Add(this.btnLoad);
            this.groupBoxItemDetails.Controls.Add(this.btnCancelItem);
            this.groupBoxItemDetails.Location = new System.Drawing.Point(620, 40);
            this.groupBoxItemDetails.Name = "groupBoxItemDetails";
            this.groupBoxItemDetails.Size = new System.Drawing.Size(410, 560);
            this.groupBoxItemDetails.TabIndex = 2;
            this.groupBoxItemDetails.TabStop = false;
            this.groupBoxItemDetails.Text = "Item Details";

            // Item Name
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            this.txtName.Location = new System.Drawing.Point(15, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(380, 23);
            this.txtName.TabIndex = 1;

            // Item Code
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(15, 75);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(42, 15);
            this.labelCode.TabIndex = 2;
            this.labelCode.Text = "Code:";
            this.txtCode.Location = new System.Drawing.Point(15, 95);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(380, 23);
            this.txtCode.TabIndex = 3;

            // Brand
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(15, 125);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(45, 15);
            this.labelBrand.TabIndex = 4;
            this.labelBrand.Text = "Brand:";
            this.txtBrand.Location = new System.Drawing.Point(15, 145);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(380, 23);
            this.txtBrand.TabIndex = 5;

            // Unit Price
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(15, 175);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(67, 15);
            this.labelUnitPrice.TabIndex = 6;
            this.labelUnitPrice.Text = "Unit Price:";
            this.txtUnitPrice.Location = new System.Drawing.Point(15, 195);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(380, 23);
            this.txtUnitPrice.TabIndex = 7;

            // Quantity
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(15, 225);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(64, 15);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Quantity:";
            this.txtQuantity.Location = new System.Drawing.Point(15, 245);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(380, 23);
            this.txtQuantity.TabIndex = 9;

            // Buttons
            this.btnAdd.Location = new System.Drawing.Point(15, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(100, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(185, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            this.btnLoad.Location = new System.Drawing.Point(270, 280);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 30);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load Items";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);

            this.btnCancelItem.Location = new System.Drawing.Point(15, 320);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(380, 30);
            this.btnCancelItem.TabIndex = 14;
            this.btnCancelItem.Text = "Clear";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.BtnCancelItem_Click);

            // ==================== ORDERING TAB ====================
            this.tabPageOrdering.Controls.Add(this.labelTitleOrder);
            this.tabPageOrdering.Controls.Add(this.dgvOrders);
            this.tabPageOrdering.Controls.Add(this.groupBoxOrderDetails);
            this.tabPageOrdering.Location = new System.Drawing.Point(4, 24);
            this.tabPageOrdering.Name = "tabPageOrdering";
            this.tabPageOrdering.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageOrdering.Size = new System.Drawing.Size(1042, 622);
            this.tabPageOrdering.TabIndex = 1;
            this.tabPageOrdering.Text = "Orders";
            this.tabPageOrdering.UseVisualStyleBackColor = true;

            // Title Label
            this.labelTitleOrder.AutoSize = true;
            this.labelTitleOrder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitleOrder.Location = new System.Drawing.Point(10, 10);
            this.labelTitleOrder.Name = "labelTitleOrder";
            this.labelTitleOrder.Size = new System.Drawing.Size(100, 25);
            this.labelTitleOrder.TabIndex = 0;
            this.labelTitleOrder.Text = "Orders";

            // DataGridView
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(10, 40);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(600, 560);
            this.dgvOrders.TabIndex = 1;

            // GroupBox
            this.groupBoxOrderDetails.Controls.Add(this.labelOrderItemCode);
            this.groupBoxOrderDetails.Controls.Add(this.txtOrderItemCode);
            this.groupBoxOrderDetails.Controls.Add(this.labelOrderItemName);
            this.groupBoxOrderDetails.Controls.Add(this.txtOrderItemName);
            this.groupBoxOrderDetails.Controls.Add(this.labelOrderedBy);
            this.groupBoxOrderDetails.Controls.Add(this.txtOrderedBy);
            this.groupBoxOrderDetails.Controls.Add(this.labelOrderQuantity);
            this.groupBoxOrderDetails.Controls.Add(this.txtOrderQuantity);
            this.groupBoxOrderDetails.Controls.Add(this.labelOrderUnitPrice);
            this.groupBoxOrderDetails.Controls.Add(this.txtOrderUnitPrice);
            this.groupBoxOrderDetails.Controls.Add(this.btnAddOrder);
            this.groupBoxOrderDetails.Controls.Add(this.btnUpdateOrder);
            this.groupBoxOrderDetails.Controls.Add(this.btnDeleteOrder);
            this.groupBoxOrderDetails.Controls.Add(this.btnLoadOrders);
            this.groupBoxOrderDetails.Controls.Add(this.btnCancelOrder);
            this.groupBoxOrderDetails.Location = new System.Drawing.Point(620, 40);
            this.groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            this.groupBoxOrderDetails.Size = new System.Drawing.Size(410, 560);
            this.groupBoxOrderDetails.TabIndex = 2;
            this.groupBoxOrderDetails.TabStop = false;
            this.groupBoxOrderDetails.Text = "Order Details";

            // Item Code
            this.labelOrderItemCode.AutoSize = true;
            this.labelOrderItemCode.Location = new System.Drawing.Point(15, 25);
            this.labelOrderItemCode.Name = "labelOrderItemCode";
            this.labelOrderItemCode.Size = new System.Drawing.Size(67, 15);
            this.labelOrderItemCode.TabIndex = 0;
            this.labelOrderItemCode.Text = "Item Code:";
            this.txtOrderItemCode.Location = new System.Drawing.Point(15, 45);
            this.txtOrderItemCode.Name = "txtOrderItemCode";
            this.txtOrderItemCode.Size = new System.Drawing.Size(380, 23);
            this.txtOrderItemCode.TabIndex = 1;

            // Item Name
            this.labelOrderItemName.AutoSize = true;
            this.labelOrderItemName.Location = new System.Drawing.Point(15, 75);
            this.labelOrderItemName.Name = "labelOrderItemName";
            this.labelOrderItemName.Size = new System.Drawing.Size(70, 15);
            this.labelOrderItemName.TabIndex = 2;
            this.labelOrderItemName.Text = "Item Name:";
            this.txtOrderItemName.Location = new System.Drawing.Point(15, 95);
            this.txtOrderItemName.Name = "txtOrderItemName";
            this.txtOrderItemName.Size = new System.Drawing.Size(380, 23);
            this.txtOrderItemName.TabIndex = 3;

            // Ordered By
            this.labelOrderedBy.AutoSize = true;
            this.labelOrderedBy.Location = new System.Drawing.Point(15, 125);
            this.labelOrderedBy.Name = "labelOrderedBy";
            this.labelOrderedBy.Size = new System.Drawing.Size(68, 15);
            this.labelOrderedBy.TabIndex = 4;
            this.labelOrderedBy.Text = "Ordered By:";
            this.txtOrderedBy.Location = new System.Drawing.Point(15, 145);
            this.txtOrderedBy.Name = "txtOrderedBy";
            this.txtOrderedBy.Size = new System.Drawing.Size(380, 23);
            this.txtOrderedBy.TabIndex = 5;

            // Order Quantity
            this.labelOrderQuantity.AutoSize = true;
            this.labelOrderQuantity.Location = new System.Drawing.Point(15, 175);
            this.labelOrderQuantity.Name = "labelOrderQuantity";
            this.labelOrderQuantity.Size = new System.Drawing.Size(64, 15);
            this.labelOrderQuantity.TabIndex = 6;
            this.labelOrderQuantity.Text = "Quantity:";
            this.txtOrderQuantity.Location = new System.Drawing.Point(15, 195);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(380, 23);
            this.txtOrderQuantity.TabIndex = 7;

            // Unit Price
            this.labelOrderUnitPrice.AutoSize = true;
            this.labelOrderUnitPrice.Location = new System.Drawing.Point(15, 225);
            this.labelOrderUnitPrice.Name = "labelOrderUnitPrice";
            this.labelOrderUnitPrice.Size = new System.Drawing.Size(67, 15);
            this.labelOrderUnitPrice.TabIndex = 8;
            this.labelOrderUnitPrice.Text = "Unit Price:";
            this.txtOrderUnitPrice.Location = new System.Drawing.Point(15, 245);
            this.txtOrderUnitPrice.Name = "txtOrderUnitPrice";
            this.txtOrderUnitPrice.Size = new System.Drawing.Size(380, 23);
            this.txtOrderUnitPrice.TabIndex = 9;
            this.txtOrderUnitPrice.ReadOnly = true;

            // Buttons
            this.btnAddOrder.Location = new System.Drawing.Point(15, 280);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 30);
            this.btnAddOrder.TabIndex = 10;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);

            this.btnUpdateOrder.Location = new System.Drawing.Point(100, 280);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateOrder.TabIndex = 11;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.BtnUpdateOrder_Click);

            this.btnDeleteOrder.Location = new System.Drawing.Point(185, 280);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteOrder.TabIndex = 12;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.BtnDeleteOrder_Click);

            this.btnLoadOrders.Location = new System.Drawing.Point(270, 280);
            this.btnLoadOrders.Name = "btnLoadOrders";
            this.btnLoadOrders.Size = new System.Drawing.Size(125, 30);
            this.btnLoadOrders.TabIndex = 13;
            this.btnLoadOrders.Text = "Load Orders";
            this.btnLoadOrders.UseVisualStyleBackColor = true;
            this.btnLoadOrders.Click += new System.EventHandler(this.BtnLoadOrders_Click);

            this.btnCancelOrder.Location = new System.Drawing.Point(15, 320);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(380, 30);
            this.btnCancelOrder.TabIndex = 14;
            this.btnCancelOrder.Text = "Clear";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.BtnCancelOrder_Click);

            // ==================== SHIPPING TAB ====================
            this.tabPageShipping.Controls.Add(this.labelTitleShip);
            this.tabPageShipping.Controls.Add(this.dgvShippings);
            this.tabPageShipping.Controls.Add(this.groupBoxShippingDetails);
            this.tabPageShipping.Location = new System.Drawing.Point(4, 24);
            this.tabPageShipping.Name = "tabPageShipping";
            this.tabPageShipping.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageShipping.Size = new System.Drawing.Size(1042, 622);
            this.tabPageShipping.TabIndex = 2;
            this.tabPageShipping.Text = "Shipping";
            this.tabPageShipping.UseVisualStyleBackColor = true;

            // Title Label
            this.labelTitleShip.AutoSize = true;
            this.labelTitleShip.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitleShip.Location = new System.Drawing.Point(10, 10);
            this.labelTitleShip.Name = "labelTitleShip";
            this.labelTitleShip.Size = new System.Drawing.Size(100, 25);
            this.labelTitleShip.TabIndex = 0;
            this.labelTitleShip.Text = "Shipping";

            // DataGridView
            this.dgvShippings.AllowUserToAddRows = false;
            this.dgvShippings.AllowUserToDeleteRows = false;
            this.dgvShippings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShippings.Location = new System.Drawing.Point(10, 40);
            this.dgvShippings.Name = "dgvShippings";
            this.dgvShippings.ReadOnly = true;
            this.dgvShippings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShippings.Size = new System.Drawing.Size(600, 560);
            this.dgvShippings.TabIndex = 1;

            // GroupBox
            this.groupBoxShippingDetails.Controls.Add(this.labelShipItemCode);
            this.groupBoxShippingDetails.Controls.Add(this.txtShipItemCode);
            this.groupBoxShippingDetails.Controls.Add(this.labelShipItemName);
            this.groupBoxShippingDetails.Controls.Add(this.txtShipItemName);
            this.groupBoxShippingDetails.Controls.Add(this.labelShipOrderedBy);
            this.groupBoxShippingDetails.Controls.Add(this.txtShipOrderedBy);
            this.groupBoxShippingDetails.Controls.Add(this.labelShipTo);
            this.groupBoxShippingDetails.Controls.Add(this.txtShipTo);
            this.groupBoxShippingDetails.Controls.Add(this.labelShippingStatus);
            this.groupBoxShippingDetails.Controls.Add(this.cmbShippingStatus);
            this.groupBoxShippingDetails.Controls.Add(this.btnAddShipping);
            this.groupBoxShippingDetails.Controls.Add(this.btnUpdateShipping);
            this.groupBoxShippingDetails.Controls.Add(this.btnDeleteShipping);
            this.groupBoxShippingDetails.Controls.Add(this.btnLoadShippings);
            this.groupBoxShippingDetails.Controls.Add(this.btnCancelShipping);
            this.groupBoxShippingDetails.Location = new System.Drawing.Point(620, 40);
            this.groupBoxShippingDetails.Name = "groupBoxShippingDetails";
            this.groupBoxShippingDetails.Size = new System.Drawing.Size(410, 560);
            this.groupBoxShippingDetails.TabIndex = 2;
            this.groupBoxShippingDetails.TabStop = false;
            this.groupBoxShippingDetails.Text = "Shipping Details";

            // Item Code
            this.labelShipItemCode.AutoSize = true;
            this.labelShipItemCode.Location = new System.Drawing.Point(15, 25);
            this.labelShipItemCode.Name = "labelShipItemCode";
            this.labelShipItemCode.Size = new System.Drawing.Size(67, 15);
            this.labelShipItemCode.TabIndex = 0;
            this.labelShipItemCode.Text = "Item Code:";
            this.txtShipItemCode.Location = new System.Drawing.Point(15, 45);
            this.txtShipItemCode.Name = "txtShipItemCode";
            this.txtShipItemCode.Size = new System.Drawing.Size(380, 23);
            this.txtShipItemCode.TabIndex = 1;

            // Item Name
            this.labelShipItemName.AutoSize = true;
            this.labelShipItemName.Location = new System.Drawing.Point(15, 75);
            this.labelShipItemName.Name = "labelShipItemName";
            this.labelShipItemName.Size = new System.Drawing.Size(70, 15);
            this.labelShipItemName.TabIndex = 2;
            this.labelShipItemName.Text = "Item Name:";
            this.txtShipItemName.Location = new System.Drawing.Point(15, 95);
            this.txtShipItemName.Name = "txtShipItemName";
            this.txtShipItemName.Size = new System.Drawing.Size(380, 23);
            this.txtShipItemName.TabIndex = 3;

            // Ordered By
            this.labelShipOrderedBy.AutoSize = true;
            this.labelShipOrderedBy.Location = new System.Drawing.Point(15, 125);
            this.labelShipOrderedBy.Name = "labelShipOrderedBy";
            this.labelShipOrderedBy.Size = new System.Drawing.Size(68, 15);
            this.labelShipOrderedBy.TabIndex = 4;
            this.labelShipOrderedBy.Text = "Ordered By:";
            this.txtShipOrderedBy.Location = new System.Drawing.Point(15, 145);
            this.txtShipOrderedBy.Name = "txtShipOrderedBy";
            this.txtShipOrderedBy.Size = new System.Drawing.Size(380, 23);
            this.txtShipOrderedBy.TabIndex = 5;

            // Ship To
            this.labelShipTo.AutoSize = true;
            this.labelShipTo.Location = new System.Drawing.Point(15, 175);
            this.labelShipTo.Name = "labelShipTo";
            this.labelShipTo.Size = new System.Drawing.Size(57, 15);
            this.labelShipTo.TabIndex = 6;
            this.labelShipTo.Text = "Ship To:";
            this.txtShipTo.Location = new System.Drawing.Point(15, 195);
            this.txtShipTo.Name = "txtShipTo";
            this.txtShipTo.Size = new System.Drawing.Size(380, 23);
            this.txtShipTo.TabIndex = 7;

            // Status
            this.labelShippingStatus.AutoSize = true;
            this.labelShippingStatus.Location = new System.Drawing.Point(15, 225);
            this.labelShippingStatus.Name = "labelShippingStatus";
            this.labelShippingStatus.Size = new System.Drawing.Size(46, 15);
            this.labelShippingStatus.TabIndex = 8;
            this.labelShippingStatus.Text = "Status:";
            this.cmbShippingStatus.Items.AddRange(new object[] { "Pending", "In Transit", "Delivered", "Cancelled" });
            this.cmbShippingStatus.Location = new System.Drawing.Point(15, 245);
            this.cmbShippingStatus.Name = "cmbShippingStatus";
            this.cmbShippingStatus.Size = new System.Drawing.Size(380, 23);
            this.cmbShippingStatus.TabIndex = 9;

            // Buttons
            this.btnAddShipping.Location = new System.Drawing.Point(15, 280);
            this.btnAddShipping.Name = "btnAddShipping";
            this.btnAddShipping.Size = new System.Drawing.Size(75, 30);
            this.btnAddShipping.TabIndex = 10;
            this.btnAddShipping.Text = "Add";
            this.btnAddShipping.UseVisualStyleBackColor = true;
            this.btnAddShipping.Click += new System.EventHandler(this.BtnAddShipping_Click);

            this.btnUpdateShipping.Location = new System.Drawing.Point(100, 280);
            this.btnUpdateShipping.Name = "btnUpdateShipping";
            this.btnUpdateShipping.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateShipping.TabIndex = 11;
            this.btnUpdateShipping.Text = "Update";
            this.btnUpdateShipping.UseVisualStyleBackColor = true;
            this.btnUpdateShipping.Click += new System.EventHandler(this.BtnUpdateShipping_Click);

            this.btnDeleteShipping.Location = new System.Drawing.Point(185, 280);
            this.btnDeleteShipping.Name = "btnDeleteShipping";
            this.btnDeleteShipping.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteShipping.TabIndex = 12;
            this.btnDeleteShipping.Text = "Delete";
            this.btnDeleteShipping.UseVisualStyleBackColor = true;
            this.btnDeleteShipping.Click += new System.EventHandler(this.BtnDeleteShipping_Click);

            this.btnLoadShippings.Location = new System.Drawing.Point(270, 280);
            this.btnLoadShippings.Name = "btnLoadShippings";
            this.btnLoadShippings.Size = new System.Drawing.Size(125, 30);
            this.btnLoadShippings.TabIndex = 13;
            this.btnLoadShippings.Text = "Load Shipping";
            this.btnLoadShippings.UseVisualStyleBackColor = true;
            this.btnLoadShippings.Click += new System.EventHandler(this.BtnLoadShippings_Click);

            this.btnCancelShipping.Location = new System.Drawing.Point(15, 320);
            this.btnCancelShipping.Name = "btnCancelShipping";
            this.btnCancelShipping.Size = new System.Drawing.Size(380, 30);
            this.btnCancelShipping.TabIndex = 14;
            this.btnCancelShipping.Text = "Clear";
            this.btnCancelShipping.UseVisualStyleBackColor = true;
            this.btnCancelShipping.Click += new System.EventHandler(this.BtnCancelShipping_Click);

            // ==================== MAIN FORM ====================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Forms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Forms_Load);

            // RESUME LAYOUT
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippings)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageInventory.ResumeLayout(false);
            this.tabPageInventory.PerformLayout();
            this.tabPageOrdering.ResumeLayout(false);
            this.tabPageOrdering.PerformLayout();
            this.tabPageShipping.ResumeLayout(false);
            this.tabPageShipping.PerformLayout();
            this.groupBoxItemDetails.ResumeLayout(false);
            this.groupBoxItemDetails.PerformLayout();
            this.groupBoxOrderDetails.ResumeLayout(false);
            this.groupBoxOrderDetails.PerformLayout();
            this.groupBoxShippingDetails.ResumeLayout(false);
            this.groupBoxShippingDetails.PerformLayout();
            this.ResumeLayout(false);
        }

        // Controls - Tab
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPageOrdering;
        private System.Windows.Forms.TabPage tabPageShipping;

        // Controls - Inventory
        private System.Windows.Forms.Label labelTitleInv;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.GroupBox groupBoxItemDetails;
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
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCancelItem;

        // Controls - Orders
        private System.Windows.Forms.Label labelTitleOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.GroupBox groupBoxOrderDetails;
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
        private System.Windows.Forms.Button btnLoadOrders;
        private System.Windows.Forms.Button btnCancelOrder;

        // Controls - Shipping
        private System.Windows.Forms.Label labelTitleShip;
        private System.Windows.Forms.DataGridView dgvShippings;
        private System.Windows.Forms.GroupBox groupBoxShippingDetails;
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
        private System.Windows.Forms.Button btnLoadShippings;
        private System.Windows.Forms.Button btnCancelShipping;
    }
}
