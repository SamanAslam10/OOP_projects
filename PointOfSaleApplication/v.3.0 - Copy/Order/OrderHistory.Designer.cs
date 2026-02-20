namespace v._3._0.Order
{
    partial class OrderHistory
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
            OrderHistoryDataGrid = new DataGridView();
            Customer = new DataGridViewTextBoxColumn();
            IDColumn = new DataGridViewTextBoxColumn();
            ProductColumn = new DataGridViewTextBoxColumn();
            PriceCol = new DataGridViewTextBoxColumn();
            QtyColumn = new DataGridViewTextBoxColumn();
            DiscountColumn = new DataGridViewTextBoxColumn();
            TotalColumn = new DataGridViewTextBoxColumn();
            Back = new Button();
            AddOrderLabel = new Label();
            Title = new TextBox();
            ((System.ComponentModel.ISupportInitialize)OrderHistoryDataGrid).BeginInit();
            SuspendLayout();
            // 
            // OrderHistoryDataGrid
            // 
            OrderHistoryDataGrid.AllowUserToAddRows = false;
            OrderHistoryDataGrid.AllowUserToOrderColumns = true;
            OrderHistoryDataGrid.BackgroundColor = Color.PaleVioletRed;
            OrderHistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderHistoryDataGrid.Columns.AddRange(new DataGridViewColumn[] { Customer, IDColumn, ProductColumn, PriceCol, QtyColumn, DiscountColumn, TotalColumn });
            OrderHistoryDataGrid.GridColor = Color.MistyRose;
            OrderHistoryDataGrid.Location = new Point(111, 169);
            OrderHistoryDataGrid.Name = "OrderHistoryDataGrid";
            OrderHistoryDataGrid.RowHeadersVisible = false;
            OrderHistoryDataGrid.RowHeadersWidth = 62;
            OrderHistoryDataGrid.Size = new Size(1047, 480);
            OrderHistoryDataGrid.TabIndex = 23;
            OrderHistoryDataGrid.CellContentClick += OrderDataGrid_CellContentClick;
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
            // Back
            // 
            Back.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.PaleVioletRed;
            Back.Location = new Point(1073, 670);
            Back.Name = "Back";
            Back.Size = new Size(112, 34);
            Back.TabIndex = 24;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // AddOrderLabel
            // 
            AddOrderLabel.AutoSize = true;
            AddOrderLabel.BackColor = Color.PaleVioletRed;
            AddOrderLabel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddOrderLabel.ForeColor = Color.MistyRose;
            AddOrderLabel.Location = new Point(111, 670);
            AddOrderLabel.Name = "AddOrderLabel";
            AddOrderLabel.Size = new Size(127, 29);
            AddOrderLabel.TabIndex = 41;
            AddOrderLabel.Text = "Add Order";
            AddOrderLabel.Click += AddOrderLabel_Click;
            // 
            // Title
            // 
            Title.BackColor = Color.LightPink;
            Title.Font = new Font("Rage Italic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.PaleVioletRed;
            Title.Location = new Point(357, 6);
            Title.Name = "Title";
            Title.Size = new Size(515, 128);
            Title.TabIndex = 42;
            Title.Text = "Order History";
            // 
            // OrderHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1258, 735);
            Controls.Add(Title);
            Controls.Add(AddOrderLabel);
            Controls.Add(Back);
            Controls.Add(OrderHistoryDataGrid);
            Name = "OrderHistory";
            Text = "OrderHistory";
            Load += OrderHistory_Load;
            ((System.ComponentModel.ISupportInitialize)OrderHistoryDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OrderHistoryDataGrid;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn ProductColumn;
        private DataGridViewTextBoxColumn PriceCol;
        private DataGridViewTextBoxColumn QtyColumn;
        private DataGridViewTextBoxColumn DiscountColumn;
        private DataGridViewTextBoxColumn TotalColumn;
        private Button Back;
        private Label AddOrderLabel;
        private TextBox Title;
    }
}