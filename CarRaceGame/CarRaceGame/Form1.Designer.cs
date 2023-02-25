namespace CarRaceGame
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
            this.mainCar = new System.Windows.Forms.PictureBox();
            this.obsticleCar3 = new System.Windows.Forms.PictureBox();
            this.obsticleCar2 = new System.Windows.Forms.PictureBox();
            this.obsticleCar1 = new System.Windows.Forms.PictureBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.obsticleCar4 = new System.Windows.Forms.PictureBox();
            this.breakLine1 = new System.Windows.Forms.PictureBox();
            this.breakLine2 = new System.Windows.Forms.PictureBox();
            this.breakLine3 = new System.Windows.Forms.PictureBox();
            this.breakLine4 = new System.Windows.Forms.PictureBox();
            this.breakLine5 = new System.Windows.Forms.PictureBox();
            this.gOverLabel = new System.Windows.Forms.Label();
            this.pAgainButton = new System.Windows.Forms.Button();
            this.countDown = new System.Windows.Forms.Timer(this.components);
            this.countDownLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticleCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticleCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticleCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticleCar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakLine5)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCar
            // 
            this.mainCar.Image = global::CarRaceGame.Properties.Resources.car;
            this.mainCar.Location = new System.Drawing.Point(234, 374);
            this.mainCar.Name = "mainCar";
            this.mainCar.Size = new System.Drawing.Size(40, 65);
            this.mainCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainCar.TabIndex = 1;
            this.mainCar.TabStop = false;
            // 
            // obsticleCar3
            // 
            this.obsticleCar3.Image = global::CarRaceGame.Properties.Resources.hurdleCar;
            this.obsticleCar3.Location = new System.Drawing.Point(277, 108);
            this.obsticleCar3.Name = "obsticleCar3";
            this.obsticleCar3.Size = new System.Drawing.Size(40, 55);
            this.obsticleCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obsticleCar3.TabIndex = 0;
            this.obsticleCar3.TabStop = false;
            // 
            // obsticleCar2
            // 
            this.obsticleCar2.Image = global::CarRaceGame.Properties.Resources.hurdleCar;
            this.obsticleCar2.Location = new System.Drawing.Point(24, 388);
            this.obsticleCar2.Name = "obsticleCar2";
            this.obsticleCar2.Size = new System.Drawing.Size(40, 55);
            this.obsticleCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obsticleCar2.TabIndex = 0;
            this.obsticleCar2.TabStop = false;
            // 
            // obsticleCar1
            // 
            this.obsticleCar1.Image = global::CarRaceGame.Properties.Resources.hurdleCar;
            this.obsticleCar1.Location = new System.Drawing.Point(47, -9);
            this.obsticleCar1.Name = "obsticleCar1";
            this.obsticleCar1.Size = new System.Drawing.Size(40, 55);
            this.obsticleCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obsticleCar1.TabIndex = 0;
            this.obsticleCar1.TabStop = false;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // obsticleCar4
            // 
            this.obsticleCar4.Image = global::CarRaceGame.Properties.Resources.hurdleCar;
            this.obsticleCar4.Location = new System.Drawing.Point(188, 235);
            this.obsticleCar4.Name = "obsticleCar4";
            this.obsticleCar4.Size = new System.Drawing.Size(40, 55);
            this.obsticleCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obsticleCar4.TabIndex = 0;
            this.obsticleCar4.TabStop = false;
            // 
            // breakLine1
            // 
            this.breakLine1.BackColor = System.Drawing.Color.White;
            this.breakLine1.Location = new System.Drawing.Point(159, -24);
            this.breakLine1.Name = "breakLine1";
            this.breakLine1.Size = new System.Drawing.Size(10, 70);
            this.breakLine1.TabIndex = 2;
            this.breakLine1.TabStop = false;
            // 
            // breakLine2
            // 
            this.breakLine2.BackColor = System.Drawing.Color.White;
            this.breakLine2.Location = new System.Drawing.Point(159, 87);
            this.breakLine2.Name = "breakLine2";
            this.breakLine2.Size = new System.Drawing.Size(10, 70);
            this.breakLine2.TabIndex = 2;
            this.breakLine2.TabStop = false;
            // 
            // breakLine3
            // 
            this.breakLine3.BackColor = System.Drawing.Color.White;
            this.breakLine3.Location = new System.Drawing.Point(159, 198);
            this.breakLine3.Name = "breakLine3";
            this.breakLine3.Size = new System.Drawing.Size(10, 70);
            this.breakLine3.TabIndex = 2;
            this.breakLine3.TabStop = false;
            // 
            // breakLine4
            // 
            this.breakLine4.BackColor = System.Drawing.Color.White;
            this.breakLine4.Location = new System.Drawing.Point(159, 309);
            this.breakLine4.Name = "breakLine4";
            this.breakLine4.Size = new System.Drawing.Size(10, 70);
            this.breakLine4.TabIndex = 2;
            this.breakLine4.TabStop = false;
            // 
            // breakLine5
            // 
            this.breakLine5.BackColor = System.Drawing.Color.White;
            this.breakLine5.Location = new System.Drawing.Point(159, 420);
            this.breakLine5.Name = "breakLine5";
            this.breakLine5.Size = new System.Drawing.Size(10, 70);
            this.breakLine5.TabIndex = 2;
            this.breakLine5.TabStop = false;
            // 
            // gOverLabel
            // 
            this.gOverLabel.AutoSize = true;
            this.gOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gOverLabel.Font = new System.Drawing.Font("Swis721 Hv BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gOverLabel.Location = new System.Drawing.Point(66, 178);
            this.gOverLabel.Name = "gOverLabel";
            this.gOverLabel.Size = new System.Drawing.Size(196, 35);
            this.gOverLabel.TabIndex = 3;
            this.gOverLabel.Text = "GAME OVER";
            this.gOverLabel.Visible = false;
            // 
            // pAgainButton
            // 
            this.pAgainButton.Location = new System.Drawing.Point(128, 216);
            this.pAgainButton.Name = "pAgainButton";
            this.pAgainButton.Size = new System.Drawing.Size(75, 23);
            this.pAgainButton.TabIndex = 4;
            this.pAgainButton.Text = "Play again!";
            this.pAgainButton.UseVisualStyleBackColor = true;
            this.pAgainButton.Visible = false;
            this.pAgainButton.Click += new System.EventHandler(this.pAgainButton_Click);
            // 
            // countDown
            // 
            this.countDown.Interval = 1000;
            this.countDown.Tick += new System.EventHandler(this.countDown_Tick);
            // 
            // countDownLabel
            // 
            this.countDownLabel.AutoSize = true;
            this.countDownLabel.Font = new System.Drawing.Font("News706 BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownLabel.Location = new System.Drawing.Point(139, 197);
            this.countDownLabel.Name = "countDownLabel";
            this.countDownLabel.Size = new System.Drawing.Size(0, 57);
            this.countDownLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(329, 451);
            this.Controls.Add(this.countDownLabel);
            this.Controls.Add(this.gOverLabel);
            this.Controls.Add(this.pAgainButton);
            this.Controls.Add(this.mainCar);
            this.Controls.Add(this.obsticleCar2);
            this.Controls.Add(this.obsticleCar4);
            this.Controls.Add(this.obsticleCar3);
            this.Controls.Add(this.obsticleCar1);
            this.Controls.Add(this.breakLine5);
            this.Controls.Add(this.breakLine4);
            this.Controls.Add(this.breakLine3);
            this.Controls.Add(this.breakLine2);
            this.Controls.Add(this.breakLine1);
            this.Name = "Form1";
            this.Text = "Car Race Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.mainCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticleCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticleCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticleCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticleCar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakLine5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox obsticleCar1;
        private System.Windows.Forms.PictureBox obsticleCar2;
        private System.Windows.Forms.PictureBox obsticleCar3;
        private System.Windows.Forms.PictureBox mainCar;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.PictureBox obsticleCar4;
        private System.Windows.Forms.PictureBox breakLine1;
        private System.Windows.Forms.PictureBox breakLine2;
        private System.Windows.Forms.PictureBox breakLine3;
        private System.Windows.Forms.PictureBox breakLine4;
        private System.Windows.Forms.PictureBox breakLine5;
        private System.Windows.Forms.Label gOverLabel;
        private System.Windows.Forms.Button pAgainButton;
        private System.Windows.Forms.Timer countDown;
        private System.Windows.Forms.Label countDownLabel;
    }
}

