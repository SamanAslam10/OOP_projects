namespace v._3._0.Customer
{
    partial class CustomerAdvanceUI
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
            CustomerDataGrid = new DataGridView();
            SearchByAddress = new Button();
            SearchByAge = new Button();
            SearchByContact = new Button();
            SearchByFirstChar = new Button();
            SearchByName = new Button();
            textContact = new TextBox();
            textFirstChar = new TextBox();
            textAge = new TextBox();
            textAddress = new TextBox();
            TextName = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGrid).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.BackColor = Color.LightPink;
            Title.Font = new Font("Rage Italic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.PaleVioletRed;
            Title.Location = new Point(156, 48);
            Title.Name = "Title";
            Title.Size = new Size(910, 128);
            Title.TabIndex = 2;
            Title.Text = "Customer Advance Search";
            Title.TextChanged += Title_TextChanged;
            // 
            // CustomerDataGrid
            // 
            CustomerDataGrid.AllowUserToOrderColumns = true;
            CustomerDataGrid.BackgroundColor = Color.PaleVioletRed;
            CustomerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGrid.GridColor = Color.MistyRose;
            CustomerDataGrid.Location = new Point(680, 220);
            CustomerDataGrid.Name = "CustomerDataGrid";
            CustomerDataGrid.RowHeadersWidth = 62;
            CustomerDataGrid.Size = new Size(557, 378);
            CustomerDataGrid.TabIndex = 21;
            // 
            // SearchByAddress
            // 
            SearchByAddress.BackColor = Color.PaleVioletRed;
            SearchByAddress.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchByAddress.ForeColor = Color.MistyRose;
            SearchByAddress.Location = new Point(12, 551);
            SearchByAddress.Name = "SearchByAddress";
            SearchByAddress.Size = new Size(197, 70);
            SearchByAddress.TabIndex = 23;
            SearchByAddress.Text = "Search By Address";
            SearchByAddress.UseVisualStyleBackColor = false;
            SearchByAddress.Click += SearchByAddress_Click;
            // 
            // SearchByAge
            // 
            SearchByAge.BackColor = Color.PaleVioletRed;
            SearchByAge.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchByAge.ForeColor = Color.MistyRose;
            SearchByAge.Location = new Point(12, 477);
            SearchByAge.Name = "SearchByAge";
            SearchByAge.Size = new Size(197, 58);
            SearchByAge.TabIndex = 24;
            SearchByAge.Text = "Search By Age";
            SearchByAge.UseVisualStyleBackColor = false;
            SearchByAge.Click += SearchByAge_Click;
            // 
            // SearchByContact
            // 
            SearchByContact.BackColor = Color.PaleVioletRed;
            SearchByContact.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchByContact.ForeColor = Color.MistyRose;
            SearchByContact.Location = new Point(12, 385);
            SearchByContact.Name = "SearchByContact";
            SearchByContact.Size = new Size(197, 77);
            SearchByContact.TabIndex = 25;
            SearchByContact.Text = "Search By Contact";
            SearchByContact.UseVisualStyleBackColor = false;
            SearchByContact.Click += SearchByContact_Click;
            // 
            // SearchByFirstChar
            // 
            SearchByFirstChar.BackColor = Color.PaleVioletRed;
            SearchByFirstChar.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchByFirstChar.ForeColor = Color.MistyRose;
            SearchByFirstChar.Location = new Point(12, 292);
            SearchByFirstChar.Name = "SearchByFirstChar";
            SearchByFirstChar.Size = new Size(197, 76);
            SearchByFirstChar.TabIndex = 26;
            SearchByFirstChar.Text = "Search By First Character";
            SearchByFirstChar.UseVisualStyleBackColor = false;
            SearchByFirstChar.Click += button4_Click;
            // 
            // SearchByName
            // 
            SearchByName.BackColor = Color.PaleVioletRed;
            SearchByName.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchByName.ForeColor = Color.MistyRose;
            SearchByName.Location = new Point(12, 220);
            SearchByName.Name = "SearchByName";
            SearchByName.Size = new Size(197, 58);
            SearchByName.TabIndex = 27;
            SearchByName.Text = "Search By Name";
            SearchByName.UseVisualStyleBackColor = false;
            SearchByName.Click += button5_Click;
            // 
            // textContact
            // 
            textContact.AccessibleName = "NameTextBox";
            textContact.BackColor = Color.MistyRose;
            textContact.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textContact.ForeColor = Color.PaleVioletRed;
            textContact.Location = new Point(262, 406);
            textContact.Name = "textContact";
            textContact.Size = new Size(305, 35);
            textContact.TabIndex = 31;
            // 
            // textFirstChar
            // 
            textFirstChar.AccessibleName = "NameTextBox";
            textFirstChar.BackColor = Color.MistyRose;
            textFirstChar.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textFirstChar.ForeColor = Color.PaleVioletRed;
            textFirstChar.Location = new Point(262, 322);
            textFirstChar.Name = "textFirstChar";
            textFirstChar.Size = new Size(305, 35);
            textFirstChar.TabIndex = 32;
            // 
            // textAge
            // 
            textAge.AccessibleName = "NameTextBox";
            textAge.BackColor = Color.MistyRose;
            textAge.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textAge.ForeColor = Color.PaleVioletRed;
            textAge.Location = new Point(262, 489);
            textAge.Name = "textAge";
            textAge.Size = new Size(305, 35);
            textAge.TabIndex = 34;
            // 
            // textAddress
            // 
            textAddress.AccessibleName = "NameTextBox";
            textAddress.BackColor = Color.MistyRose;
            textAddress.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textAddress.ForeColor = Color.PaleVioletRed;
            textAddress.Location = new Point(262, 563);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(305, 35);
            textAddress.TabIndex = 35;
            // 
            // TextName
            // 
            TextName.AccessibleName = "NameTextBox";
            TextName.BackColor = Color.MistyRose;
            TextName.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextName.ForeColor = Color.PaleVioletRed;
            TextName.Location = new Point(262, 232);
            TextName.Name = "TextName";
            TextName.Size = new Size(305, 35);
            TextName.TabIndex = 36;
            // 
            // button6
            // 
            button6.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.PaleVioletRed;
            button6.Location = new Point(1100, 643);
            button6.Name = "button6";
            button6.Size = new Size(137, 44);
            button6.TabIndex = 37;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // CustomerAdvanceUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1284, 726);
            Controls.Add(button6);
            Controls.Add(TextName);
            Controls.Add(textAddress);
            Controls.Add(textAge);
            Controls.Add(textFirstChar);
            Controls.Add(textContact);
            Controls.Add(SearchByName);
            Controls.Add(SearchByFirstChar);
            Controls.Add(SearchByContact);
            Controls.Add(SearchByAge);
            Controls.Add(SearchByAddress);
            Controls.Add(CustomerDataGrid);
            Controls.Add(Title);
            Name = "CustomerAdvanceUI";
            Text = "CustomerAdvanceUI";
            Load += CustomerAdvanceUI_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title;
        private DataGridView CustomerDataGrid;
        private Button SearchByAddress;
        private Button SearchByAge;
        private Button SearchByContact;
        private Button SearchByFirstChar;
        private Button SearchByName;
        private TextBox textContact;
        private TextBox textFirstChar;
        private TextBox textAge;
        private TextBox textAddress;
        private TextBox TextName;
        private Button button6;
    }
}