namespace SnakeGame
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
            this.Movement = new System.Windows.Forms.Timer(this.components);
            this.curvedPanelForm1 = new SnakeGame.CurvedPanelForm();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backPanel = new System.Windows.Forms.Panel();
            this.apple = new System.Windows.Forms.PictureBox();
            this.SnakeGame = new System.Windows.Forms.Label();
            this.curvedPanelForm1.SuspendLayout();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            this.SuspendLayout();
            // 
            // Movement
            // 
            this.Movement.Tick += new System.EventHandler(this.Movement_Tick);
            // 
            // curvedPanelForm1
            // 
            this.curvedPanelForm1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.curvedPanelForm1.BorderThickness = 1F;
            this.curvedPanelForm1.Controls.Add(this.pointsLabel);
            this.curvedPanelForm1.Controls.Add(this.playBtn);
            this.curvedPanelForm1.Controls.Add(this.button1);
            this.curvedPanelForm1.Controls.Add(this.backPanel);
            this.curvedPanelForm1.Controls.Add(this.SnakeGame);
            this.curvedPanelForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curvedPanelForm1.Location = new System.Drawing.Point(0, 0);
            this.curvedPanelForm1.Name = "curvedPanelForm1";
            this.curvedPanelForm1.Radius = 100;
            this.curvedPanelForm1.RoundColor = System.Drawing.Color.DarkSlateGray;
            this.curvedPanelForm1.Size = new System.Drawing.Size(520, 529);
            this.curvedPanelForm1.TabIndex = 3;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(352, 491);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(21, 24);
            this.pointsLabel.TabIndex = 6;
            this.pointsLabel.Text = "0";
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(223, 488);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 34);
            this.playBtn.TabIndex = 5;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SnakeGame.Properties.Resources.icons8_cancel_96px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(356, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 33);
            this.button1.TabIndex = 4;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.DimGray;
            this.backPanel.Controls.Add(this.apple);
            this.backPanel.Location = new System.Drawing.Point(43, 47);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(435, 435);
            this.backPanel.TabIndex = 3;
            this.backPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.backPanel_PreviewKeyDown);
            // 
            // apple
            // 
            this.apple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apple.Location = new System.Drawing.Point(15, 225);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(15, 15);
            this.apple.TabIndex = 0;
            this.apple.TabStop = false;
            this.apple.Visible = false;
            // 
            // SnakeGame
            // 
            this.SnakeGame.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SnakeGame.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnakeGame.Location = new System.Drawing.Point(170, 1);
            this.SnakeGame.Name = "SnakeGame";
            this.SnakeGame.Size = new System.Drawing.Size(180, 39);
            this.SnakeGame.TabIndex = 2;
            this.SnakeGame.Text = "Snake Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(520, 529);
            this.Controls.Add(this.curvedPanelForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.curvedPanelForm1.ResumeLayout(false);
            this.curvedPanelForm1.PerformLayout();
            this.backPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SnakeGame;
        private CurvedPanelForm curvedPanelForm1;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Timer Movement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.PictureBox apple;
        private System.Windows.Forms.Label pointsLabel;
    }
}

