namespace AimGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aimPic = new System.Windows.Forms.PictureBox();
            this.appearance = new System.Windows.Forms.Timer(this.components);
            this.pointsLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.hard = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.easy = new System.Windows.Forms.RadioButton();
            this.resetButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aimPic)).BeginInit();
            this.downPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aimPic
            // 
            this.aimPic.Image = global::AimGame.Properties.Resources.circle;
            this.aimPic.Location = new System.Drawing.Point(12, 12);
            this.aimPic.Name = "aimPic";
            this.aimPic.Size = new System.Drawing.Size(65, 65);
            this.aimPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aimPic.TabIndex = 0;
            this.aimPic.TabStop = false;
            this.aimPic.Visible = false;
            this.aimPic.Click += new System.EventHandler(this.aimPic_Click);
            // 
            // appearance
            // 
            this.appearance.Interval = 600;
            this.appearance.Tick += new System.EventHandler(this.appearance_Tick);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(8, 9);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(104, 22);
            this.pointsLabel.TabIndex = 1;
            this.pointsLabel.Text = "points = 0";
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.downPanel.Controls.Add(this.hard);
            this.downPanel.Controls.Add(this.normal);
            this.downPanel.Controls.Add(this.easy);
            this.downPanel.Controls.Add(this.resetButton);
            this.downPanel.Controls.Add(this.stopButton);
            this.downPanel.Controls.Add(this.startButton);
            this.downPanel.Controls.Add(this.pointsLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 519);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(584, 42);
            this.downPanel.TabIndex = 3;
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Location = new System.Drawing.Point(309, 13);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(48, 17);
            this.hard.TabIndex = 5;
            this.hard.TabStop = true;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Checked = true;
            this.normal.Location = new System.Drawing.Point(245, 13);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(58, 17);
            this.normal.TabIndex = 5;
            this.normal.TabStop = true;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Location = new System.Drawing.Point(191, 13);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(48, 17);
            this.easy.TabIndex = 5;
            this.easy.TabStop = true;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(520, 9);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(52, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(462, 9);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(52, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(404, 9);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(52, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.aimPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Aim Game";
            ((System.ComponentModel.ISupportInitialize)(this.aimPic)).EndInit();
            this.downPanel.ResumeLayout(false);
            this.downPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox aimPic;
        private System.Windows.Forms.Timer appearance;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton easy;
    }
}

