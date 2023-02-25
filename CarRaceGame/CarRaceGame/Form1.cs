using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRaceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random randomLocation = new Random();
        List<PictureBox> breakLines = new List<PictureBox>();
        List<PictureBox> obsticleCars = new List<PictureBox>();
        bool endGame = false;
         
        private void Form1_Load(object sender, EventArgs e)
        {
            countDown.Start();
            breakLines.Add(breakLine1);
            breakLines.Add(breakLine2);
            breakLines.Add(breakLine3);
            breakLines.Add(breakLine4);
            breakLines.Add(breakLine5);
            obsticleCars.Add(obsticleCar1);
            obsticleCars.Add(obsticleCar2);
            obsticleCars.Add(obsticleCar3);
            obsticleCars.Add(obsticleCar4);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < breakLines.Count; i++)
            {
                breakLines[i].Location = new Point(159, breakLines[i].Location.Y + 2);

                if (breakLines[i].Location.Y >= 490)
                {
                    breakLines[i].Location = new Point(breakLines[i].Location.X, -70);
                }
            }

            for (int i = 0; i < obsticleCars.Count; i++)
            {
                obsticleCars[i].Location = new Point(obsticleCars[i].Location.X, obsticleCars[i].Location.Y + 2);

                if (obsticleCars[i].Location.Y >= 490)
                {
                    obsticleCars[i].Location = new Point(randomLocation.Next(0, 290), -45);
                }
            }

            if (mainCar.Location.X <= 3) mainCar.Location = new Point(3, mainCar.Location.Y);
            if (mainCar.Location.X >= 287) mainCar.Location = new Point(287, mainCar.Location.Y);
            if (mainCar.Location.Y <= 4) mainCar.Location = new Point(mainCar.Location.X, 4);
            if (mainCar.Location.Y >= 383) mainCar.Location = new Point(mainCar.Location.X, 383);

            Rectangle car_r = new Rectangle(mainCar.Location, mainCar.Size);

            Rectangle[] rects = new Rectangle[4];

            for (int i = 0; i < rects.Length; i++)
            {
                rects[i] = new Rectangle(obsticleCars[i].Location, obsticleCars[i].Size);
            }

            bool colission = Colides(car_r, rects[0]);

            for (int i = 1; i < rects.Length; i++)
            {
                colission = colission || Colides(car_r, rects[i]);
            }

            if (colission)
            {
                endGame = true;
                mainTimer.Stop();
                gOverLabel.Visible = true;
                pAgainButton.Visible = true;
                colission = false;
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {          
            if (!endGame)
            {
                if (e.KeyChar == 'w')
                {
                    mainCar.Location = new Point(mainCar.Location.X, mainCar.Location.Y - 5);
                }
                if (e.KeyChar == 's')
                {
                    mainCar.Location = new Point(mainCar.Location.X, mainCar.Location.Y + 5);
                }
                if (e.KeyChar == 'a')
                {
                    mainCar.Location = new Point(mainCar.Location.X - 5, mainCar.Location.Y);
                }
                if (e.KeyChar == 'd')
                {
                    mainCar.Location = new Point(mainCar.Location.X + 5, mainCar.Location.Y);
                }
            }
        }

        private void pAgainButton_Click(object sender, EventArgs e)
        {
            countdown = 3;

            breakLine1.Location = new Point(159, -24);
            breakLine2.Location = new Point(159, 87);
            breakLine3.Location = new Point(159, 198);
            breakLine4.Location = new Point(159, 309);
            breakLine5.Location = new Point(159, 420);
            obsticleCar1.Location = new Point(47, -9);
            obsticleCar2.Location = new Point(24, 388);
            obsticleCar3.Location = new Point(277, 108);
            obsticleCar4.Location = new Point(188, 235);
            mainCar.Location = new Point(234, 374);

            endGame = false;      
            gOverLabel.Visible = false;
            pAgainButton.Visible = false;
            this.Focus();       
            countDownLabel.Visible = true;
            countDown.Start();
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

        int countdown = 3;

        private void countDown_Tick(object sender, EventArgs e)
        {
            countDownLabel.Text = countdown.ToString();      

            if (countdown == 0)
            {
                countDown.Stop();
                mainTimer.Start();
                countDownLabel.Visible = false;
                countDownLabel.Text = null;
            }

            countdown--;
        }
    }
}
