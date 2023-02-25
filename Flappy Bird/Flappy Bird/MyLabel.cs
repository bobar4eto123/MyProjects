using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExercises
{
    public partial class MyLabel : Label
    {
        public MyLabel()
        {
            InitializeComponent();
        }

        Graphics graphics;

        private int borderThicknes = 2;

        public int BorderThicknes
        {
            get { return this.borderThicknes; }
            set 
            {
                if (value < 2)
                {
                    value = 2;
                }

                this.borderThicknes = value;
            }
        }

        public Color BorderColor { get; set; }

        protected override void OnPaint(PaintEventArgs draw)
        {

            //base.OnPaint(draw);
            graphics = draw.Graphics;
            graphics.DrawRectangle(new Pen(BorderColor, BorderThicknes), this.ClientRectangle);
            TextRenderer.DrawText(graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor);

        }

    }
}
