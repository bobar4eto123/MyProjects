namespace Flappy_Bird
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
            this.birdGravity = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.reducedSpd = new System.Windows.Forms.Timer(this.components);
            this.columns = new System.Windows.Forms.Timer(this.components);
            this.gameOverMenu = new System.Windows.Forms.GroupBox();
            this.newGamePicBoxButton = new System.Windows.Forms.PictureBox();
            this.startPicBoxButton = new System.Windows.Forms.PictureBox();
            this.pointsLabel = new FormExercises.MyLabel();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myBird = new System.Windows.Forms.PictureBox();
            this.gameOverMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newGamePicBoxButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPicBoxButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBird)).BeginInit();
            this.SuspendLayout();
            // 
            // birdGravity
            // 
            this.birdGravity.Interval = 15;
            this.birdGravity.Tick += new System.EventHandler(this.birdGravity_Tick);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(6, 15);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(244, 40);
            this.gameOverLabel.TabIndex = 2;
            this.gameOverLabel.Text = "GAME OVER";
            // 
            // reducedSpd
            // 
            this.reducedSpd.Interval = 450;
            this.reducedSpd.Tick += new System.EventHandler(this.reducedSpd_Tick);
            // 
            // columns
            // 
            this.columns.Interval = 10;
            this.columns.Tick += new System.EventHandler(this.columns_Tick);
            // 
            // gameOverMenu
            // 
            this.gameOverMenu.Controls.Add(this.newGamePicBoxButton);
            this.gameOverMenu.Controls.Add(this.gameOverLabel);
            this.gameOverMenu.Location = new System.Drawing.Point(122, 186);
            this.gameOverMenu.Name = "gameOverMenu";
            this.gameOverMenu.Size = new System.Drawing.Size(256, 118);
            this.gameOverMenu.TabIndex = 18;
            this.gameOverMenu.TabStop = false;
            this.gameOverMenu.Visible = false;
            // 
            // newGamePicBoxButton
            // 
            this.newGamePicBoxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newGamePicBoxButton.Image = global::Flappy_Bird.Properties.Resources.menu_new_game;
            this.newGamePicBoxButton.Location = new System.Drawing.Point(65, 58);
            this.newGamePicBoxButton.Name = "newGamePicBoxButton";
            this.newGamePicBoxButton.Size = new System.Drawing.Size(130, 50);
            this.newGamePicBoxButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newGamePicBoxButton.TabIndex = 17;
            this.newGamePicBoxButton.TabStop = false;
            this.newGamePicBoxButton.Click += new System.EventHandler(this.newGamePicBoxButton_Click);
            this.newGamePicBoxButton.MouseEnter += new System.EventHandler(this.newGamePicBoxButton_MouseEnter);
            this.newGamePicBoxButton.MouseLeave += new System.EventHandler(this.newGamePicBoxButton_MouseLeave);
            // 
            // startPicBoxButton
            // 
            this.startPicBoxButton.Image = global::Flappy_Bird.Properties.Resources.start_button;
            this.startPicBoxButton.Location = new System.Drawing.Point(12, 12);
            this.startPicBoxButton.Name = "startPicBoxButton";
            this.startPicBoxButton.Size = new System.Drawing.Size(100, 53);
            this.startPicBoxButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startPicBoxButton.TabIndex = 19;
            this.startPicBoxButton.TabStop = false;
            this.startPicBoxButton.Click += new System.EventHandler(this.startPicBoxButton_Click);
            this.startPicBoxButton.MouseEnter += new System.EventHandler(this.startPicBoxButton_MouseEnter);
            this.startPicBoxButton.MouseLeave += new System.EventHandler(this.startPicBoxButton_MouseLeave);
            // 
            // pointsLabel
            // 
            this.pointsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pointsLabel.BorderColor = System.Drawing.Color.Gray;
            this.pointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointsLabel.BorderThicknes = 2;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Image = global::Flappy_Bird.Properties.Resources.transparent;
            this.pointsLabel.Location = new System.Drawing.Point(190, 468);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(120, 32);
            this.pointsLabel.TabIndex = 15;
            this.pointsLabel.Text = "pts. = 0";
            this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = global::Flappy_Bird.Properties.Resources.X;
            this.exitButton.Location = new System.Drawing.Point(479, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(18, 18);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 13;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox10.Location = new System.Drawing.Point(1680, 207);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(40, 294);
            this.pictureBox10.TabIndex = 12;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox9.Location = new System.Drawing.Point(1680, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(40, 94);
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox8.Location = new System.Drawing.Point(1336, 426);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 75);
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox7.Location = new System.Drawing.Point(1336, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 308);
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox6.Location = new System.Drawing.Point(992, 201);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 300);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox5.Location = new System.Drawing.Point(992, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 75);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox4.Location = new System.Drawing.Point(648, 348);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 153);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox3.Location = new System.Drawing.Point(648, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 220);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Location = new System.Drawing.Point(304, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 213);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Location = new System.Drawing.Point(304, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 167);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // myBird
            // 
            this.myBird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.myBird.Location = new System.Drawing.Point(80, 215);
            this.myBird.Name = "myBird";
            this.myBird.Size = new System.Drawing.Size(40, 40);
            this.myBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myBird.TabIndex = 1;
            this.myBird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.startPicBoxButton);
            this.Controls.Add(this.gameOverMenu);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.myBird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.gameOverMenu.ResumeLayout(false);
            this.gameOverMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newGamePicBoxButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPicBoxButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox myBird;
        private System.Windows.Forms.Timer birdGravity;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Timer reducedSpd;
        private System.Windows.Forms.Timer columns;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox exitButton;
        private FormExercises.MyLabel pointsLabel;
        private System.Windows.Forms.PictureBox newGamePicBoxButton;
        private System.Windows.Forms.GroupBox gameOverMenu;
        private System.Windows.Forms.PictureBox startPicBoxButton;
    }
}

