namespace v._3._0
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainTitle = new RichTextBox();
            MainMenuTitle = new Label();
            Product = new Button();
            Customer = new Button();
            Order = new Button();
            Exit = new Button();
            AdvanceMenu = new Label();
            AdvanceProduct = new Button();
            AdvanceCustomer = new Button();
            Mainpanel = new Panel();
            OrderHistory = new Button();
            Mainpanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainTitle
            // 
            MainTitle.BackColor = Color.Pink;
            MainTitle.Font = new Font("Rage Italic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainTitle.ForeColor = Color.PaleVioletRed;
            MainTitle.Location = new Point(409, 39);
            MainTitle.Name = "MainTitle";
            MainTitle.Size = new Size(533, 132);
            MainTitle.TabIndex = 1;
            MainTitle.Text = "Point Of Sale ";
            MainTitle.TextChanged += MainTitle_TextChanged;
            // 
            // MainMenuTitle
            // 
            MainMenuTitle.AutoSize = true;
            MainMenuTitle.Font = new Font("Rage Italic", 32F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuTitle.ForeColor = Color.PaleVioletRed;
            MainMenuTitle.Location = new Point(107, 194);
            MainMenuTitle.Name = "MainMenuTitle";
            MainMenuTitle.Size = new Size(332, 80);
            MainMenuTitle.TabIndex = 2;
            MainMenuTitle.Text = "Main Menu";
            MainMenuTitle.Click += MainMenuTitle_Click;
            // 
            // Product
            // 
            Product.BackColor = Color.PaleVioletRed;
            Product.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Product.ForeColor = Color.MistyRose;
            Product.Location = new Point(162, 292);
            Product.Name = "Product";
            Product.Size = new Size(199, 68);
            Product.TabIndex = 3;
            Product.Text = "Product";
            Product.UseVisualStyleBackColor = false;
            Product.Click += Product_Click;
            // 
            // Customer
            // 
            Customer.BackColor = Color.PaleVioletRed;
            Customer.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer.ForeColor = Color.MistyRose;
            Customer.Location = new Point(162, 390);
            Customer.Name = "Customer";
            Customer.Size = new Size(199, 71);
            Customer.TabIndex = 5;
            Customer.Text = "Customer";
            Customer.UseVisualStyleBackColor = false;
            Customer.Click += Customer_Click;
            // 
            // Order
            // 
            Order.BackColor = Color.PaleVioletRed;
            Order.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Order.ForeColor = Color.MistyRose;
            Order.Location = new Point(162, 488);
            Order.Name = "Order";
            Order.Size = new Size(199, 70);
            Order.TabIndex = 6;
            Order.Text = "Order";
            Order.UseVisualStyleBackColor = false;
            Order.Click += Order_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.PaleVioletRed;
            Exit.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.MistyRose;
            Exit.Location = new Point(585, 627);
            Exit.Name = "Exit";
            Exit.Size = new Size(199, 63);
            Exit.TabIndex = 7;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // AdvanceMenu
            // 
            AdvanceMenu.AutoSize = true;
            AdvanceMenu.Font = new Font("Rage Italic", 32F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdvanceMenu.ForeColor = Color.PaleVioletRed;
            AdvanceMenu.Location = new Point(873, 194);
            AdvanceMenu.Name = "AdvanceMenu";
            AdvanceMenu.Size = new Size(387, 80);
            AdvanceMenu.TabIndex = 8;
            AdvanceMenu.Text = "Advance Menu";
            // 
            // AdvanceProduct
            // 
            AdvanceProduct.BackColor = Color.PaleVioletRed;
            AdvanceProduct.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdvanceProduct.ForeColor = Color.MistyRose;
            AdvanceProduct.Location = new Point(953, 292);
            AdvanceProduct.Name = "AdvanceProduct";
            AdvanceProduct.Size = new Size(195, 68);
            AdvanceProduct.TabIndex = 9;
            AdvanceProduct.Text = "Product";
            AdvanceProduct.UseVisualStyleBackColor = false;
            AdvanceProduct.Click += AdvanceProduct_Click;
            // 
            // AdvanceCustomer
            // 
            AdvanceCustomer.BackColor = Color.PaleVioletRed;
            AdvanceCustomer.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdvanceCustomer.ForeColor = Color.MistyRose;
            AdvanceCustomer.Location = new Point(953, 392);
            AdvanceCustomer.Name = "AdvanceCustomer";
            AdvanceCustomer.Size = new Size(195, 69);
            AdvanceCustomer.TabIndex = 10;
            AdvanceCustomer.Text = "Customer";
            AdvanceCustomer.UseVisualStyleBackColor = false;
            AdvanceCustomer.Click += AdvanceCustomer_Click;
            // 
            // Mainpanel
            // 
            Mainpanel.Controls.Add(OrderHistory);
            Mainpanel.Controls.Add(MainTitle);
            Mainpanel.Controls.Add(Order);
            Mainpanel.Controls.Add(Exit);
            Mainpanel.Controls.Add(AdvanceCustomer);
            Mainpanel.Controls.Add(AdvanceMenu);
            Mainpanel.Controls.Add(AdvanceProduct);
            Mainpanel.Controls.Add(MainMenuTitle);
            Mainpanel.Controls.Add(Product);
            Mainpanel.Controls.Add(Customer);
            Mainpanel.Location = new Point(12, 12);
            Mainpanel.Name = "Mainpanel";
            Mainpanel.Size = new Size(1344, 744);
            Mainpanel.TabIndex = 11;
            Mainpanel.Paint += Mainpanel_Paint;
            // 
            // OrderHistory
            // 
            OrderHistory.BackColor = Color.PaleVioletRed;
            OrderHistory.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderHistory.ForeColor = Color.MistyRose;
            OrderHistory.Location = new Point(953, 488);
            OrderHistory.Name = "OrderHistory";
            OrderHistory.Size = new Size(199, 70);
            OrderHistory.TabIndex = 11;
            OrderHistory.Text = "Order History";
            OrderHistory.UseVisualStyleBackColor = false;
            OrderHistory.Click += OrderHistory_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1384, 779);
            Controls.Add(Mainpanel);
            Name = "MainMenu";
            Text = "Form1";
            Load += MainMenu_Load;
            Mainpanel.ResumeLayout(false);
            Mainpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox MainTitle;
        private Label MainMenuTitle;
        private Button Product;
        private Button Customer;
        private Button Order;
        private Button Exit;
        private Label AdvanceMenu;
        private Button AdvanceProduct;
        private Button AdvanceCustomer;
        private Panel Mainpanel;
        private Button OrderHistory;
    }
}
