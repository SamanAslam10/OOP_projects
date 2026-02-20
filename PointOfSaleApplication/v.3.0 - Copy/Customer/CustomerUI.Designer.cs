namespace v._3._0.Customer
{
    partial class CustomerUI
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
            CustomerName = new Label();
            Address = new Label();
            Contact = new Label();
            Age = new Label();
            ageText = new TextBox();
            ContactText = new TextBox();
            AddressText = new TextBox();
            NameText = new TextBox();
            Back = new Button();
            Delete = new Button();
            Update = new Button();
            Add = new Button();
            CustomerDataGrid = new DataGridView();
            CustomerID = new Label();
            Idtext = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGrid).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.BackColor = Color.LightPink;
            Title.Font = new Font("Rage Italic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.PaleVioletRed;
            Title.Location = new Point(384, 44);
            Title.Name = "Title";
            Title.Size = new Size(571, 128);
            Title.TabIndex = 1;
            Title.Text = "Customer Menu";
            // 
            // CustomerName
            // 
            CustomerName.AutoSize = true;
            CustomerName.BackColor = Color.PaleVioletRed;
            CustomerName.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CustomerName.ForeColor = Color.MistyRose;
            CustomerName.Location = new Point(37, 291);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(110, 32);
            CustomerName.TabIndex = 2;
            CustomerName.Text = "  Name ";
            CustomerName.Click += CustomerName_Click;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.PaleVioletRed;
            Address.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Address.ForeColor = Color.MistyRose;
            Address.Location = new Point(37, 467);
            Address.Name = "Address";
            Address.Size = new Size(115, 32);
            Address.TabIndex = 4;
            Address.Text = "Address";
            // 
            // Contact
            // 
            Contact.AutoSize = true;
            Contact.BackColor = Color.PaleVioletRed;
            Contact.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Contact.ForeColor = Color.MistyRose;
            Contact.Location = new Point(34, 404);
            Contact.Name = "Contact";
            Contact.Size = new Size(113, 32);
            Contact.TabIndex = 5;
            Contact.Text = "Contact";
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.BackColor = Color.PaleVioletRed;
            Age.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Age.ForeColor = Color.MistyRose;
            Age.Location = new Point(36, 347);
            Age.Name = "Age";
            Age.Size = new Size(111, 32);
            Age.TabIndex = 6;
            Age.Text = "  Age     ";
            // 
            // ageText
            // 
            ageText.AccessibleName = "";
            ageText.BackColor = Color.MistyRose;
            ageText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageText.ForeColor = Color.PaleVioletRed;
            ageText.Location = new Point(186, 347);
            ageText.Name = "ageText";
            ageText.Size = new Size(240, 35);
            ageText.TabIndex = 12;
            ageText.TextChanged += ageText_TextChanged;
            ageText.Enter += ageText_Enter;
            ageText.KeyUp += ageText_KeyUp;
            // 
            // ContactText
            // 
            ContactText.AccessibleName = "NameTextBox";
            ContactText.BackColor = Color.MistyRose;
            ContactText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactText.ForeColor = Color.PaleVioletRed;
            ContactText.Location = new Point(186, 401);
            ContactText.Name = "ContactText";
            ContactText.Size = new Size(240, 35);
            ContactText.TabIndex = 13;
            ContactText.TextChanged += ContactText_TextChanged;
            ContactText.Enter += ContactText_Enter;
            ContactText.KeyUp += ContactText_KeyUp;
            // 
            // AddressText
            // 
            AddressText.AccessibleName = "NameTextBox";
            AddressText.BackColor = Color.MistyRose;
            AddressText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressText.ForeColor = Color.PaleVioletRed;
            AddressText.Location = new Point(186, 464);
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(240, 35);
            AddressText.TabIndex = 14;
            AddressText.Enter += AddressText_Enter;
            AddressText.KeyUp += AddressText_KeyUp;
            // 
            // NameText
            // 
            NameText.AccessibleName = "NameTextBox";
            NameText.BackColor = Color.MistyRose;
            NameText.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameText.ForeColor = Color.PaleVioletRed;
            NameText.Location = new Point(186, 291);
            NameText.Name = "NameText";
            NameText.Size = new Size(240, 35);
            NameText.TabIndex = 15;
            NameText.TextChanged += NameText_TextChanged;
            NameText.Enter += NameText_Enter;
            NameText.KeyUp += NameText_KeyUp;
            // 
            // Back
            // 
            Back.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.PaleVioletRed;
            Back.Location = new Point(1180, 601);
            Back.Name = "Back";
            Back.Size = new Size(112, 34);
            Back.TabIndex = 17;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Delete
            // 
            Delete.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete.ForeColor = Color.PaleVioletRed;
            Delete.Location = new Point(367, 601);
            Delete.Name = "Delete";
            Delete.Size = new Size(112, 34);
            Delete.TabIndex = 18;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Update.ForeColor = Color.PaleVioletRed;
            Update.Location = new Point(213, 601);
            Update.Name = "Update";
            Update.Size = new Size(112, 34);
            Update.TabIndex = 19;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Add
            // 
            Add.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add.ForeColor = Color.PaleVioletRed;
            Add.Location = new Point(60, 601);
            Add.Name = "Add";
            Add.Size = new Size(112, 34);
            Add.TabIndex = 20;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // CustomerDataGrid
            // 
            CustomerDataGrid.AllowUserToAddRows = false;
            CustomerDataGrid.AllowUserToOrderColumns = true;
            CustomerDataGrid.BackgroundColor = Color.PaleVioletRed;
            CustomerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            CustomerDataGrid.GridColor = Color.MistyRose;
            CustomerDataGrid.Location = new Point(562, 257);
            CustomerDataGrid.MultiSelect = false;
            CustomerDataGrid.Name = "CustomerDataGrid";
            CustomerDataGrid.ReadOnly = true;
            CustomerDataGrid.RowHeadersVisible = false;
            CustomerDataGrid.RowHeadersWidth = 62;
            CustomerDataGrid.Size = new Size(752, 242);
            CustomerDataGrid.TabIndex = 21;
            // 
            // CustomerID
            // 
            CustomerID.AutoSize = true;
            CustomerID.BackColor = Color.PaleVioletRed;
            CustomerID.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CustomerID.ForeColor = Color.MistyRose;
            CustomerID.Location = new Point(36, 240);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(109, 32);
            CustomerID.TabIndex = 22;
            CustomerID.Text = "   ID      ";
            // 
            // Idtext
            // 
            Idtext.AccessibleName = "NameTextBox";
            Idtext.BackColor = Color.MistyRose;
            Idtext.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Idtext.ForeColor = Color.PaleVioletRed;
            Idtext.Location = new Point(186, 240);
            Idtext.Name = "Idtext";
            Idtext.Size = new Size(240, 35);
            Idtext.TabIndex = 23;
            Idtext.TextChanged += Idtext_TextChanged;
            Idtext.KeyUp += Idtext_KeyUp;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Age";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Contact";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Address";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // CustomerUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1367, 689);
            Controls.Add(Idtext);
            Controls.Add(CustomerID);
            Controls.Add(CustomerDataGrid);
            Controls.Add(Add);
            Controls.Add(Update);
            Controls.Add(Delete);
            Controls.Add(Back);
            Controls.Add(NameText);
            Controls.Add(AddressText);
            Controls.Add(ContactText);
            Controls.Add(ageText);
            Controls.Add(Age);
            Controls.Add(Contact);
            Controls.Add(Address);
            Controls.Add(CustomerName);
            Controls.Add(Title);
            Name = "CustomerUI";
            Text = "CustomerMenu";
            Load += CustomerUI_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title;
        private Label CustomerName;
        private Label Address;
        private Label Contact;
        private Label Age;
        private TextBox ageText;
        private TextBox ContactText;
        private TextBox AddressText;
        private TextBox NameText;
        private Button Back;
        private Button Delete;
        private Button Update;
        private Button Add;
        private DataGridView CustomerDataGrid;
        private Label CustomerID;
        private TextBox Idtext;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}