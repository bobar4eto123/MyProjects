namespace Numeral_Systems
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
            this.navBar = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.formLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.binaryRadioButton = new System.Windows.Forms.RadioButton();
            this.octalRadioButton = new System.Windows.Forms.RadioButton();
            this.decimalRadioButton = new System.Windows.Forms.RadioButton();
            this.hexadecimalRadioButton = new System.Windows.Forms.RadioButton();
            this.entryTextBox = new System.Windows.Forms.TextBox();
            this.breakLine = new System.Windows.Forms.PictureBox();
            this.binaryTextBox = new System.Windows.Forms.TextBox();
            this.octalTextBox = new System.Windows.Forms.TextBox();
            this.decimalTextBox = new System.Windows.Forms.TextBox();
            this.hexadecimalTextBox = new System.Windows.Forms.TextBox();
            this.binaryLabel = new System.Windows.Forms.Label();
            this.octalLabel = new System.Windows.Forms.Label();
            this.decimalLabel = new System.Windows.Forms.Label();
            this.hexadecimalLabel = new System.Windows.Forms.Label();
            this.navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakLine)).BeginInit();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.navBar.Controls.Add(this.minimizeButton);
            this.navBar.Controls.Add(this.formLabel);
            this.navBar.Controls.Add(this.exitButton);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(314, 26);
            this.navBar.TabIndex = 1;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::Numeral_Systems.Properties.Resources.minimize_b837e9c641dea4c3b5c662586d475f6c;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.Location = new System.Drawing.Point(269, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.BackColor = System.Drawing.Color.Transparent;
            this.formLabel.Font = new System.Drawing.Font("Bodoni Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(3, 1);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(151, 23);
            this.formLabel.TabIndex = 2;
            this.formLabel.Text = "Numeral Systems";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::Numeral_Systems.Properties.Resources._1727490;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Location = new System.Drawing.Point(291, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 20);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // binaryRadioButton
            // 
            this.binaryRadioButton.AutoSize = true;
            this.binaryRadioButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryRadioButton.Location = new System.Drawing.Point(35, 46);
            this.binaryRadioButton.Name = "binaryRadioButton";
            this.binaryRadioButton.Size = new System.Drawing.Size(83, 26);
            this.binaryRadioButton.TabIndex = 2;
            this.binaryRadioButton.Text = "Binary";
            this.binaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // octalRadioButton
            // 
            this.octalRadioButton.AutoSize = true;
            this.octalRadioButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octalRadioButton.Location = new System.Drawing.Point(35, 78);
            this.octalRadioButton.Name = "octalRadioButton";
            this.octalRadioButton.Size = new System.Drawing.Size(73, 26);
            this.octalRadioButton.TabIndex = 3;
            this.octalRadioButton.Text = "Octal";
            this.octalRadioButton.UseVisualStyleBackColor = true;
            // 
            // decimalRadioButton
            // 
            this.decimalRadioButton.AutoSize = true;
            this.decimalRadioButton.Checked = true;
            this.decimalRadioButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalRadioButton.Location = new System.Drawing.Point(147, 46);
            this.decimalRadioButton.Name = "decimalRadioButton";
            this.decimalRadioButton.Size = new System.Drawing.Size(95, 26);
            this.decimalRadioButton.TabIndex = 4;
            this.decimalRadioButton.TabStop = true;
            this.decimalRadioButton.Text = "Decimal";
            this.decimalRadioButton.UseVisualStyleBackColor = true;
            // 
            // hexadecimalRadioButton
            // 
            this.hexadecimalRadioButton.AutoSize = true;
            this.hexadecimalRadioButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexadecimalRadioButton.Location = new System.Drawing.Point(147, 78);
            this.hexadecimalRadioButton.Name = "hexadecimalRadioButton";
            this.hexadecimalRadioButton.Size = new System.Drawing.Size(133, 26);
            this.hexadecimalRadioButton.TabIndex = 5;
            this.hexadecimalRadioButton.Text = "Hexadecimal";
            this.hexadecimalRadioButton.UseVisualStyleBackColor = true;
            // 
            // entryTextBox
            // 
            this.entryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryTextBox.Location = new System.Drawing.Point(12, 119);
            this.entryTextBox.Multiline = true;
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.Size = new System.Drawing.Size(290, 40);
            this.entryTextBox.TabIndex = 6;
            this.entryTextBox.TextChanged += new System.EventHandler(this.entryTextBox_TextChanged);
            // 
            // breakLine
            // 
            this.breakLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.breakLine.Location = new System.Drawing.Point(-2, 175);
            this.breakLine.Name = "breakLine";
            this.breakLine.Size = new System.Drawing.Size(318, 10);
            this.breakLine.TabIndex = 7;
            this.breakLine.TabStop = false;
            // 
            // binaryTextBox
            // 
            this.binaryTextBox.Enabled = false;
            this.binaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryTextBox.Location = new System.Drawing.Point(142, 195);
            this.binaryTextBox.Multiline = true;
            this.binaryTextBox.Name = "binaryTextBox";
            this.binaryTextBox.Size = new System.Drawing.Size(160, 40);
            this.binaryTextBox.TabIndex = 8;
            // 
            // octalTextBox
            // 
            this.octalTextBox.Enabled = false;
            this.octalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octalTextBox.Location = new System.Drawing.Point(142, 241);
            this.octalTextBox.Multiline = true;
            this.octalTextBox.Name = "octalTextBox";
            this.octalTextBox.Size = new System.Drawing.Size(160, 40);
            this.octalTextBox.TabIndex = 9;
            // 
            // decimalTextBox
            // 
            this.decimalTextBox.Enabled = false;
            this.decimalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalTextBox.Location = new System.Drawing.Point(142, 287);
            this.decimalTextBox.Multiline = true;
            this.decimalTextBox.Name = "decimalTextBox";
            this.decimalTextBox.Size = new System.Drawing.Size(160, 40);
            this.decimalTextBox.TabIndex = 10;
            // 
            // hexadecimalTextBox
            // 
            this.hexadecimalTextBox.Enabled = false;
            this.hexadecimalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexadecimalTextBox.Location = new System.Drawing.Point(142, 333);
            this.hexadecimalTextBox.Multiline = true;
            this.hexadecimalTextBox.Name = "hexadecimalTextBox";
            this.hexadecimalTextBox.Size = new System.Drawing.Size(160, 40);
            this.hexadecimalTextBox.TabIndex = 11;
            // 
            // binaryLabel
            // 
            this.binaryLabel.AutoSize = true;
            this.binaryLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryLabel.Location = new System.Drawing.Point(40, 205);
            this.binaryLabel.Name = "binaryLabel";
            this.binaryLabel.Size = new System.Drawing.Size(75, 22);
            this.binaryLabel.TabIndex = 12;
            this.binaryLabel.Text = "Binary :";
            // 
            // octalLabel
            // 
            this.octalLabel.AutoSize = true;
            this.octalLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octalLabel.Location = new System.Drawing.Point(43, 251);
            this.octalLabel.Name = "octalLabel";
            this.octalLabel.Size = new System.Drawing.Size(65, 22);
            this.octalLabel.TabIndex = 13;
            this.octalLabel.Text = "Octal :";
            // 
            // decimalLabel
            // 
            this.decimalLabel.AutoSize = true;
            this.decimalLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalLabel.Location = new System.Drawing.Point(31, 298);
            this.decimalLabel.Name = "decimalLabel";
            this.decimalLabel.Size = new System.Drawing.Size(87, 22);
            this.decimalLabel.TabIndex = 14;
            this.decimalLabel.Text = "Decimal :";
            // 
            // hexadecimalLabel
            // 
            this.hexadecimalLabel.AutoSize = true;
            this.hexadecimalLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexadecimalLabel.Location = new System.Drawing.Point(12, 343);
            this.hexadecimalLabel.Name = "hexadecimalLabel";
            this.hexadecimalLabel.Size = new System.Drawing.Size(125, 22);
            this.hexadecimalLabel.TabIndex = 15;
            this.hexadecimalLabel.Text = "Hexadecimal :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(314, 381);
            this.Controls.Add(this.hexadecimalLabel);
            this.Controls.Add(this.decimalLabel);
            this.Controls.Add(this.octalLabel);
            this.Controls.Add(this.binaryLabel);
            this.Controls.Add(this.hexadecimalTextBox);
            this.Controls.Add(this.decimalTextBox);
            this.Controls.Add(this.octalTextBox);
            this.Controls.Add(this.binaryTextBox);
            this.Controls.Add(this.breakLine);
            this.Controls.Add(this.entryTextBox);
            this.Controls.Add(this.hexadecimalRadioButton);
            this.Controls.Add(this.decimalRadioButton);
            this.Controls.Add(this.octalRadioButton);
            this.Controls.Add(this.binaryRadioButton);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel navBar;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.RadioButton binaryRadioButton;
        private System.Windows.Forms.RadioButton octalRadioButton;
        private System.Windows.Forms.RadioButton decimalRadioButton;
        private System.Windows.Forms.RadioButton hexadecimalRadioButton;
        private System.Windows.Forms.TextBox entryTextBox;
        private System.Windows.Forms.PictureBox breakLine;
        private System.Windows.Forms.TextBox binaryTextBox;
        private System.Windows.Forms.TextBox octalTextBox;
        private System.Windows.Forms.TextBox decimalTextBox;
        private System.Windows.Forms.TextBox hexadecimalTextBox;
        private System.Windows.Forms.Label binaryLabel;
        private System.Windows.Forms.Label octalLabel;
        private System.Windows.Forms.Label decimalLabel;
        private System.Windows.Forms.Label hexadecimalLabel;
    }
}

