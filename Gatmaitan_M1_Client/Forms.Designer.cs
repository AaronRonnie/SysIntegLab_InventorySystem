using System;
using System.Drawing;
using System.Windows.Forms;

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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvItems = new DataGridView();
            labelTitle = new Label();
            groupBox1 = new GroupBox();
            txtQuantity = new TextBox();
            labelQuantity = new Label();
            txtUnitPrice = new TextBox();
            btnLoad = new Button();
            labelUnitPrice = new Label();
            btnCancel = new Button();
            txtBrand = new TextBox();
            btnSave = new Button();
            labelBrand = new Label();
            btnDelete = new Button();
            txtCode = new TextBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            labelCode = new Label();
            txtName = new TextBox();
            labelName = new Label();
            labelSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            tabControlMain = new TabControl();
            tabPageInventory = new TabPage();
            tabPageOrdering = new TabPage();
            tabPageShipping = new TabPage();
            labelOrderItemCode = new Label();
            txtOrderItemCode = new TextBox();
            labelOrderItemName = new Label();
            textBox1 = new TextBox();
            labelOrderedBy = new Label();
            txtOrderedBy = new TextBox();
            labelOrderQuantity = new Label();
            txtOrderQuantity = new TextBox();
            textBox2 = new TextBox();
            labelOrderUnitPrice = new Label();
            dgvOrders = new DataGridView();
            labelOrderTitle = new Label();
            groupBoxOrderDetails = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            groupBox1.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageInventory.SuspendLayout();
            tabPageOrdering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(61, 46);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(601, 381);
            dgvItems.TabIndex = 0;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = SystemColors.GradientActiveCaption;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(20, 0, 20, 0);
            labelTitle.Size = new Size(1134, 71);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Inventory Management";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            labelTitle.Click += labelTitle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(labelQuantity);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(labelUnitPrice);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(txtBrand);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(labelBrand);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(labelCode);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(labelName);
            groupBox1.Location = new Point(765, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 381);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(110, 209);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(180, 31);
            txtQuantity.TabIndex = 9;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            labelQuantity.Location = new Point(18, 214);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(91, 23);
            labelQuantity.TabIndex = 8;
            labelQuantity.Text = "Quantity:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(110, 167);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(180, 31);
            txtUnitPrice.TabIndex = 7;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.SteelBlue;
            btnLoad.FlatStyle = FlatStyle.Popup;
            btnLoad.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnLoad.ForeColor = SystemColors.ButtonFace;
            btnLoad.Location = new Point(18, 300);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(272, 28);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Load Items";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // labelUnitPrice
            // 
            labelUnitPrice.AutoSize = true;
            labelUnitPrice.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            labelUnitPrice.Location = new Point(18, 172);
            labelUnitPrice.Name = "labelUnitPrice";
            labelUnitPrice.Size = new Size(100, 23);
            labelUnitPrice.TabIndex = 6;
            labelUnitPrice.Text = "Unit Price:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.MidnightBlue;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold | FontStyle.Italic);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(200, 347);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(110, 125);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(180, 31);
            txtBrand.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(18, 347);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 28);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            labelBrand.Location = new Point(18, 130);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(66, 23);
            labelBrand.TabIndex = 4;
            labelBrand.Text = "Brand:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.FlatAppearance.BorderColor = Color.Black;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(205, 266);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 28);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(110, 41);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(180, 31);
            txtCode.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(112, 266);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 28);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update Item";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(18, 266);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 28);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            labelCode.Location = new Point(18, 46);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(58, 23);
            labelCode.TabIndex = 2;
            labelCode.Text = "Code:";
            // 
            // txtName
            // 
            txtName.Location = new Point(110, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 31);
            txtName.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            labelName.Location = new Point(18, 88);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 23);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.BackColor = SystemColors.GradientActiveCaption;
            labelSearch.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearch.Location = new Point(638, 29);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(74, 23);
            labelSearch.TabIndex = 9;
            labelSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(701, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(160, 31);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(868, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(81, 27);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageInventory);
            tabControlMain.Controls.Add(tabPageOrdering);
            tabControlMain.Controls.Add(tabPageShipping);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 71);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1134, 526);
            tabControlMain.TabIndex = 12;
            // 
            // tabPageInventory
            // 
            tabPageInventory.Controls.Add(dgvItems);
            tabPageInventory.Controls.Add(groupBox1);
            tabPageInventory.Location = new Point(4, 34);
            tabPageInventory.Name = "tabPageInventory";
            tabPageInventory.Padding = new Padding(3);
            tabPageInventory.Size = new Size(1126, 488);
            tabPageInventory.TabIndex = 0;
            tabPageInventory.Text = "Inventory";
            tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // tabPageOrdering
            // 
            tabPageOrdering.Controls.Add(groupBoxOrderDetails);
            tabPageOrdering.Controls.Add(labelOrderTitle);
            tabPageOrdering.Controls.Add(dgvOrders);
            tabPageOrdering.Controls.Add(labelOrderUnitPrice);
            tabPageOrdering.Controls.Add(textBox2);
            tabPageOrdering.Controls.Add(txtOrderQuantity);
            tabPageOrdering.Controls.Add(labelOrderQuantity);
            tabPageOrdering.Controls.Add(txtOrderedBy);
            tabPageOrdering.Controls.Add(labelOrderedBy);
            tabPageOrdering.Controls.Add(textBox1);
            tabPageOrdering.Controls.Add(labelOrderItemName);
            tabPageOrdering.Controls.Add(txtOrderItemCode);
            tabPageOrdering.Controls.Add(labelOrderItemCode);
            tabPageOrdering.Location = new Point(4, 34);
            tabPageOrdering.Name = "tabPageOrdering";
            tabPageOrdering.Padding = new Padding(3);
            tabPageOrdering.Size = new Size(1126, 488);
            tabPageOrdering.TabIndex = 1;
            tabPageOrdering.Text = "Ordering";
            tabPageOrdering.UseVisualStyleBackColor = true;
            // 
            // tabPageShipping
            // 
            tabPageShipping.Location = new Point(4, 34);
            tabPageShipping.Name = "tabPageShipping";
            tabPageShipping.Padding = new Padding(3);
            tabPageShipping.Size = new Size(1126, 488);
            tabPageShipping.TabIndex = 2;
            tabPageShipping.Text = "Shipping";
            tabPageShipping.UseVisualStyleBackColor = true;
            // 
            // labelOrderItemCode
            // 
            labelOrderItemCode.AutoSize = true;
            labelOrderItemCode.Location = new Point(636, 17);
            labelOrderItemCode.Name = "labelOrderItemCode";
            labelOrderItemCode.Size = new Size(99, 25);
            labelOrderItemCode.TabIndex = 0;
            labelOrderItemCode.Text = "Item Code:";
            // 
            // txtOrderItemCode
            // 
            txtOrderItemCode.Location = new Point(748, 17);
            txtOrderItemCode.Name = "txtOrderItemCode";
            txtOrderItemCode.Size = new Size(330, 31);
            txtOrderItemCode.TabIndex = 1;
            // 
            // labelOrderItemName
            // 
            labelOrderItemName.AutoSize = true;
            labelOrderItemName.Location = new Point(636, 60);
            labelOrderItemName.Name = "labelOrderItemName";
            labelOrderItemName.Size = new Size(104, 25);
            labelOrderItemName.TabIndex = 2;
            labelOrderItemName.Text = "Item Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(748, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 31);
            textBox1.TabIndex = 3;
            // 
            // labelOrderedBy
            // 
            labelOrderedBy.AutoSize = true;
            labelOrderedBy.Location = new Point(636, 106);
            labelOrderedBy.Name = "labelOrderedBy";
            labelOrderedBy.Size = new Size(106, 25);
            labelOrderedBy.TabIndex = 4;
            labelOrderedBy.Text = "Ordered By:";
            // 
            // txtOrderedBy
            // 
            txtOrderedBy.Location = new Point(748, 106);
            txtOrderedBy.Name = "txtOrderedBy";
            txtOrderedBy.Size = new Size(330, 31);
            txtOrderedBy.TabIndex = 5;
            // 
            // labelOrderQuantity
            // 
            labelOrderQuantity.AutoSize = true;
            labelOrderQuantity.Location = new Point(636, 149);
            labelOrderQuantity.Name = "labelOrderQuantity";
            labelOrderQuantity.Size = new Size(84, 25);
            labelOrderQuantity.TabIndex = 6;
            labelOrderQuantity.Text = "Quantity:";
            // 
            // txtOrderQuantity
            // 
            txtOrderQuantity.Location = new Point(748, 149);
            txtOrderQuantity.Name = "txtOrderQuantity";
            txtOrderQuantity.Size = new Size(330, 31);
            txtOrderQuantity.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(748, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 8;
            // 
            // labelOrderUnitPrice
            // 
            labelOrderUnitPrice.AutoSize = true;
            labelOrderUnitPrice.Location = new Point(636, 200);
            labelOrderUnitPrice.Name = "labelOrderUnitPrice";
            labelOrderUnitPrice.Size = new Size(90, 25);
            labelOrderUnitPrice.TabIndex = 9;
            labelOrderUnitPrice.Text = "Unit Price:";
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(10, 60);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.Size = new Size(600, 350);
            dgvOrders.TabIndex = 10;
            // 
            // labelOrderTitle
            // 
            labelOrderTitle.AutoSize = true;
            labelOrderTitle.Location = new Point(10, 10);
            labelOrderTitle.Name = "labelOrderTitle";
            labelOrderTitle.Size = new Size(97, 25);
            labelOrderTitle.TabIndex = 11;
            labelOrderTitle.Text = "Orders List";
            // 
            // groupBoxOrderDetails
            // 
            groupBoxOrderDetails.Location = new Point(620, 60);
            groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            groupBoxOrderDetails.Size = new Size(360, 500);
            groupBoxOrderDetails.TabIndex = 12;
            groupBoxOrderDetails.TabStop = false;
            groupBoxOrderDetails.Text = "Order Details";
            // 
            // Forms
            // 
            ClientSize = new Size(1134, 597);
            Controls.Add(tabControlMain);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(labelSearch);
            Controls.Add(labelTitle);
            Name = "Forms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management";
            Load += Forms_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabPageInventory.ResumeLayout(false);
            tabPageOrdering.ResumeLayout(false);
            tabPageOrdering.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private TabControl tabControlMain;
        private TabPage tabPageInventory;
        private TabPage tabPageOrdering;
        private TabPage tabPageShipping;
        private DataGridView dgvOrders;
        private Label labelOrderUnitPrice;
        private TextBox textBox2;
        private TextBox txtOrderQuantity;
        private Label labelOrderQuantity;
        private TextBox txtOrderedBy;
        private Label labelOrderedBy;
        private TextBox textBox1;
        private Label labelOrderItemName;
        private TextBox txtOrderItemCode;
        private Label labelOrderItemCode;
        private GroupBox groupBoxOrderDetails;
        private Label labelOrderTitle;
    }
}

