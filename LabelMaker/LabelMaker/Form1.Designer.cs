namespace LabelMaker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelGridData = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelView = new System.Windows.Forms.Panel();
            this.labelIzdelie = new System.Windows.Forms.Label();
            this.labelDuljina = new System.Windows.Forms.Label();
            this.labelShorichina = new System.Windows.Forms.Label();
            this.labelVisochina = new System.Windows.Forms.Label();
            this.labelKorpus = new System.Windows.Forms.Label();
            this.labelSustav = new System.Windows.Forms.Label();
            this.labelProizvoditel = new System.Windows.Forms.Label();
            this.labelCena = new System.Windows.Forms.Label();
            this.labelDamaska = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.buttonIzvedi = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1470, 688);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelGridData);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1462, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Списък";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelGridData
            // 
            this.panelGridData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGridData.Location = new System.Drawing.Point(0, 0);
            this.panelGridData.Name = "panelGridData";
            this.panelGridData.Size = new System.Drawing.Size(1440, 0);
            this.panelGridData.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1440, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 0);
            this.panel1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1462, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изглед";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelView
            // 
            this.panelView.BackgroundImage = global::LabelMaker.Properties.Resources.Ceni_Etiketi4;
            this.panelView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelView.Controls.Add(this.labelIzdelie);
            this.panelView.Controls.Add(this.labelDuljina);
            this.panelView.Controls.Add(this.labelShorichina);
            this.panelView.Controls.Add(this.labelVisochina);
            this.panelView.Controls.Add(this.labelKorpus);
            this.panelView.Controls.Add(this.labelSustav);
            this.panelView.Controls.Add(this.labelProizvoditel);
            this.panelView.Controls.Add(this.labelCena);
            this.panelView.Controls.Add(this.labelDamaska);
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1078, 661);
            this.panelView.TabIndex = 2;
            // 
            // labelIzdelie
            // 
            this.labelIzdelie.AutoSize = true;
            this.labelIzdelie.BackColor = System.Drawing.Color.Gainsboro;
            this.labelIzdelie.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIzdelie.Location = new System.Drawing.Point(168, 213);
            this.labelIzdelie.Margin = new System.Windows.Forms.Padding(0);
            this.labelIzdelie.Name = "labelIzdelie";
            this.labelIzdelie.Size = new System.Drawing.Size(0, 65);
            this.labelIzdelie.TabIndex = 1;
            // 
            // labelDuljina
            // 
            this.labelDuljina.AutoSize = true;
            this.labelDuljina.BackColor = System.Drawing.Color.Gainsboro;
            this.labelDuljina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuljina.Location = new System.Drawing.Point(170, 304);
            this.labelDuljina.Margin = new System.Windows.Forms.Padding(0);
            this.labelDuljina.Name = "labelDuljina";
            this.labelDuljina.Size = new System.Drawing.Size(0, 31);
            this.labelDuljina.TabIndex = 1;
            // 
            // labelShorichina
            // 
            this.labelShorichina.AutoSize = true;
            this.labelShorichina.BackColor = System.Drawing.Color.Gainsboro;
            this.labelShorichina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShorichina.Location = new System.Drawing.Point(179, 358);
            this.labelShorichina.Margin = new System.Windows.Forms.Padding(0);
            this.labelShorichina.Name = "labelShorichina";
            this.labelShorichina.Size = new System.Drawing.Size(0, 31);
            this.labelShorichina.TabIndex = 1;
            // 
            // labelVisochina
            // 
            this.labelVisochina.AutoSize = true;
            this.labelVisochina.BackColor = System.Drawing.Color.Gainsboro;
            this.labelVisochina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisochina.Location = new System.Drawing.Point(170, 409);
            this.labelVisochina.Margin = new System.Windows.Forms.Padding(0);
            this.labelVisochina.Name = "labelVisochina";
            this.labelVisochina.Size = new System.Drawing.Size(0, 31);
            this.labelVisochina.TabIndex = 1;
            // 
            // labelKorpus
            // 
            this.labelKorpus.AutoSize = true;
            this.labelKorpus.BackColor = System.Drawing.Color.Gainsboro;
            this.labelKorpus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorpus.Location = new System.Drawing.Point(638, 305);
            this.labelKorpus.Margin = new System.Windows.Forms.Padding(0);
            this.labelKorpus.Name = "labelKorpus";
            this.labelKorpus.Size = new System.Drawing.Size(0, 31);
            this.labelKorpus.TabIndex = 1;
            // 
            // labelSustav
            // 
            this.labelSustav.AutoSize = true;
            this.labelSustav.BackColor = System.Drawing.Color.Gainsboro;
            this.labelSustav.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSustav.Location = new System.Drawing.Point(642, 358);
            this.labelSustav.Margin = new System.Windows.Forms.Padding(0);
            this.labelSustav.Name = "labelSustav";
            this.labelSustav.Size = new System.Drawing.Size(0, 31);
            this.labelSustav.TabIndex = 1;
            // 
            // labelProizvoditel
            // 
            this.labelProizvoditel.AutoSize = true;
            this.labelProizvoditel.BackColor = System.Drawing.Color.Gainsboro;
            this.labelProizvoditel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProizvoditel.Location = new System.Drawing.Point(220, 581);
            this.labelProizvoditel.Margin = new System.Windows.Forms.Padding(0);
            this.labelProizvoditel.Name = "labelProizvoditel";
            this.labelProizvoditel.Size = new System.Drawing.Size(0, 31);
            this.labelProizvoditel.TabIndex = 1;
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.BackColor = System.Drawing.Color.Gainsboro;
            this.labelCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 57F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCena.Location = new System.Drawing.Point(728, 550);
            this.labelCena.Margin = new System.Windows.Forms.Padding(0);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(0, 86);
            this.labelCena.TabIndex = 1;
            // 
            // labelDamaska
            // 
            this.labelDamaska.BackColor = System.Drawing.Color.Gainsboro;
            this.labelDamaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamaska.Location = new System.Drawing.Point(659, 418);
            this.labelDamaska.Margin = new System.Windows.Forms.Padding(0);
            this.labelDamaska.Name = "labelDamaska";
            this.labelDamaska.Size = new System.Drawing.Size(393, 62);
            this.labelDamaska.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(12, 691);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добави";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(108, 691);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 40);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Запази";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // buttonIzvedi
            // 
            this.buttonIzvedi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIzvedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzvedi.Location = new System.Drawing.Point(204, 691);
            this.buttonIzvedi.Name = "buttonIzvedi";
            this.buttonIzvedi.Size = new System.Drawing.Size(90, 40);
            this.buttonIzvedi.TabIndex = 5;
            this.buttonIzvedi.Text = "Изведи";
            this.buttonIzvedi.UseVisualStyleBackColor = true;
            this.buttonIzvedi.Click += new System.EventHandler(this.buttonIzvedi_Click);
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(1385, 691);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(100, 40);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Принтирай";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1471, 26);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 662);
            this.vScrollBar1.SmallChange = 10;
            this.vScrollBar1.TabIndex = 6;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 736);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.buttonIzvedi);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Програма за етикети";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelKorpus;
        private System.Windows.Forms.Label labelVisochina;
        private System.Windows.Forms.Label labelShorichina;
        private System.Windows.Forms.Label labelDuljina;
        private System.Windows.Forms.Label labelIzdelie;
        private System.Windows.Forms.Label labelDamaska;
        private System.Windows.Forms.Label labelSustav;
        private System.Windows.Forms.Label labelProizvoditel;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.Button buttonIzvedi;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Panel panelView;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panelGridData;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

