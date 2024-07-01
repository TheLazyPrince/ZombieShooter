using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace game
{
    public partial class Form1 : Form 
    {

        bool GoLeft, GoRight, GoUp, GoDown, GameOver , player_god_mod = false , boss = false ,reset = false,
            bossLevel = false;
        string facing = "up";
        int PlayerHealth = 100;
        int speed = 10;
        int nextLevelScore = 15;
        int ammo = 10;
        int score = ReadScoreFromFile();
        int ZombieSpeed = 3;
        int zombies_num = 3;
        Random randNum = new Random();

        List<PictureBox> ZombiesList = new List<PictureBox>();

        List<Enemy> enemyList = new List<Enemy>();



        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }
        static int ReadScoreFromFile()
        {
            int score = 0;

            if (File.Exists("data"))
            {
                using (BinaryReader reader = new BinaryReader(File.Open("data", FileMode.Open)))
                {
                    score = reader.ReadInt32();
                }
            }

            return score;
        }

        static void WriteNameAndAgeToFile(int score)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("data", FileMode.Create)))
            {
                writer.Write(score);
            }
        }

        private void hart_1_Click(object sender, EventArgs e)
        {

        }

        private void mainTimerEvent(object sender, EventArgs e)
        {
            if (score >= nextLevelScore && !boss)
            {
                boss = true;
                bossLevel = true;
                MakeBoss();
            }
            
            if (player_god_mod == false)
            {
                god_mod.Text = "god mod off (pres G)";
            }
            if (player_god_mod == true)
            {
                god_mod.Text = "god mod on (pres N)";
            }

            if (PlayerHealth > 1)
            {
                HealthBar.Value = PlayerHealth;
            }
            else
            {
                GameOver = true;
                if(reset == false)
                    WriteNameAndAgeToFile(score);
                if (reset == true)
                {
                    reset = false;
                    WriteNameAndAgeToFile(0);
                }
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
            }


            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score;

            // for the player not go out from the window
            if(GoLeft == true && player.Left > 0)
            {
                player.Left -=speed;
            }
            if(GoRight == true && player.Right + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if(GoUp == true && player.Top > 62)
            {
                player.Top -= speed;
            }
            if(GoDown == true && player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }
            
            foreach(Control x in this.Controls)
            {
                if (!(x is PictureBox box)) { continue; } //only want pictureBoxes

                ref PictureBox ammoBox = ref box;
                ref PictureBox zombieBox = ref box;

                if (box.Tag is "ammo")
                {
                    if (player.Bounds.IntersectsWith(ammoBox.Bounds))
                    {
                        this.Controls.Remove(ammoBox);
                        ammoBox.Dispose();
                        ammo += 5;
                    }
                }

                if (box.Tag is "zombie")
                {
                    if (player.Bounds.IntersectsWith(zombieBox.Bounds) && player_god_mod == false)
                    {
                        PlayerHealth -= 1;
                    }

                    if (zombieBox.Left > player.Left)
                    {
                        zombieBox.Left -= ZombieSpeed;
                        if (boss)
                            zombieBox.Image = Properties.Resources.BossLeft;
                        else
                            zombieBox.Image = Properties.Resources.zleft;
                    }
                    if (zombieBox.Left < player.Left)
                    {
                        zombieBox.Left += ZombieSpeed;
                        if (boss)
                            zombieBox.Image = Properties.Resources.BossRight;
                        else
                            zombieBox.Image = Properties.Resources.zright;
                    }
                    if (zombieBox.Top > player.Top)
                    {
                        zombieBox.Top -= ZombieSpeed;
                        if (boss)
                            zombieBox.Image = Properties.Resources.BossUp;
                        else
                            zombieBox.Image = Properties.Resources.zup;
                    }
                    if (zombieBox.Top < player.Top)
                    {
                        zombieBox.Top += ZombieSpeed;
                        if (boss)
                            zombieBox.Image = Properties.Resources.BossDown;
                        else
                            zombieBox.Image = Properties.Resources.zdown;
                    }
                }
                
                foreach(Control j in this.Controls)
                {
                    if (!(j is PictureBox bulletBox)) { continue; }

                    if (bulletBox.Tag is "bullet" && box.Tag is "zombie")
                    {
                        if (zombieBox.Bounds.IntersectsWith(bulletBox.Bounds))
                        {
                            score++;
                            this.Controls.Remove(bulletBox);
                            bulletBox.Dispose();

                            this.Controls.Remove(zombieBox);
                            zombieBox.Dispose();
                            ZombiesList.Remove(zombieBox);
                            if (!boss)
                                MakeZombies();
                        }
                    }
                }
            }
        }

        private void KeysDown(object sender, KeyEventArgs e)
        {
            if (GameOver == true)
            {
                return;

            }
            if (e.KeyCode == Keys.G)
            {
                   player_god_mod = true;
                ammo += 15;
            }
            if (e.KeyCode == Keys.R) // game reset: press R
            {
                reset = true;
                
            }
            if (e.KeyCode == Keys.N)
            {
                player_god_mod = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                GoLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }
            if(e.KeyCode == Keys.Right)
            {
                GoRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }
            if(e.KeyCode == Keys.Up)
            {
                GoUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }
            if(e.KeyCode == Keys.Down)
            {
                GoDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }

        }

        private void KeysUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GoLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                GoUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = false;
            }
            if(e.KeyCode == Keys.Space && ammo > 0 && GameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if(ammo < 1)
                {
                    DropAmmo();
                }
            }

            if(e.KeyCode == Keys.Enter && GameOver == true)
            {
                RestartGame();
            }

        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);

        }


        private void MakeBoss()
        {
            Enemy enemy = new Boss();
            enemy.EnemyBox.Tag = "zombie";
            enemy.EnemyBox.Tag = "zombie";
            enemy.EnemyBox.Image = Properties.Resources.BossDown;
            enemy.EnemyBox.Left = randNum.Next(10, this.ClientSize.Width - enemy.EnemyBox.Width);
            enemy.EnemyBox.Top = randNum.Next(10, this.ClientSize.Height - enemy.EnemyBox.Height);
            enemyList.Add(enemy);

            ZombiesList.Add(enemy.EnemyBox);
            this.Controls.Add(enemy.EnemyBox);
            player.BringToFront();
        }

        private void MakeZombies()
        {
            Enemy enemy = new Regular();
            enemy.EnemyBox.Tag = "zombie";
            enemy.EnemyBox.Tag = "zombie";
            enemy.EnemyBox.Image = Properties.Resources.zdown;
            enemy.EnemyBox.Left = randNum.Next(10, this.ClientSize.Width - enemy.EnemyBox.Width);
            enemy.EnemyBox.Top = randNum.Next(10, this.ClientSize.Height - enemy.EnemyBox.Height);
            enemyList.Add(enemy);

            ZombiesList.Add(enemy.EnemyBox);
            this.Controls.Add(enemy.EnemyBox);
            player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(10, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();



        }


        private void RestartGame()
        {
            player.Image = Properties.Resources.up;
            foreach(PictureBox i in ZombiesList)
            {
                this.Controls.Remove(i);
            }

            ZombiesList.Clear();

            for(int i = 0; i<zombies_num; i++)
            {
                MakeZombies();
            }
            GoUp = false;
            GoDown = false;
            GoLeft = false;
            GoRight = false;
            GameOver = false;

            PlayerHealth = 100;
            score = ReadScoreFromFile();
            ammo = 10;

            GameTimer.Start();
        }


    }
}
