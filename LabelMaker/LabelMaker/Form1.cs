using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int locX = 0, locY = 0;
        List<RadioButton> radButtons = new List<RadioButton>();
        List<Label> labels = new List<Label>();

        private void Form1_Load(object sender, EventArgs e)
        {
            labels.Add(labelIzdelie);
            labels.Add(labelDuljina);
            labels.Add(labelShorichina);
            labels.Add(labelVisochina);
            labels.Add(labelKorpus);
            labels.Add(labelSustav);
            labels.Add(labelDamaska);
            labels.Add(labelProizvoditel);
            labels.Add(labelCena);

            using (StreamReader reader = new StreamReader("list.txt"))
            {
                string line = reader.ReadLine();

                for (int l = 0; !string.IsNullOrEmpty(line); l++)
                {
                    CreateRow();

                    for (int i = 0; i < 9; i++)
                    {
                        var values = line.Split('~').ToArray();
                        panelGridData.Controls[i + l * 9].Text = values[i];
                    }

                    line = reader.ReadLine();
                }
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CreateRow();
            tabControl1.SelectedTab = tabPage1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("list.txt"))
            {
                for (int i = 0; i < panelGridData.Controls.Count / 9; i++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        writer.Write(panelGridData.Controls[k + i * 9].Text + "~");
                    }
                    writer.WriteLine();
                }
            }

        }

        private void buttonIzvedi_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= radButtons.Count; i++)
            {
                if (radButtons[i - 1].Checked == true)
                {
                    for (int k = (i - 1) * 9, j = 0; k < i * 9; j++, k++) 
                    {
                        labels[j].Text = panelGridData.Controls[k].Text;
                    }              
                }
            }

            tabControl1.SelectedTab = tabPage2;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        Bitmap btm;

        private void printButton_Click(object sender, EventArgs e)
        {
            btm = new Bitmap(panelView.Width, panelView.Height, panelView.CreateGraphics());
            panelView.DrawToBitmap(btm, panelView.ClientRectangle);

            using (PrintPreviewDialog prtPrw = new PrintPreviewDialog())
            {
                prtPrw.Document = printDocument1;
                prtPrw.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(ResizeBitmap(btm, btm.Width, btm.Height, 1.361F), 0, printDocument1.DefaultPageSettings.PaperSize.Height / 2 + 14);           
        }

        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height, float factor)
        {
            Bitmap result = new Bitmap(width, height);
            result.SetResolution(bmp.HorizontalResolution * factor, bmp.VerticalResolution * factor);

            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (panelGridData.Height >= 662)
            {
                vScrollBar1.Maximum = panelGridData.Height / 20;

                panelGridData.Location = new Point(0, -vScrollBar1.Value * 15);
                panel1.Location = new Point(panel1.Location.X, -vScrollBar1.Value * 15); 
            }
        }

        private void CreateRow()
        {
            List<TextBox> row = new List<TextBox>(9); 
            
             for (int i = 0; i < 9; i++)
             {
                 row.Add(new TextBox());
                 row[i].Size = new Size(160, 20);
                 row[i].Location = new Point(locX, locY);
                 panelGridData.Controls.Add(row[i]);
                 locX += 160;
             }

             RadioButton radioButton = new RadioButton();
             radioButton.Location = new Point(0, locY);
             radioButton.Text = string.Empty;
             panel1.Size = new Size(panel1.Width, panel1.Height + 20);
             panel1.Controls.Add(radioButton);
             radButtons.Add(radioButton);

             locX = 0;
             locY += 20;
             panelGridData.Size = new Size(panelGridData.Width, panelGridData.Height + 20);          

        }

    }
}
