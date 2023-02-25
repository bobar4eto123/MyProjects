using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SnakeGame
{
    public partial class CurvedPanelForm : Panel
    {
        public CurvedPanelForm()
        {

        }

        private Color roundColor = Color.DodgerBlue;
        private Color borderColor = Color.DodgerBlue;
        private float borderThickness = 1.0f;
        private int radius = 15;

        public float BorderThickness
        {
            get { return this.borderThickness; }
            set { this.borderThickness = value; }
        }
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; }
        }
        public Color RoundColor
        {
            get { return this.roundColor; }
            set { this.roundColor = value; }
        }
        public int Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (GraphicsPath graphicsPath = GeneratePath(this.ClientRectangle, Radius))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Brush brush = new SolidBrush(roundColor))
                {
                    g.FillPath(brush, graphicsPath);
                }
                using (Pen pen = new Pen(BorderColor, BorderThickness))
                {
                    g.DrawPath(pen, graphicsPath);
                }
                TextRenderer.DrawText(g, this.Text, this.Font, this.ClientRectangle, this.ForeColor);
            }
        }

        private GraphicsPath GeneratePath(Rectangle rectangle, int radius)
        {
            int cornerRadius = radius;
            int offset = 3;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rectangle.X + rectangle.Width - cornerRadius - offset, rectangle.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rectangle.X + rectangle.Width - cornerRadius - offset, rectangle.Y + rectangle.Height - cornerRadius - offset, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - cornerRadius - offset, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();
            return path;
        }
    }
}
