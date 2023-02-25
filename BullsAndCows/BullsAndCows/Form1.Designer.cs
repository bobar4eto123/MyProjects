
namespace BullsAndCows
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.playerNumberTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.botNumberTxtBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guessTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.guessBtn = new System.Windows.Forms.Button();
            this.stateBtn = new System.Windows.Forms.Button();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.playerGuessesPnl = new System.Windows.Forms.Panel();
            this.botGuessesPnl = new System.Windows.Forms.Panel();
            this.forfaitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your number:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(181, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 383);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 388);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(191, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bot\'s number:";
            // 
            // playerNumberTxtBox
            // 
            this.playerNumberTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerNumberTxtBox.Location = new System.Drawing.Point(130, 8);
            this.playerNumberTxtBox.Mask = "0000";
            this.playerNumberTxtBox.Name = "playerNumberTxtBox";
            this.playerNumberTxtBox.Size = new System.Drawing.Size(46, 29);
            this.playerNumberTxtBox.TabIndex = 6;
            this.playerNumberTxtBox.ValidatingType = typeof(int);
            // 
            // botNumberTxtBox
            // 
            this.botNumberTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.botNumberTxtBox.Location = new System.Drawing.Point(317, 8);
            this.botNumberTxtBox.Name = "botNumberTxtBox";
            this.botNumberTxtBox.ReadOnly = true;
            this.botNumberTxtBox.Size = new System.Drawing.Size(46, 29);
            this.botNumberTxtBox.TabIndex = 7;
            this.botNumberTxtBox.Text = "????";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(2, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 10);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(-2, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 10);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(2, 387);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 10);
            this.panel5.TabIndex = 9;
            // 
            // guessTxtBox
            // 
            this.guessTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guessTxtBox.Location = new System.Drawing.Point(241, 405);
            this.guessTxtBox.Mask = "0000";
            this.guessTxtBox.Name = "guessTxtBox";
            this.guessTxtBox.ReadOnly = true;
            this.guessTxtBox.Size = new System.Drawing.Size(46, 29);
            this.guessTxtBox.TabIndex = 10;
            this.guessTxtBox.ValidatingType = typeof(int);
            // 
            // guessBtn
            // 
            this.guessBtn.Enabled = false;
            this.guessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guessBtn.Location = new System.Drawing.Point(288, 403);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(75, 32);
            this.guessBtn.TabIndex = 11;
            this.guessBtn.Text = "Guess";
            this.guessBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // stateBtn
            // 
            this.stateBtn.Enabled = false;
            this.stateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateBtn.Location = new System.Drawing.Point(5, 403);
            this.stateBtn.Name = "stateBtn";
            this.stateBtn.Size = new System.Drawing.Size(75, 32);
            this.stateBtn.TabIndex = 13;
            this.stateBtn.Text = "State";
            this.stateBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stateBtn.UseVisualStyleBackColor = true;
            this.stateBtn.Click += new System.EventHandler(this.stateBtn_Click);
            // 
            // newGameBtn
            // 
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameBtn.Location = new System.Drawing.Point(125, 403);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(32, 32);
            this.newGameBtn.TabIndex = 23;
            this.newGameBtn.Text = "N";
            this.newGameBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // playerGuessesPnl
            // 
            this.playerGuessesPnl.Location = new System.Drawing.Point(195, 56);
            this.playerGuessesPnl.Name = "playerGuessesPnl";
            this.playerGuessesPnl.Size = new System.Drawing.Size(170, 325);
            this.playerGuessesPnl.TabIndex = 24;
            // 
            // botGuessesPnl
            // 
            this.botGuessesPnl.Location = new System.Drawing.Point(5, 56);
            this.botGuessesPnl.Name = "botGuessesPnl";
            this.botGuessesPnl.Size = new System.Drawing.Size(170, 325);
            this.botGuessesPnl.TabIndex = 24;
            // 
            // forfaitBtn
            // 
            this.forfaitBtn.Enabled = false;
            this.forfaitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forfaitBtn.Location = new System.Drawing.Point(162, 403);
            this.forfaitBtn.Name = "forfaitBtn";
            this.forfaitBtn.Size = new System.Drawing.Size(48, 32);
            this.forfaitBtn.TabIndex = 23;
            this.forfaitBtn.Text = "FF";
            this.forfaitBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.forfaitBtn.UseVisualStyleBackColor = true;
            this.forfaitBtn.Click += new System.EventHandler(this.forfaitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 443);
            this.Controls.Add(this.botGuessesPnl);
            this.Controls.Add(this.playerGuessesPnl);
            this.Controls.Add(this.forfaitBtn);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.stateBtn);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.guessTxtBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.botNumberTxtBox);
            this.Controls.Add(this.playerNumberTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bulls and Cows";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox playerNumberTxtBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox botNumberTxtBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox guessTxtBox;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Button stateBtn;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Panel playerGuessesPnl;
        private System.Windows.Forms.Panel botGuessesPnl;
        private System.Windows.Forms.Button forfaitBtn;
    }
}

