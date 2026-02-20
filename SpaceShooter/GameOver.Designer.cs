namespace SpaceShooter
{
    partial class GameOver
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
            YesButton = new Button();
            Nobutton = new Button();
            ScoreText = new TextBox();
            SuspendLayout();
            // 
            // YesButton
            // 
            YesButton.BackColor = Color.FromArgb(128, 128, 255);
            YesButton.Font = new Font("Snap ITC", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            YesButton.ForeColor = Color.Violet;
            YesButton.Location = new Point(246, 402);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(108, 48);
            YesButton.TabIndex = 0;
            YesButton.Text = "Yes";
            YesButton.UseVisualStyleBackColor = false;
            YesButton.Click += YesButton_Click;
            // 
            // Nobutton
            // 
            Nobutton.BackColor = Color.FromArgb(128, 128, 255);
            Nobutton.Font = new Font("Snap ITC", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Nobutton.ForeColor = Color.Violet;
            Nobutton.Location = new Point(395, 402);
            Nobutton.Name = "Nobutton";
            Nobutton.Size = new Size(108, 48);
            Nobutton.TabIndex = 4;
            Nobutton.Text = "NO";
            Nobutton.UseVisualStyleBackColor = false;
            Nobutton.Click += this.Nobutton_Click;
            // 
            // ScoreText
            // 
            ScoreText.BackColor = SystemColors.GradientInactiveCaption;
            ScoreText.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreText.ForeColor = Color.Purple;
            ScoreText.Location = new Point(300, 43);
            ScoreText.Name = "ScoreText";
            ScoreText.Size = new Size(132, 42);
            ScoreText.TabIndex = 5;
            ScoreText.TextChanged += ScoreText_TextChanged;
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pixel_art_Game_Over_screen__Play_again_question_with_yes_no_options__8_bit_gaming_death_pop_up_Illustration;
            ClientSize = new Size(745, 510);
            Controls.Add(ScoreText);
            Controls.Add(Nobutton);
            Controls.Add(YesButton);
            Name = "GameOver";
            Text = "GameOver";
            Load += GameOver_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button YesButton;
        private Button Nobutton;
        private TextBox ScoreText;
    }
}