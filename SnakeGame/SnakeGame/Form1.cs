using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Honeydew;
            this.TransparencyKey = this.BackColor;
        }

        List<Point> bodyPartCords = new List<Point>() { new Point(225, 225), new Point(240, 225), new Point(255, 225), new Point(270, 225), new Point(285, 225) };
        List<Rectangle> rectangles = new List<Rectangle>();
        int moveStepX = 15, moveStepY = 0;
        int points = 0;
        Random random = new Random();
        Graphics g;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void playBtn_Click(object sender, EventArgs e)
        {
            Movement.Start();
            apple.Visible = true;
        }


        private void Movement_Tick(object sender, EventArgs e)
        {
            rectangles = new List<Rectangle>();
            for (int i = 0; i < bodyPartCords.Count; i++)
            {
                rectangles.Add(new Rectangle(bodyPartCords[i], new Size(15, 15)));
            }

            backPanel.Focus();
            g = backPanel.CreateGraphics();
            g.Clear(backPanel.BackColor);

            g.FillRectangle(new SolidBrush(Color.White), rectangles[0]);
            for (int i = 1; i < bodyPartCords.Count; i++)
            {
                g.FillRectangle(new SolidBrush(Color.Blue), rectangles[i]);
            }

            for (int i = bodyPartCords.Count; i > 1; i--)
            {
                bodyPartCords[i - 1] = bodyPartCords[i - 2];
            }

            bodyPartCords[0] = new Point(bodyPartCords[0].X - moveStepX, bodyPartCords[0].Y - moveStepY);

            if (rectangles[0].IntersectsWith(apple.Bounds))
            {
                bodyPartCords.Add(new Point(bodyPartCords.Last().X, bodyPartCords.Last().Y));


                Point appleLoc = new Point(random.Next(15, 405), random.Next(15, 405));
                for (int i = 0; i < bodyPartCords.Count; i++)
                {
                    while (appleLoc == bodyPartCords[i])
                    {
                        appleLoc = new Point(random.Next(15, 405), random.Next(15, 405));
                    }
                    while (appleLoc.X % 15 != 0 || appleLoc.Y % 15 != 0)
                    {
                        appleLoc = new Point(random.Next(15, 405), random.Next(15, 405));
                    }
                }     
                

                apple.Location = appleLoc;

                points += 10;
                pointsLabel.Text = points.ToString();
            }

            for (int i = 1; i < bodyPartCords.Count; i++)
            {
                if (bodyPartCords[0] == bodyPartCords[i])
                {
                    Movement.Stop();
                    MessageBox.Show("Self collision!", "GAME OVER");
                    EndGame();
                }
            }

            if (bodyPartCords[0].Y < 0 || bodyPartCords[0].Y > backPanel.Height || bodyPartCords[0].X < 0 || bodyPartCords[0].X > backPanel.Width)
            {
                Movement.Stop();
                MessageBox.Show("You hit the wall!", "GAME OVER");
                EndGame();
            }
        }

        private void backPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                moveStepX = 0;
                moveStepY = -15;
            }
            else if (e.KeyCode == Keys.Up)
            {
                moveStepX = 0;
                moveStepY = 15;
            }
            else if (e.KeyCode == Keys.Left)
            {
                moveStepX = 15;
                moveStepY = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                moveStepX = -15;
                moveStepY = 0;
            }
        }

        private void EndGame()
        {
            bodyPartCords = new List<Point>() { new Point(225, 225), new Point(240, 225), new Point(255, 225), new Point(270, 225), new Point(285, 225) };
            rectangles = new List<Rectangle>();
            moveStepX = 15;
            moveStepY = 0;
            apple.Visible = false;
            g.Clear(Color.DimGray);
            points = 0;
            pointsLabel.Text = "0";
        }

    }
}
