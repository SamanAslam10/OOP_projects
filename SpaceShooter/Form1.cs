using EZInput;
using System;
using System.Drawing;

namespace SpaceShooter
{
    public partial class SpaceShooterUI : Form
    {
        List<PictureBox> PlayerBulletsList = new List<PictureBox>();
        List<PictureBox> EnemyList = new List<PictureBox>();
        List<PictureBox> EnemyFires = new List<PictureBox>();
        List<PictureBox> MeteorList = new List<PictureBox>();
        private string enemyDirection = "MovingRight";
        int meteorGenerationTime = 8;
        int lastMeteorGenertaionTime = 0;
        int score = 0;
        PictureBox Player;
        ProgressBar PlayerHealth;
        int enemyFireCoolDown = 0;
        int playerFireCooldown = 0;

        Random random = new Random();
        public SpaceShooterUI()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void SpaceShooterUI_Load(object sender, EventArgs e)
        {
            CreatePlayer();
            PlayerTimer.Start();
            BulletTimer.Start();
            for(int i = 0; i < 3; i++) 
            {
                CreateEnemy(SpaceShooter.Properties.Resources.enemy);
            }
            EnemyTimer.Start();
            EnemyFireTimer.Start();
            CollisionTimer.Start();
            GameTimer.Start();
            MeteroiteTimer.Start();
            MeteorMoveTimer.Start();
            ScoreDisplay();
            PlayerHealth.BringToFront();
        }
        private void PlayerTimer_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                Player.Left = Player.Left + 25;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                Player.Left = Player.Left - 25;
            }
            PlayerHealth.Left = Player.Left;
            PlayerHealth.Top = Player.Top;
        }
        private PictureBox BulletLoad(Image fire, PictureBox source)
        {
            PictureBox bulletPB = new PictureBox();
            bulletPB.Image = fire;
            bulletPB.Width = 20;
            bulletPB.Height = 40;
            bulletPB.SizeMode = PictureBoxSizeMode.Zoom;
            bulletPB.BackColor = Color.Transparent;
            bulletPB.Left = source.Left + (source.Width / 2) - (bulletPB.Width / 2);
            if(source == Player) 
            {
                bulletPB.Top = source.Top - bulletPB.Height;
            }
            foreach (var item in EnemyList) 
            {
                if (source == item)
                {
                    bulletPB.Top = source.Bottom;
                }
            }
            return bulletPB;
        }
        private void BulletTimer_Tick(object sender, EventArgs e)
        {
            if (playerFireCooldown <= 0 && Keyboard.IsKeyPressed(Key.Space))
            {
                PictureBox B = BulletLoad(SpaceShooter.Properties.Resources.bullet, Player);
                PlayerBulletsList.Add(B);
                this.Controls.Add(B);
                playerFireCooldown = 5;
            }
            playerFireCooldown--;
            MovePlayerBullet();
            DelPlayerBullet();
        }
        private void DelPlayerBullet()
        {
            for (int i = PlayerBulletsList.Count - 1; i >= 0; i--)
            {
                if (PlayerBulletsList[i].Bottom < 0)
                {
                    this.Controls.Remove(PlayerBulletsList[i]);
                    PlayerBulletsList.Remove(PlayerBulletsList[i]);
                }
            }
        }
        private void MovePlayerBullet()
        {
            foreach (var bullet in PlayerBulletsList)
            {
                bullet.Top -= 20;
            }
        }
        private PictureBox CreateEnemy(Image enemy)
        {

            PictureBox enemyPB = new PictureBox();
            enemyPB.Image = enemy;
            enemyPB.BackColor = Color.Transparent;
            int left = random.Next(0, this.ClientSize.Width - enemyPB.Width);
            enemyPB.Left = left;
            enemyPB.Top = 0;
            enemyPB.Location = new System.Drawing.Point(left, enemyPB.Top);
            enemyPB.Width = 60;
            enemyPB.Height = 60;
            enemyPB.SizeMode = PictureBoxSizeMode.Zoom;

            this.Controls.Add(enemyPB);
            EnemyList.Add(enemyPB);

            return enemyPB;
        }
        private void MoveEnemy(PictureBox enemy)
        {
            if (enemyDirection == "MovingRight")
            {
                enemy.Left += 10;
            }
            if (enemyDirection == "MovingLeft")
            {
                enemy.Left -= 10;
            }
            if ((enemy.Left + enemy.Width) > this.Width)
            {
                enemyDirection = "MovingLeft";
            }
            if (enemy.Left <= 2)
            {
                enemyDirection = "MovingRight";
            }
        }
        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            foreach (var enemy in EnemyList) 
            {
                MoveEnemy(enemy);
            }
        }
        private void EnemyFire()
        {
            foreach (var enemy in EnemyList) 
            {
                PictureBox B = BulletLoad(SpaceShooter.Properties.Resources.bullet, enemy);
                EnemyFires.Add(B);
                this.Controls.Add(B);
            }
        }
        private void MoveEnemyBullet(List<PictureBox> List)
        {
            foreach (PictureBox pb in List)
            {
                pb.Top += 20;
            }
        }
        private void DelEnemyTool(List<PictureBox> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i].Bottom > this.Height)
                {
                    list.Remove(list[i]);
                }
            }
        }
        private void EnemyFireTimer_Tick(object sender, EventArgs e)
        {
            if (enemyFireCoolDown <= 0)
            {
                EnemyFire();
                enemyFireCoolDown = 10; 
            }
            enemyFireCoolDown--;
            MoveEnemyBullet(EnemyFires);
            DelEnemyTool(EnemyFires);
        }
        private void CollisionPlayer(List<PictureBox>list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                PictureBox item = list[i];
                if (item.Bounds.IntersectsWith(Player.Bounds))
                {
                    if (PlayerHealth.Value > 0)
                    {
                        PlayerHealth.Value -= 20;
                    }

                    list.RemoveAt(i); 
                    this.Controls.Remove(item);
                }
            }
        }
        private void CollisionEnemy()
        {
            for (int i = EnemyList.Count - 1; i >= 0; i--) 
            {
                for (int j = PlayerBulletsList.Count - 1; j >= 0; j--)
                {
                    if (PlayerBulletsList[j].Bounds.IntersectsWith(EnemyList[i].Bounds))
                    {
                        this.Controls.Remove(EnemyList[i]);
                        EnemyList.RemoveAt(i);
                        this.Controls.Remove(PlayerBulletsList[j]);
                        PlayerBulletsList.RemoveAt(j);

                        score += 5;
                        ScoreDisplay();

                        break; 
                    }
                }
            }
        }
        private void CollisionTimer_Tick(object sender, EventArgs e)
        {
            CollisionPlayer(EnemyFires);
            CollisionPlayer(MeteorList);
            CollisionEnemy();
            CollisionMeteor();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (EnemyList.Count == 0 || PlayerHealth.Value <= 0)
            {
                GameTimer.Enabled = false;
                GameEnd();
            }
        }
        private void MeteroiteGeneration()
        {
            lastMeteorGenertaionTime++;
            if (lastMeteorGenertaionTime >= meteorGenerationTime)
            {
                Image img = SpaceShooter.Properties.Resources.meteorite;
                PictureBox meteorPB = CreateMeteorite(img);
                MeteorList.Add(meteorPB);
                this.Controls.Add(meteorPB);
                lastMeteorGenertaionTime = 0;
            }
        }
        private PictureBox CreateMeteorite(Image meteor)
        {
            PictureBox meteorPB = new PictureBox();
            meteorPB.Image = meteor;
            meteorPB.BackColor = Color.Transparent;
            meteorPB.SizeMode = PictureBoxSizeMode.Zoom;
            meteorPB.Width = 50;
            meteorPB.Height = 50;
            int left = random.Next(0, this.Width - meteorPB.Width);
            int top = -meteorPB.Height;
            meteorPB.Left = left;
            meteorPB.Top = top;
            meteorPB.Location = new System.Drawing.Point(left, top);

            return meteorPB;
        }
        private void MeteroiteTimer_Tick(object sender, EventArgs e)
        {
            MeteroiteGeneration();
        }
        private void MoveMeteor(PictureBox meteor)
        {
            meteor.Top += 20;
        }
        private void MeteorMoveTimer_Tick(object sender, EventArgs e)
        {
            foreach(PictureBox meteor in MeteorList) 
            {
                MoveMeteor(meteor);
            }
            DelEnemyTool(MeteorList);
        }
        private void CollisionMeteor() 
        {
           for (int i = MeteorList.Count - 1; i >= 0; i--) 
           {
                for (int j = PlayerBulletsList.Count - 1; j >= 0; j--)
                {
                    if (MeteorList[i].Bounds.IntersectsWith(PlayerBulletsList[j].Bounds))
                    {
                        score += 5;
                        ScoreDisplay();
                        this.Controls.Remove(MeteorList[i]);
                        MeteorList.RemoveAt(i);
                        this.Controls.Remove(PlayerBulletsList[j]);
                        PlayerBulletsList.RemoveAt(j);
                        break;
                    }
                }
           }
        }
        private void ScoreDisplay() 
        {
            ScoreResult.Text = score.ToString();
        }
        private void GameEnd() 
        {
            GameOver gameOver = new GameOver();
            gameOver.Show();
            gameOver.Passscore(score);
        }
        public void Restart() 
        {
            score = 0;
            this.Controls.Clear();
            CreatePlayer();
            PlayerBulletsList.Clear();
            EnemyList.Clear();
            MeteorList.Clear();
            EnemyFires.Clear();
            random = new Random();
            enemyDirection = "MovingRight";
            meteorGenerationTime = 5;
            lastMeteorGenertaionTime = 0;
            GameTimer.Enabled = true;
            PlayerTimer.Start();
            BulletTimer.Start();
            for (int i = 0; i < 3; i++)
            {
                CreateEnemy(SpaceShooter.Properties.Resources.enemy);
            }
            EnemyTimer.Start();
            EnemyFireTimer.Start();
            CollisionTimer.Start();
            GameTimer.Start();
            MeteroiteTimer.Start();
            MeteorMoveTimer.Start();
            ScoreDisplay();
        }
        private void CreatePlayer() 
        {
            Player = new PictureBox();
            Image img = SpaceShooter.Properties.Resources.spaceshooterplaner2;

            Player.Image = img;
            Player.BackColor = Color.Transparent;
            Player.Height = 80;
            Player.Width = 102;
            Player.SizeMode = PictureBoxSizeMode.Zoom;
            Player.Location = new System.Drawing.Point(308, 413);

            PlayerHealth = new ProgressBar();
            PlayerHealth.Value = 100;
            PlayerHealth.Step = 10;
            PlayerHealth.Height = 10;
            PlayerHealth.Location = new System.Drawing.Point(Player.Left, Player.Top);

            this.Controls.Add(Player);
            this.Controls.Add(PlayerHealth);
        }
    }
}   