namespace v._3._0.Product
{
    partial class ProductUI
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
            Title = new TextBox();
            ProductName = new Label();
            PurchasePrice = new Label();
            SalePrice = new Label();
            Discount = new Label();
            AddProduct = new Button();
            nameTextBox = new TextBox();
            SalePriceTextBox = new TextBox();
            PurchasePriceTextBox = new TextBox();
            DiscountTextBox = new TextBox();
            BackToMain = new Button();
            DeleteProduct = new Button();
            UpdateProduct = new Button();
            ProductDataGrid = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ProductID = new Label();
            IDtext = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ProductDataGrid).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.BackColor = Color.LightPink;
            Title.Font = new Font("Rage Italic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.PaleVioletRed;
            Title.Location = new Point(413, 32);
            Title.Name = "Title";
            Title.Size = new Size(542, 128);
            Title.TabIndex = 0;
            Title.Text = "Product Menu";
            Title.TextChanged += Title_TextChanged;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.BackColor = Color.PaleVioletRed;
            ProductName.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ProductName.ForeColor = Color.MistyRose;
            ProductName.Location = new Point(19, 329);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(196, 32);
            ProductName.TabIndex = 1;
            ProductName.Text = "Product Name";
            // 
            // PurchasePrice
            // 
            PurchasePrice.AutoSize = true;
            PurchasePrice.BackColor = Color.PaleVioletRed;
            PurchasePrice.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PurchasePrice.ForeColor = Color.MistyRose;
            PurchasePrice.Location = new Point(19, 390);
            PurchasePrice.Name = "PurchasePrice";
            PurchasePrice.Size = new Size(202, 32);
            PurchasePrice.TabIndex = 2;
            PurchasePrice.Text = "Purchase Price";
            // 
            // SalePrice
            // 
            SalePrice.AutoSize = true;
            SalePrice.BackColor = Color.PaleVioletRed;
            SalePrice.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SalePrice.ForeColor = Color.MistyRose;
            SalePrice.Location = new Point(25, 453);
            SalePrice.Name = "SalePrice";
            SalePrice.Size = new Size(187, 32);
            SalePrice.TabIndex = 3;
            SalePrice.Text = "   Sale Price    ";
            // 
            // Discount
            // 
            Discount.AutoSize = true;
            Discount.BackColor = Color.PaleVioletRed;
            Discount.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Discount.ForeColor = Color.MistyRose;
            Discount.Location = new Point(25, 510);
            Discount.Name = "Discount";
            Discount.Size = new Size(189, 32);
            Discount.TabIndex = 4;
            Discount.Text = "    Discount     ";
            // 
            // AddProduct
            // 
            AddProduct.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddProduct.Location = new Point(100, 638);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(112, 34);
            AddProduct.TabIndex = 6;
            AddProduct.Text = "Add";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.AccessibleName = "NameTextBox";
            nameTextBox.BackColor = Color.MistyRose;
            nameTextBox.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.ForeColor = Color.PaleVioletRed;
            nameTextBox.Location = new Point(254, 326);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(240, 35);
            nameTextBox.TabIndex = 11;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            nameTextBox.KeyUp += nameTextBox_KeyUp;
            // 
            // SalePriceTextBox
            // 
            SalePriceTextBox.AccessibleName = "SalePriceTextBox";
            SalePriceTextBox.BackColor = Color.MistyRose;
            SalePriceTextBox.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalePriceTextBox.ForeColor = Color.PaleVioletRed;
            SalePriceTextBox.Location = new Point(254, 450);
            SalePriceTextBox.Name = "SalePriceTextBox";
            SalePriceTextBox.Size = new Size(240, 35);
            SalePriceTextBox.TabIndex = 12;
            SalePriceTextBox.TextChanged += SalePriceTextBox_TextChanged;
            SalePriceTextBox.KeyUp += SalePriceTextBox_KeyUp;
            // 
            // PurchasePriceTextBox
            // 
            PurchasePriceTextBox.AccessibleName = "PurchasePriceTextBox";
            PurchasePriceTextBox.BackColor = Color.MistyRose;
            PurchasePriceTextBox.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PurchasePriceTextBox.ForeColor = Color.PaleVioletRed;
            PurchasePriceTextBox.Location = new Point(254, 387);
            PurchasePriceTextBox.Name = "PurchasePriceTextBox";
            PurchasePriceTextBox.Size = new Size(240, 35);
            PurchasePriceTextBox.TabIndex = 13;
            PurchasePriceTextBox.TextChanged += PurchasePriceTextBox_TextChanged;
            PurchasePriceTextBox.KeyUp += PurchasePriceTextBox_KeyUp;
            // 
            // DiscountTextBox
            // 
            DiscountTextBox.AccessibleName = "DiscountTextBox";
            DiscountTextBox.BackColor = Color.MistyRose;
            DiscountTextBox.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiscountTextBox.ForeColor = Color.PaleVioletRed;
            DiscountTextBox.Location = new Point(254, 510);
            DiscountTextBox.Name = "DiscountTextBox";
            DiscountTextBox.Size = new Size(240, 35);
            DiscountTextBox.TabIndex = 14;
            DiscountTextBox.TextChanged += DiscountTextBox_TextChanged;
            DiscountTextBox.KeyUp += DiscountTextBox_KeyUp;
            // 
            // BackToMain
            // 
            BackToMain.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackToMain.Location = new Point(1148, 638);
            BackToMain.Name = "BackToMain";
            BackToMain.Size = new Size(112, 34);
            BackToMain.TabIndex = 15;
            BackToMain.Text = "Back";
            BackToMain.UseVisualStyleBackColor = true;
            BackToMain.Click += BackToMain_Click;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteProduct.Location = new Point(413, 638);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(112, 34);
            DeleteProduct.TabIndex = 17;
            DeleteProduct.Text = "Delete";
            DeleteProduct.UseVisualStyleBackColor = true;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // UpdateProduct
            // 
            UpdateProduct.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateProduct.Location = new Point(254, 638);
            UpdateProduct.Name = "UpdateProduct";
            UpdateProduct.Size = new Size(112, 34);
            UpdateProduct.TabIndex = 18;
            UpdateProduct.Text = "Update";
            UpdateProduct.UseVisualStyleBackColor = true;
            UpdateProduct.Click += UpdateProduct_Click;
            // 
            // ProductDataGrid
            // 
            ProductDataGrid.AllowUserToAddRows = false;
            ProductDataGrid.AllowUserToOrderColumns = true;
            ProductDataGrid.BackgroundColor = Color.PaleVioletRed;
            ProductDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4 });
            ProductDataGrid.GridColor = Color.MistyRose;
            ProductDataGrid.Location = new Point(599, 252);
            ProductDataGrid.MultiSelect = false;
            ProductDataGrid.Name = "ProductDataGrid";
            ProductDataGrid.ReadOnly = true;
            ProductDataGrid.RowHeadersVisible = false;
            ProductDataGrid.RowHeadersWidth = 62;
            ProductDataGrid.Size = new Size(716, 293);
            ProductDataGrid.TabIndex = 19;
            ProductDataGrid.CellContentClick += ProductDataGrid_CellContentClick;
            // 
            // Column5
            // 
            Column5.HeaderText = "ID";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "PurchasePrice";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "SalePrice";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Discount";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // ProductID
            // 
            ProductID.AutoSize = true;
            ProductID.BackColor = Color.PaleVioletRed;
            ProductID.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ProductID.ForeColor = Color.MistyRose;
            ProductID.Location = new Point(25, 273);
            ProductID.Name = "ProductID";
            ProductID.Size = new Size(153, 32);
            ProductID.TabIndex = 20;
            ProductID.Text = "Product ID";
            // 
            // IDtext
            // 
            IDtext.AccessibleName = "NameTextBox";
            IDtext.BackColor = Color.MistyRose;
            IDtext.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDtext.ForeColor = Color.PaleVioletRed;
            IDtext.Location = new Point(254, 270);
            IDtext.Name = "IDtext";
            IDtext.Size = new Size(240, 35);
            IDtext.TabIndex = 21;
            IDtext.TextChanged += IDtext_TextChanged;
            IDtext.KeyUp += IDtext_KeyUp;
            // 
            // ProductUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1360, 738);
            Controls.Add(IDtext);
            Controls.Add(ProductID);
            Controls.Add(ProductDataGrid);
            Controls.Add(UpdateProduct);
            Controls.Add(DeleteProduct);
            Controls.Add(BackToMain);
            Controls.Add(DiscountTextBox);
            Controls.Add(PurchasePriceTextBox);
            Controls.Add(SalePriceTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(AddProduct);
            Controls.Add(Discount);
            Controls.Add(SalePrice);
            Controls.Add(PurchasePrice);
            Controls.Add(ProductName);
            Controls.Add(Title);
            ForeColor = Color.PaleVioletRed;
            Name = "ProductUI";
            Load += ProductMenu_Load;
            ((System.ComponentModel.ISupportInitialize)ProductDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title;
        private new Label ProductName;
        private Label PurchasePrice;
        private Label SalePrice;
        private Label Discount;
        private Button AddProduct;
        private TextBox nameTextBox;
        private TextBox SalePriceTextBox;
        private TextBox PurchasePriceTextBox;
        private TextBox DiscountTextBox;
        private Button BackToMain;
        private Button DeleteProduct;
        private Button UpdateProduct;
        private DataGridView ProductDataGrid;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label ProductID;
        private TextBox IDtext;
    }
}