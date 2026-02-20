namespace v._3._0.Order
{
    partial class OrderUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Back = new Button();
            OrderDataGrid = new DataGridView();
            Customer = new DataGridViewTextBoxColumn();
            IDColumn = new DataGridViewTextBoxColumn();
            ProductColumn = new DataGridViewTextBoxColumn();
            PriceCol = new DataGridViewTextBoxColumn();
            QtyColumn = new DataGridViewTextBoxColumn();
            DiscountColumn = new DataGridViewTextBoxColumn();
            TotalColumn = new DataGridViewTextBoxColumn();
            DiscountText = new TextBox();
            IDText = new TextBox();
            QuantityOrder = new Label();
            PriceOrder = new Label();
            ProductOrder = new Label();
            QuantityText = new TextBox();
            PriceText = new TextBox();
            ProductText = new TextBox();
            Id = new Label();
            AllProductsGrid = new DataGridView();
            IdProductList = new DataGridViewTextBoxColumn();
            ProductProductList = new DataGridViewTextBoxColumn();
            SalePriceColumn = new DataGridViewTextBoxColumn();
            discountCol = new DataGridViewTextBoxColumn();
            ProductListLabel = new Label();
            AddOrderLabel = new Label();
            label1 = new Label();
            Add = new Button();
            Billlabel = new Label();
            GrandTotalText = new TextBox();
            TotalText = new TextBox();
            label2 = new Label();
            CustomerDataGrid = new DataGridView();
            IDCustomer = new DataGridViewTextBoxColumn();
            NameCustomer = new DataGridViewTextBoxColumn();
            ContactCustomer = new DataGridViewTextBoxColumn();
            AddressCustomer = new DataGridViewTextBoxColumn();
            CustomerData = new Label();
            CustomerID = new Label();
            CustomerNameText = new TextBox();
            CustomerIDText = new TextBox();
            CustomerName = new Label();
            ((System.ComponentModel.ISupportInitialize)OrderDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllProductsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGrid).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.PaleVioletRed;
            Back.Location = new Point(1283, 725);
            Back.Name = "Back";
            Back.Size = new Size(112, 34);
            Back.TabIndex = 19;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // OrderDataGrid
            // 
            OrderDataGrid.AllowUserToAddRows = false;
            OrderDataGrid.AllowUserToOrderColumns = true;
            OrderDataGrid.BackgroundColor = Color.PaleVioletRed;
            OrderDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataGrid.Columns.AddRange(new DataGridViewColumn[] { Customer, IDColumn, ProductColumn, PriceCol, QtyColumn, DiscountColumn, TotalColumn });
            OrderDataGrid.GridColor = Color.MistyRose;
            OrderDataGrid.Location = new Point(621, 341);
            OrderDataGrid.Name = "OrderDataGrid";
            OrderDataGrid.RowHeadersVisible = false;
            OrderDataGrid.RowHeadersWidth = 62;
            OrderDataGrid.Size = new Size(786, 372);
            OrderDataGrid.TabIndex = 22;
            OrderDataGrid.CellContentClick += OrderDataGrid_CellContentClick;
            // 
            // Customer
            // 
            Customer.HeaderText = "C.ID";
            Customer.MinimumWidth = 8;
            Customer.Name = "Customer";
            Customer.Width = 150;
            // 
            // IDColumn
            // 
            IDColumn.HeaderText = "ID";
            IDColumn.MinimumWidth = 8;
            IDColumn.Name = "IDColumn";
            IDColumn.Width = 150;
            // 
            // ProductColumn
            // 
            ProductColumn.HeaderText = "Product";
            ProductColumn.MinimumWidth = 8;
            ProductColumn.Name = "ProductColumn";
            ProductColumn.Width = 150;
            // 
            // PriceCol
            // 
            PriceCol.HeaderText = "Price";
            PriceCol.MinimumWidth = 8;
            PriceCol.Name = "PriceCol";
            PriceCol.Width = 150;
            // 
            // QtyColumn
            // 
            QtyColumn.HeaderText = "Qty";
            QtyColumn.MinimumWidth = 8;
            QtyColumn.Name = "QtyColumn";
            QtyColumn.Width = 150;
            // 
            // DiscountColumn
            // 
            DiscountColumn.HeaderText = "Discount";
            DiscountColumn.MinimumWidth = 8;
            DiscountColumn.Name = "DiscountColumn";
            DiscountColumn.Width = 150;
            // 
            // TotalColumn
            // 
            TotalColumn.HeaderText = "Total";
            TotalColumn.MinimumWidth = 8;
            TotalColumn.Name = "TotalColumn";
            TotalColumn.Width = 150;
            // 
            // DiscountText
            // 
            DiscountText.AccessibleName = "NameTextBox";
            DiscountText.BackColor = Color.MistyRose;
            DiscountText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiscountText.ForeColor = Color.PaleVioletRed;
            DiscountText.Location = new Point(1207, 194);
            DiscountText.Name = "DiscountText";
            DiscountText.Size = new Size(135, 35);
            DiscountText.TabIndex = 29;
            // 
            // IDText
            // 
            IDText.AccessibleName = "IDTextBox";
            IDText.BackColor = Color.MistyRose;
            IDText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDText.ForeColor = Color.PaleVioletRed;
            IDText.Location = new Point(841, 147);
            IDText.Name = "IDText";
            IDText.Size = new Size(134, 35);
            IDText.TabIndex = 30;
            // 
            // QuantityOrder
            // 
            QuantityOrder.AutoSize = true;
            QuantityOrder.BackColor = Color.PaleVioletRed;
            QuantityOrder.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            QuantityOrder.ForeColor = Color.MistyRose;
            QuantityOrder.Location = new Point(699, 251);
            QuantityOrder.Name = "QuantityOrder";
            QuantityOrder.Size = new Size(127, 32);
            QuantityOrder.TabIndex = 32;
            QuantityOrder.Text = "Quantity";
            // 
            // PriceOrder
            // 
            PriceOrder.AutoSize = true;
            PriceOrder.BackColor = Color.PaleVioletRed;
            PriceOrder.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PriceOrder.ForeColor = Color.MistyRose;
            PriceOrder.Location = new Point(1054, 147);
            PriceOrder.Name = "PriceOrder";
            PriceOrder.Size = new Size(120, 32);
            PriceOrder.TabIndex = 33;
            PriceOrder.Text = " Price     ";
            PriceOrder.Click += PriceOrder_Click;
            // 
            // ProductOrder
            // 
            ProductOrder.AutoSize = true;
            ProductOrder.BackColor = Color.PaleVioletRed;
            ProductOrder.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ProductOrder.ForeColor = Color.MistyRose;
            ProductOrder.Location = new Point(699, 197);
            ProductOrder.Name = "ProductOrder";
            ProductOrder.Size = new Size(114, 32);
            ProductOrder.TabIndex = 34;
            ProductOrder.Text = "Product";
            // 
            // QuantityText
            // 
            QuantityText.AccessibleName = "NameTextBox";
            QuantityText.BackColor = Color.MistyRose;
            QuantityText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuantityText.ForeColor = Color.PaleVioletRed;
            QuantityText.Location = new Point(841, 248);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(136, 35);
            QuantityText.TabIndex = 35;
            QuantityText.KeyUp += QuantityText_KeyUp;
            // 
            // PriceText
            // 
            PriceText.AccessibleName = "NameTextBox";
            PriceText.BackColor = Color.MistyRose;
            PriceText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceText.ForeColor = Color.PaleVioletRed;
            PriceText.Location = new Point(1207, 144);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(134, 35);
            PriceText.TabIndex = 36;
            // 
            // ProductText
            // 
            ProductText.AccessibleName = "NameTextBox";
            ProductText.BackColor = Color.MistyRose;
            ProductText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductText.ForeColor = Color.PaleVioletRed;
            ProductText.Location = new Point(841, 194);
            ProductText.Name = "ProductText";
            ProductText.Size = new Size(134, 35);
            ProductText.TabIndex = 37;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.BackColor = Color.PaleVioletRed;
            Id.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Id.ForeColor = Color.MistyRose;
            Id.Location = new Point(699, 144);
            Id.Name = "Id";
            Id.Size = new Size(71, 32);
            Id.TabIndex = 25;
            Id.Text = "P.ID";
            // 
            // AllProductsGrid
            // 
            AllProductsGrid.AllowUserToAddRows = false;
            AllProductsGrid.BackgroundColor = Color.MistyRose;
            AllProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllProductsGrid.Columns.AddRange(new DataGridViewColumn[] { IdProductList, ProductProductList, SalePriceColumn, discountCol });
            AllProductsGrid.GridColor = Color.PaleVioletRed;
            AllProductsGrid.Location = new Point(3, 369);
            AllProductsGrid.MultiSelect = false;
            AllProductsGrid.Name = "AllProductsGrid";
            AllProductsGrid.RowHeadersVisible = false;
            AllProductsGrid.RowHeadersWidth = 62;
            AllProductsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllProductsGrid.Size = new Size(563, 372);
            AllProductsGrid.TabIndex = 38;
            AllProductsGrid.AllowUserToAddRowsChanged += False;
            AllProductsGrid.Click += AllProductsGrid_Click;
            AllProductsGrid.KeyDown += AllProductsGrid_KeyDown;
            AllProductsGrid.KeyUp += AllProductsGrid_KeyUp;
            // 
            // IdProductList
            // 
            IdProductList.HeaderText = "ID";
            IdProductList.MinimumWidth = 8;
            IdProductList.Name = "IdProductList";
            IdProductList.Width = 150;
            // 
            // ProductProductList
            // 
            ProductProductList.HeaderText = "Product";
            ProductProductList.MinimumWidth = 8;
            ProductProductList.Name = "ProductProductList";
            ProductProductList.Width = 150;
            // 
            // SalePriceColumn
            // 
            SalePriceColumn.HeaderText = "SalePrice";
            SalePriceColumn.MinimumWidth = 8;
            SalePriceColumn.Name = "SalePriceColumn";
            SalePriceColumn.Width = 150;
            // 
            // discountCol
            // 
            discountCol.HeaderText = "Discount";
            discountCol.MinimumWidth = 8;
            discountCol.Name = "discountCol";
            discountCol.Width = 150;
            // 
            // ProductListLabel
            // 
            ProductListLabel.AutoSize = true;
            ProductListLabel.BackColor = Color.PaleVioletRed;
            ProductListLabel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductListLabel.ForeColor = Color.MistyRose;
            ProductListLabel.Location = new Point(12, 321);
            ProductListLabel.Name = "ProductListLabel";
            ProductListLabel.Size = new Size(144, 29);
            ProductListLabel.TabIndex = 39;
            ProductListLabel.Text = "All Products";
            ProductListLabel.Click += label1_Click;
            // 
            // AddOrderLabel
            // 
            AddOrderLabel.AutoSize = true;
            AddOrderLabel.BackColor = Color.PaleVioletRed;
            AddOrderLabel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddOrderLabel.ForeColor = Color.MistyRose;
            AddOrderLabel.Location = new Point(686, 24);
            AddOrderLabel.Name = "AddOrderLabel";
            AddOrderLabel.Size = new Size(127, 29);
            AddOrderLabel.TabIndex = 40;
            AddOrderLabel.Text = "Add Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("Georgia", 14F, FontStyle.Italic);
            label1.ForeColor = Color.MistyRose;
            label1.Location = new Point(1054, 197);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 41;
            label1.Text = "Discount";
            // 
            // Add
            // 
            Add.Font = new Font("Georgia", 12F);
            Add.ForeColor = Color.PaleVioletRed;
            Add.Location = new Point(1283, 284);
            Add.Name = "Add";
            Add.Size = new Size(112, 34);
            Add.TabIndex = 42;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            // 
            // Billlabel
            // 
            Billlabel.AutoSize = true;
            Billlabel.BackColor = Color.PaleVioletRed;
            Billlabel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Billlabel.ForeColor = Color.MistyRose;
            Billlabel.Location = new Point(621, 725);
            Billlabel.Name = "Billlabel";
            Billlabel.Size = new Size(111, 29);
            Billlabel.TabIndex = 43;
            Billlabel.Text = "Total Bill";
            // 
            // GrandTotalText
            // 
            GrandTotalText.AccessibleName = "NameTextBox";
            GrandTotalText.BackColor = Color.MistyRose;
            GrandTotalText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GrandTotalText.ForeColor = Color.PaleVioletRed;
            GrandTotalText.Location = new Point(769, 719);
            GrandTotalText.Name = "GrandTotalText";
            GrandTotalText.Size = new Size(136, 35);
            GrandTotalText.TabIndex = 44;
            // 
            // TotalText
            // 
            TotalText.AccessibleName = "NameTextBox";
            TotalText.BackColor = Color.MistyRose;
            TotalText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalText.ForeColor = Color.PaleVioletRed;
            TotalText.Location = new Point(1207, 243);
            TotalText.Name = "TotalText";
            TotalText.Size = new Size(136, 35);
            TotalText.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleVioletRed;
            label2.Font = new Font("Georgia", 14F, FontStyle.Italic);
            label2.ForeColor = Color.MistyRose;
            label2.Location = new Point(1054, 248);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 46;
            label2.Text = "Total";
            // 
            // CustomerDataGrid
            // 
            CustomerDataGrid.AllowUserToAddRows = false;
            CustomerDataGrid.BackgroundColor = Color.MistyRose;
            CustomerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGrid.Columns.AddRange(new DataGridViewColumn[] { IDCustomer, NameCustomer, ContactCustomer, AddressCustomer });
            CustomerDataGrid.Location = new Point(3, 78);
            CustomerDataGrid.Name = "CustomerDataGrid";
            CustomerDataGrid.RowHeadersVisible = false;
            CustomerDataGrid.RowHeadersWidth = 62;
            CustomerDataGrid.Size = new Size(563, 225);
            CustomerDataGrid.TabIndex = 47;
            CustomerDataGrid.Click += CustomerDataGrid_Click;
            // 
            // IDCustomer
            // 
            IDCustomer.HeaderText = "ID";
            IDCustomer.MinimumWidth = 8;
            IDCustomer.Name = "IDCustomer";
            IDCustomer.Width = 150;
            // 
            // NameCustomer
            // 
            NameCustomer.HeaderText = "Name";
            NameCustomer.MinimumWidth = 8;
            NameCustomer.Name = "NameCustomer";
            NameCustomer.Width = 150;
            // 
            // ContactCustomer
            // 
            ContactCustomer.HeaderText = "Contact";
            ContactCustomer.MinimumWidth = 8;
            ContactCustomer.Name = "ContactCustomer";
            ContactCustomer.Width = 150;
            // 
            // AddressCustomer
            // 
            AddressCustomer.HeaderText = "Address";
            AddressCustomer.MinimumWidth = 8;
            AddressCustomer.Name = "AddressCustomer";
            AddressCustomer.Width = 150;
            // 
            // CustomerData
            // 
            CustomerData.AutoSize = true;
            CustomerData.BackColor = Color.PaleVioletRed;
            CustomerData.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerData.ForeColor = Color.MistyRose;
            CustomerData.Location = new Point(12, 24);
            CustomerData.Name = "CustomerData";
            CustomerData.Size = new Size(126, 29);
            CustomerData.TabIndex = 48;
            CustomerData.Text = "Customers";
            // 
            // CustomerID
            // 
            CustomerID.AutoSize = true;
            CustomerID.BackColor = Color.PaleVioletRed;
            CustomerID.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CustomerID.ForeColor = Color.MistyRose;
            CustomerID.Location = new Point(699, 94);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(72, 32);
            CustomerID.TabIndex = 49;
            CustomerID.Text = "C.ID";
            // 
            // CustomerNameText
            // 
            CustomerNameText.AccessibleName = "IDTextBox";
            CustomerNameText.BackColor = Color.MistyRose;
            CustomerNameText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerNameText.ForeColor = Color.PaleVioletRed;
            CustomerNameText.Location = new Point(1207, 91);
            CustomerNameText.Name = "CustomerNameText";
            CustomerNameText.Size = new Size(134, 35);
            CustomerNameText.TabIndex = 50;
            // 
            // CustomerIDText
            // 
            CustomerIDText.AccessibleName = "IDTextBox";
            CustomerIDText.BackColor = Color.MistyRose;
            CustomerIDText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerIDText.ForeColor = Color.PaleVioletRed;
            CustomerIDText.Location = new Point(841, 91);
            CustomerIDText.Name = "CustomerIDText";
            CustomerIDText.Size = new Size(134, 35);
            CustomerIDText.TabIndex = 51;
            // 
            // CustomerName
            // 
            CustomerName.AutoSize = true;
            CustomerName.BackColor = Color.PaleVioletRed;
            CustomerName.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CustomerName.ForeColor = Color.MistyRose;
            CustomerName.Location = new Point(1054, 91);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(89, 32);
            CustomerName.TabIndex = 52;
            CustomerName.Text = "Name";
            // 
            // OrderUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1407, 763);
            Controls.Add(CustomerName);
            Controls.Add(CustomerIDText);
            Controls.Add(CustomerNameText);
            Controls.Add(CustomerID);
            Controls.Add(CustomerData);
            Controls.Add(CustomerDataGrid);
            Controls.Add(label2);
            Controls.Add(TotalText);
            Controls.Add(GrandTotalText);
            Controls.Add(Billlabel);
            Controls.Add(Add);
            Controls.Add(label1);
            Controls.Add(AddOrderLabel);
            Controls.Add(ProductListLabel);
            Controls.Add(AllProductsGrid);
            Controls.Add(ProductText);
            Controls.Add(PriceText);
            Controls.Add(QuantityText);
            Controls.Add(ProductOrder);
            Controls.Add(PriceOrder);
            Controls.Add(QuantityOrder);
            Controls.Add(IDText);
            Controls.Add(DiscountText);
            Controls.Add(Id);
            Controls.Add(OrderDataGrid);
            Controls.Add(Back);
            Name = "OrderUI";
            Text = "OrdeUI";
            Load += OrderUI_Load;
            ((System.ComponentModel.ISupportInitialize)OrderDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllProductsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title;
        private Button Back;
        private DataGridView OrderDataGrid;
        private TextBox DiscountText;
        private TextBox IDText;
        private Label QuantityOrder;
        private Label PriceOrder;
        private Label ProductOrder;
        private TextBox QuantityText;
        private TextBox PriceText;
        private TextBox ProductText;
        private DataGridViewTextBoxColumn Col2;
        private DataGridViewTextBoxColumn col3;
        private DataGridViewTextBoxColumn col4;
        private DataGridViewTextBoxColumn col5;
        private DataGridViewTextBoxColumn col6;
        private DataGridViewTextBoxColumn Col7;
        private Label Address;
        private Label Contact;
        private Label Id;
        private Label OrderName;
        private DataGridView AllProductsGrid;
        private Label ProductListLabel;
        private Label AddOrderLabel;
        private Label label1;
        private Button Add;
        private Label Billlabel;
        private TextBox GrandTotalText;
        private TextBox TotalText;
        private Label label2;
        private DataGridViewTextBoxColumn IdProductList;
        private DataGridViewTextBoxColumn ProductProductList;
        private DataGridViewTextBoxColumn SalePriceColumn;
        private DataGridViewTextBoxColumn discountCol;
        private DataGridView CustomerDataGrid;
        private DataGridViewTextBoxColumn IDCustomer;
        private DataGridViewTextBoxColumn NameCustomer;
        private DataGridViewTextBoxColumn ContactCustomer;
        private DataGridViewTextBoxColumn AddressCustomer;
        private Label CustomerData;
        private Label CustomerID;
        private TextBox CustomerNameText;
        private TextBox CustomerIDText;
        private Label CustomerName;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn ProductColumn;
        private DataGridViewTextBoxColumn PriceCol;
        private DataGridViewTextBoxColumn QtyColumn;
        private DataGridViewTextBoxColumn DiscountColumn;
        private DataGridViewTextBoxColumn TotalColumn;
    }
}