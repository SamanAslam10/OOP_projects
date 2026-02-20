namespace Calculator
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            value1 = new TextBox();
            value2 = new TextBox();
            AddButton = new Button();
            SubtractButton = new Button();
            Result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Plum;
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(193, 98);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Plum;
            label2.ForeColor = Color.FromArgb(64, 0, 64);
            label2.Location = new Point(193, 144);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter Value";
            // 
            // value1
            // 
            value1.BackColor = Color.Purple;
            value1.ForeColor = Color.White;
            value1.Location = new Point(322, 95);
            value1.Name = "value1";
            value1.Size = new Size(150, 31);
            value1.TabIndex = 2;
            // 
            // value2
            // 
            value2.BackColor = Color.Purple;
            value2.ForeColor = Color.White;
            value2.Location = new Point(322, 138);
            value2.Name = "value2";
            value2.Size = new Size(150, 31);
            value2.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.PaleVioletRed;
            AddButton.Location = new Point(384, 243);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(88, 31);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // SubtractButton
            // 
            SubtractButton.BackColor = Color.PaleVioletRed;
            SubtractButton.Location = new Point(384, 297);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(88, 33);
            SubtractButton.TabIndex = 6;
            SubtractButton.Text = "Subtract";
            SubtractButton.UseVisualStyleBackColor = false;
            SubtractButton.Click += SubtractButton_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.BackColor = Color.Pink;
            Result.ForeColor = Color.FromArgb(64, 0, 64);
            Result.Location = new Point(373, 193);
            Result.Name = "Result";
            Result.Size = new Size(0, 25);
            Result.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Result);
            Controls.Add(SubtractButton);
            Controls.Add(AddButton);
            Controls.Add(value2);
            Controls.Add(value1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox value1;
        private TextBox value2;
        private Button AddButton;
        private Button SubtractButton;
        private Label Result;
    }
}
