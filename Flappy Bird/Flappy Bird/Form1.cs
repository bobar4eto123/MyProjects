using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int points = 0;
        bool toohigh = false, endgame = true;
        PictureBox[] obsticles = new PictureBox[10];

        private void Form1_Load(object sender, EventArgs e)
        {
            obsticles[0] = pictureBox1;
            obsticles[1] = pictureBox2;
            obsticles[2] = pictureBox3;
            obsticles[3] = pictureBox4;
            obsticles[4] = pictureBox5;
            obsticles[5] = pictureBox6;
            obsticles[6] = pictureBox7;
            obsticles[7] = pictureBox8;
            obsticles[8] = pictureBox9;
            obsticles[9] = pictureBox10;
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BorderStyle = BorderStyle.FixedSingle;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BorderStyle = BorderStyle.None;
        }

        private void newGamePicBoxButton_MouseEnter(object sender, EventArgs e)
        {
            newGamePicBoxButton.BorderStyle = BorderStyle.Fixed3D;
        }

        private void newGamePicBoxButton_MouseLeave(object sender, EventArgs e)
        {
            newGamePicBoxButton.BorderStyle = BorderStyle.None;
        }

        private void startPicBoxButton_MouseEnter(object sender, EventArgs e)
        {
            startPicBoxButton.BorderStyle = BorderStyle.FixedSingle;
        }

        private void startPicBoxButton_MouseLeave(object sender, EventArgs e)
        {
            startPicBoxButton.BorderStyle = BorderStyle.None;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                if (toohigh == false && endgame == false)
                {
                    myBird.Location = new Point(myBird.Location.X, myBird.Location.Y - 38);
                    reducedSpd.Start();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGamePicBoxButton_Click(object sender, EventArgs e)
        {
            int[] values = new int[] { 304, 304, 648, 648, 992, 992, 1336, 1336, 1680, 1680 };
            points = 0;
            pointsLabel.Text = $"pts. = {points}";

            for (int i = 0; i < values.Length; i++)
            {
                obsticles[i].Location = new Point(values[i], obsticles[i].Location.Y);
            }

            myBird.Location = new Point(80, 215);
            gameOverMenu.Visible = false;
            endgame = true;
            startPicBoxButton.Visible = true;
        }

        private void startPicBoxButton_Click(object sender, EventArgs e)
        {
            birdGravity.Start();
            columns.Start();
            endgame = false;
            startPicBoxButton.Visible = false;
        }

        private void columns_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < obsticles.Length; i++)
            {
                obsticles[i].Location = new Point(obsticles[i].Location.X - 2, obsticles[i].Location.Y);
            }

            if (pictureBox1.Location.X <= -40 || pictureBox2.Location.X <= -40)
            {
                pictureBox1.Location = new Point(1720, pictureBox1.Location.Y);
                pictureBox2.Location = new Point(1720, pictureBox2.Location.Y);
            }
            else if (pictureBox3.Location.X <= -40 || pictureBox4.Location.X <= -40)
            {
                pictureBox3.Location = new Point(1720, pictureBox3.Location.Y);
                pictureBox4.Location = new Point(1720, pictureBox4.Location.Y);
            }
            else if (pictureBox5.Location.X <= -40 || pictureBox6.Location.X <= -40)
            {
                pictureBox5.Location = new Point(1720, pictureBox5.Location.Y);
                pictureBox6.Location = new Point(1720, pictureBox6.Location.Y);
            }
            else if (pictureBox7.Location.X <= -40 || pictureBox8.Location.X <= -40)
            {
                pictureBox7.Location = new Point(1720, pictureBox7.Location.Y);
                pictureBox8.Location = new Point(1720, pictureBox8.Location.Y);
            }
            else if (pictureBox9.Location.X <= -40 || pictureBox10.Location.X <= -40)
            {
                pictureBox9.Location = new Point(1720, pictureBox9.Location.Y);
                pictureBox10.Location = new Point(1720, pictureBox10.Location.Y);
            }

            //---------------------------------------------------------------------------------------------------//
            //---------------------------------------------------------------------------------------------------//

            if (pictureBox1.Location.X == 60 || pictureBox2.Location.X == 60)
            {
                points++;
            }
            else if (pictureBox3.Location.X == 60 || pictureBox4.Location.X == 60)
            {
                points++;
            }
            else if (pictureBox5.Location.X == 60 || pictureBox6.Location.X == 60)
            {
                points++;
            }
            else if (pictureBox7.Location.X == 60 || pictureBox8.Location.X == 60)
            {
                points++;
            }
            else if (pictureBox9.Location.X == 60 || pictureBox10.Location.X == 60)
            {
                points++;
            }

            pointsLabel.Text = $"pts. = {points}";

        }

        private void birdGravity_Tick(object sender, EventArgs e)
        {
            myBird.Location = new Point(myBird.Location.X, myBird.Location.Y + 2);

            Rectangle bird_r = new Rectangle(myBird.Location, myBird.Size);

            Rectangle[] rects = new Rectangle[10];

            for (int i = 0; i < rects.Length; i++)
            {
                rects[i] = new Rectangle(obsticles[i].Location, obsticles[i].Size);
            }

            bool colission = Colides(bird_r, rects[0]); 

            for (int i = 1; i < rects.Length; i++)
            {
                colission = colission || Colides(bird_r, rects[i]);
            }

            birdGravity.Interval = reducedSpd.Enabled ? 30 : 15;

            toohigh = myBird.Location.Y <= 0 ? true : false;

            if (myBird.Location.Y >= 460 || colission)
            {
                endgame = true;
                birdGravity.Stop();
                columns.Stop();
                gameOverMenu.Visible = true;
            }

        }

        private void reducedSpd_Tick(object sender, EventArgs e)
        {
           reducedSpd.Stop();
        }

        public bool Colides(Rectangle f, Rectangle s)
        {
            if (s.X > f.X + f.Width || f.X > s.X + s.Width)
            {
                return false;
            }
            if (s.Y > f.Y + f.Height || f.Y > s.Y + s.Height)
            {
                return false;
            }
            return true;
        }


    }
}
