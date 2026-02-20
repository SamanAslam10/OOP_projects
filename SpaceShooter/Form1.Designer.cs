namespace SpaceShooter
{
    partial class SpaceShooterUI
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
            components = new System.ComponentModel.Container();
            PlayerTimer = new System.Windows.Forms.Timer(components);
            BulletTimer = new System.Windows.Forms.Timer(components);
            EnemyTimer = new System.Windows.Forms.Timer(components);
            EnemyFireTimer = new System.Windows.Forms.Timer(components);
            CollisionTimer = new System.Windows.Forms.Timer(components);
            GameTimer = new System.Windows.Forms.Timer(components);
            MeteroiteTimer = new System.Windows.Forms.Timer(components);
            MeteorMoveTimer = new System.Windows.Forms.Timer(components);
            ScoreLabel = new Label();
            ScoreResult = new Label();
            SuspendLayout();
            // 
            // PlayerTimer
            // 
            PlayerTimer.Tick += PlayerTimer_Tick;
            // 
            // BulletTimer
            // 
            BulletTimer.Tick += BulletTimer_Tick;
            // 
            // EnemyTimer
            // 
            EnemyTimer.Tick += EnemyTimer_Tick;
            // 
            // EnemyFireTimer
            // 
            EnemyFireTimer.Interval = 400;
            EnemyFireTimer.Tick += EnemyFireTimer_Tick;
            // 
            // CollisionTimer
            // 
            CollisionTimer.Tick += CollisionTimer_Tick;
            // 
            // GameTimer
            // 
            GameTimer.Tick += GameTimer_Tick;
            // 
            // MeteroiteTimer
            // 
            MeteroiteTimer.Interval = 400;
            MeteroiteTimer.Tick += MeteroiteTimer_Tick;
            // 
            // MeteorMoveTimer
            // 
            MeteorMoveTimer.Tick += MeteorMoveTimer_Tick;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.BackColor = Color.Thistle;
            ScoreLabel.Font = new Font("Forte", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreLabel.Location = new Point(12, 9);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(91, 26);
            ScoreLabel.TabIndex = 4;
            ScoreLabel.Text = "Score : ";
            // 
            // ScoreResult
            // 
            ScoreResult.AutoSize = true;
            ScoreResult.BackColor = SystemColors.ActiveBorder;
            ScoreResult.Font = new Font("Sitka Banner Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreResult.Location = new Point(116, 9);
            ScoreResult.Name = "ScoreResult";
            ScoreResult.Size = new Size(0, 35);
            ScoreResult.TabIndex = 5;
            // 
            // SpaceShooterUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__5_;
            ClientSize = new Size(736, 502);
            Controls.Add(ScoreResult);
            Controls.Add(ScoreLabel);
            DoubleBuffered = true;
            Name = "SpaceShooterUI";
            Text = "SpaceShooter";
            Load += SpaceShooterUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer PlayerTimer;
        private System.Windows.Forms.Timer BulletTimer;
        private System.Windows.Forms.Timer EnemyTimer;
        private System.Windows.Forms.Timer EnemyFireTimer;
        private System.Windows.Forms.Timer CollisionTimer;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer MeteroiteTimer;
        private System.Windows.Forms.Timer MeteorMoveTimer;
        private Label ScoreLabel;
        private Label ScoreResult;
    }
}
