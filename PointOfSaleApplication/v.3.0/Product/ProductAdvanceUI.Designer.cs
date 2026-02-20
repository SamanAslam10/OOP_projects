namespace v._3._0.Product
{
    partial class ProductAdvanceUI
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
            button3 = new Button();
            SearchByName = new Button();
            ProductDataGrid = new DataGridView();
            SearchBySubString = new Button();
            SearchByPriceDifference = new Button();
            SearchWithinPrice = new Button();
            SearchByPrice = new Button();
            TextBoxPrice = new TextBox();
            textBoxPriceEnd = new TextBox();
            textBoxPriceStart = new TextBox();
            textBoxPriceDifference = new TextBox();
            textBoxSubString = new TextBox();
            textBoxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ProductDataGrid).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.BackColor = Color.LightPink;
            Title.Font = new Font("Rage Italic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.PaleVioletRed;
            Title.Location = new Point(231, 47);
            Title.Name = "Title";
            Title.Size = new Size(879, 128);
            Title.TabIndex = 1;
            Title.Text = "Product Advance Search";
            // 
            // button3
            // 
            button3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.PaleVioletRed;
            button3.Location = new Point(1134, 654);
            button3.Name = "button3";
            button3.Size = new Size(137, 44);
            button3.TabIndex = 10;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SearchByName
            // 
            SearchByName.BackColor = Color.PaleVioletRed;
            SearchByName.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchByName.ForeColor = Color.MistyRose;
            SearchByName.Location = new Point(29, 250);
            SearchByName.Name = "SearchByName";
            SearchByName.Size = new Size(197, 58);
            SearchByName.TabIndex = 12;
            SearchByName.Text = "Search By Name";
            SearchByName.UseVisualStyleBackColor = false;
            SearchByName.Click += SearchByName_Click;
            // 
            // ProductDataGrid
            // 
            ProductDataGrid.AllowUserToOrderColumns = true;
            ProductDataGrid.BackgroundColor = Color.PaleVioletRed;
            ProductDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGrid.GridColor = Color.MistyRose;
            ProductDataGrid.Location = new Point(714, 250);
            ProductDataGrid.Name = "ProductDataGrid";
            ProductDataGrid.RowHeadersWidth = 62;
            ProductDataGrid.Size = new Size(557, 378);
            ProductDataGrid.TabIndex = 20;
            // 
            // SearchBySubString
            // 
            SearchBySubString.BackColor = Color.PaleVioletRed;
            SearchBySubString.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBySubString.ForeColor = Color.MistyRose;
            SearchBySubString.Location = new Point(29, 570);
            SearchBySubString.Name = "SearchBySubString";
            SearchBySubString.Size = new Size(192, 67);
            SearchBySubString.TabIndex = 21;
            SearchBySubString.Text = "Search By Sub String";
            SearchBySubString.UseVisualStyleBackColor = false;
            SearchBySubString.Click += SearchBySubString_Click;
            // 
            // SearchByPriceDifference
            // 
            SearchByPriceDifference.BackColor = Color.PaleVioletRed;
            SearchByPriceDifference.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchByPriceDifference.ForeColor = Color.MistyRose;
            SearchByPriceDifference.Location = new Point(29, 478);
            SearchByPriceDifference.Name = "SearchByPriceDifference";
            SearchByPriceDifference.Size = new Size(192, 77);
            SearchByPriceDifference.TabIndex = 22;
            SearchByPriceDifference.Text = "Search By PriceDifference";
            SearchByPriceDifference.UseVisualStyleBackColor = false;
            SearchByPriceDifference.Click += SearchByPriceDifference_Click;
            // 
            // SearchWithinPrice
            // 
            SearchWithinPrice.BackColor = Color.PaleVioletRed;
            SearchWithinPrice.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchWithinPrice.ForeColor = Color.MistyRose;
            SearchWithinPrice.Location = new Point(29, 388);
            SearchWithinPrice.Name = "SearchWithinPrice";
            SearchWithinPrice.Size = new Size(197, 74);
            SearchWithinPrice.TabIndex = 23;
            SearchWithinPrice.Text = "Search Within Price Range";
            SearchWithinPrice.UseVisualStyleBackColor = false;
            SearchWithinPrice.Click += SearchWithinPrice_Click;
            // 
            // SearchByPrice
            // 
            SearchByPrice.BackColor = Color.PaleVioletRed;
            SearchByPrice.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchByPrice.ForeColor = Color.MistyRose;
            SearchByPrice.Location = new Point(29, 314);
            SearchByPrice.Name = "SearchByPrice";
            SearchByPrice.Size = new Size(197, 58);
            SearchByPrice.TabIndex = 24;
            SearchByPrice.Text = "Search By Price";
            SearchByPrice.UseVisualStyleBackColor = false;
            SearchByPrice.Click += SearchByPrice_Click;
            // 
            // TextBoxPrice
            // 
            TextBoxPrice.AccessibleName = "NameTextBox";
            TextBoxPrice.BackColor = Color.MistyRose;
            TextBoxPrice.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxPrice.ForeColor = Color.PaleVioletRed;
            TextBoxPrice.Location = new Point(260, 326);
            TextBoxPrice.Name = "TextBoxPrice";
            TextBoxPrice.Size = new Size(305, 35);
            TextBoxPrice.TabIndex = 25;
            // 
            // textBoxPriceEnd
            // 
            textBoxPriceEnd.AccessibleName = "NameTextBox";
            textBoxPriceEnd.BackColor = Color.MistyRose;
            textBoxPriceEnd.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPriceEnd.ForeColor = Color.PaleVioletRed;
            textBoxPriceEnd.Location = new Point(428, 408);
            textBoxPriceEnd.Name = "textBoxPriceEnd";
            textBoxPriceEnd.Size = new Size(137, 35);
            textBoxPriceEnd.TabIndex = 26;
            // 
            // textBoxPriceStart
            // 
            textBoxPriceStart.AccessibleName = "NameTextBox";
            textBoxPriceStart.BackColor = Color.MistyRose;
            textBoxPriceStart.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPriceStart.ForeColor = Color.PaleVioletRed;
            textBoxPriceStart.Location = new Point(260, 408);
            textBoxPriceStart.Name = "textBoxPriceStart";
            textBoxPriceStart.Size = new Size(127, 35);
            textBoxPriceStart.TabIndex = 27;
            // 
            // textBoxPriceDifference
            // 
            textBoxPriceDifference.AccessibleName = "NameTextBox";
            textBoxPriceDifference.BackColor = Color.MistyRose;
            textBoxPriceDifference.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPriceDifference.ForeColor = Color.PaleVioletRed;
            textBoxPriceDifference.Location = new Point(260, 499);
            textBoxPriceDifference.Name = "textBoxPriceDifference";
            textBoxPriceDifference.Size = new Size(305, 35);
            textBoxPriceDifference.TabIndex = 28;
            // 
            // textBoxSubString
            // 
            textBoxSubString.AccessibleName = "NameTextBox";
            textBoxSubString.BackColor = Color.MistyRose;
            textBoxSubString.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSubString.ForeColor = Color.PaleVioletRed;
            textBoxSubString.Location = new Point(260, 586);
            textBoxSubString.Name = "textBoxSubString";
            textBoxSubString.Size = new Size(305, 35);
            textBoxSubString.TabIndex = 29;
            // 
            // textBoxName
            // 
            textBoxName.AccessibleName = "NameTextBox";
            textBoxName.BackColor = Color.MistyRose;
            textBoxName.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.ForeColor = Color.PaleVioletRed;
            textBoxName.Location = new Point(260, 262);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(305, 35);
            textBoxName.TabIndex = 30;
            // 
            // ProductAdvanceUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1331, 731);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSubString);
            Controls.Add(textBoxPriceDifference);
            Controls.Add(textBoxPriceStart);
            Controls.Add(textBoxPriceEnd);
            Controls.Add(TextBoxPrice);
            Controls.Add(SearchByPrice);
            Controls.Add(SearchWithinPrice);
            Controls.Add(SearchByPriceDifference);
            Controls.Add(SearchBySubString);
            Controls.Add(ProductDataGrid);
            Controls.Add(SearchByName);
            Controls.Add(button3);
            Controls.Add(Title);
            Name = "ProductAdvanceUI";
            Text = "ProductAdvanceUI";
            ((System.ComponentModel.ISupportInitialize)ProductDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title;
        private Button button3;
        private Button SearchByName;
        private DataGridView ProductDataGrid;
        private Button SearchBySubString;
        private Button SearchByPriceDifference;
        private Button SearchWithinPrice;
        private Button SearchByPrice;
        private TextBox TextBoxPrice;
        private TextBox textBoxPriceEnd;
        private TextBox textBoxPriceStart;
        private TextBox textBoxPriceDifference;
        private TextBox textBoxSubString;
        private TextBox textBoxName;
    }
}