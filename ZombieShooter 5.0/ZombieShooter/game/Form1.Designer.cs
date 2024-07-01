
namespace game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.tstHealth = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.god_mod = new System.Windows.Forms.Label();
            this.hart_2 = new System.Windows.Forms.PictureBox();
            this.hart_3 = new System.Windows.Forms.PictureBox();
            this.hart_1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hart_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hart_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hart_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAmmo.Location = new System.Drawing.Point(43, 18);
            this.txtAmmo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(79, 20);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtScore.Location = new System.Drawing.Point(288, 18);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(61, 20);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Kills: 0";
            // 
            // tstHealth
            // 
            this.tstHealth.AutoSize = true;
            this.tstHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstHealth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tstHealth.Location = new System.Drawing.Point(861, 18);
            this.tstHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tstHealth.Name = "tstHealth";
            this.tstHealth.Size = new System.Drawing.Size(67, 20);
            this.tstHealth.TabIndex = 2;
            this.tstHealth.Text = "Health:";
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(935, 21);
            this.HealthBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(137, 15);
            this.HealthBar.TabIndex = 3;
            this.HealthBar.Value = 100;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.mainTimerEvent);
            // 
            // god_mod
            // 
            this.god_mod.AutoSize = true;
            this.god_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.god_mod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.god_mod.Location = new System.Drawing.Point(464, 18);
            this.god_mod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.god_mod.Name = "god_mod";
            this.god_mod.Size = new System.Drawing.Size(176, 20);
            this.god_mod.TabIndex = 5;
            this.god_mod.Text = "nod mod off (pres G)";
            // 
            // hart_2
            // 
            this.hart_2.Image = global::game.Properties.Resources.hart;
            this.hart_2.Location = new System.Drawing.Point(711, 18);
            this.hart_2.Margin = new System.Windows.Forms.Padding(2);
            this.hart_2.Name = "hart_2";
            this.hart_2.Size = new System.Drawing.Size(33, 32);
            this.hart_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hart_2.TabIndex = 8;
            this.hart_2.TabStop = false;
            // 
            // hart_3
            // 
            this.hart_3.Image = global::game.Properties.Resources.hart;
            this.hart_3.Location = new System.Drawing.Point(749, 18);
            this.hart_3.Margin = new System.Windows.Forms.Padding(2);
            this.hart_3.Name = "hart_3";
            this.hart_3.Size = new System.Drawing.Size(33, 32);
            this.hart_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hart_3.TabIndex = 7;
            this.hart_3.TabStop = false;
            // 
            // hart_1
            // 
            this.hart_1.Image = global::game.Properties.Resources.hart;
            this.hart_1.Location = new System.Drawing.Point(674, 18);
            this.hart_1.Margin = new System.Windows.Forms.Padding(2);
            this.hart_1.Name = "hart_1";
            this.hart_1.Size = new System.Drawing.Size(33, 32);
            this.hart_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hart_1.TabIndex = 6;
            this.hart_1.TabStop = false;
            this.hart_1.Click += new System.EventHandler(this.hart_1_Click);
            // 
            // player
            // 
            this.player.Image = global::game.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(15, 96);
            this.player.Margin = new System.Windows.Forms.Padding(2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1091, 487);
            this.Controls.Add(this.hart_2);
            this.Controls.Add(this.hart_3);
            this.Controls.Add(this.hart_1);
            this.Controls.Add(this.god_mod);
            this.Controls.Add(this.player);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.tstHealth);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeysDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeysUp);
            ((System.ComponentModel.ISupportInitialize)(this.hart_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hart_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hart_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label tstHealth;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label god_mod;
        private System.Windows.Forms.PictureBox hart_1;
        private System.Windows.Forms.PictureBox hart_3;
        private System.Windows.Forms.PictureBox hart_2;
    }
}

