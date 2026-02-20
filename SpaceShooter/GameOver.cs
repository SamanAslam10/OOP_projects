using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    public partial class GameOver : Form
    {
        SpaceShooterUI ui = new SpaceShooterUI();
        public GameOver()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nobutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Passscore(int score) 
        {
            ScoreDisplay(score);
        }
        public void ScoreDisplay(int score)
        {
            ScoreText.Text = score.ToString();
        }
        private void ScoreText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GameOver_Load(object sender, EventArgs e)
        {

        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ui.Show();
            ui.Restart();
        }
    }
}
