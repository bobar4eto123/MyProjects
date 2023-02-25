using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BullsAndCows
{
    class Bot_sGuess : Panel
    {
        public Bot_sGuess(List<int> options)
        {
            this.Size = new Size(168, 25);

            Random r = new Random();

            Label numGuess = new Label();
            numGuess.Location = new Point(0, 0);
            numGuess.AutoSize = true;
            numGuess.Font = new Font(FontFamily.GenericSansSerif, 16);
            numGuess.Text = options[r.Next(0, options.Count)].ToString();

            TextBox bulls = new TextBox();
            bulls.Location = new Point(75, 0);
            bulls.AutoSize = false;
            bulls.Size = new Size(20, 25);
            bulls.Font = new Font(FontFamily.GenericSansSerif, 15);
            bulls.TextAlign = HorizontalAlignment.Center;

            Label bullsLbl = new Label();
            bullsLbl.Location = new Point(93, 0);
            bullsLbl.AutoSize = true;
            bullsLbl.Font = new Font(FontFamily.GenericSansSerif, 16);
            bullsLbl.Text = "b.";

            TextBox cows = new TextBox();
            cows.Location = new Point(130, 0);
            cows.AutoSize = false;
            cows.Size = new Size(20, 25);
            cows.Font = new Font(FontFamily.GenericSansSerif, 15);
            cows.TextAlign = HorizontalAlignment.Center;

            Label cowsLbl = new Label();
            cowsLbl.Location = new Point(148, 0);
            cowsLbl.AutoSize = true;
            cowsLbl.Font = new Font(FontFamily.GenericSansSerif, 16);
            cowsLbl.Text = "c.";

            this.Controls.Add(numGuess);
            this.Controls.Add(bulls);
            this.Controls.Add(bullsLbl);
            this.Controls.Add(cows);
            this.Controls.Add(cowsLbl);
        }
    }
}
