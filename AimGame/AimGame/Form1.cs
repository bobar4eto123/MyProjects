using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random loc = new Random();
        int pts = 0;

        private void startButton_Click(object sender, EventArgs e)
        {
            appearance.Start();
            aimPic.Visible = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            appearance.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            pts = 0;
            pointsLabel.Text = $"points = {pts}";
            aimPic.Visible = false;
        }

        private void appearance_Tick(object sender, EventArgs e)
        {
            if (easy.Checked)
            {
                aimPic.Size = new Size(85, 85);
                aimPic.Location = new Point(loc.Next(12, 487), loc.Next(12, 428));
            }
            else if (normal.Checked)
            {
                aimPic.Size = new Size(75, 75);
                aimPic.Location = new Point(loc.Next(12, 497), loc.Next(12, 438));
            }
            else if (hard.Checked)
            {
                aimPic.Size = new Size(65, 65);
                aimPic.Location = new Point(loc.Next(12, 507), loc.Next(12, 448));
            }
        }

        private void aimPic_Click(object sender, EventArgs e)
        {
            if (appearance.Enabled)
            {
                pts++;
                pointsLabel.Text = $"points = {pts}";
            }         
        }

    }
}
