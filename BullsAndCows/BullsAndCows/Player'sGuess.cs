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
    class Player_sGuess : Panel
    {

        public Player_sGuess(string guess, int bulls, int cows)
        {
            this.Size = new Size(168, 25);          

            Label numGuess = new Label();
            numGuess.Location = new Point(0, 0);
            numGuess.AutoSize = true;
            numGuess.Font = new Font(FontFamily.GenericSansSerif, 16);
            numGuess.Text = guess;

            Label bullsLbl = new Label();
            bullsLbl.Location = new Point(75, 0);
            bullsLbl.AutoSize = true;
            bullsLbl.Font = new Font(FontFamily.GenericSansSerif, 16);
            bullsLbl.Text = bulls + " b.";

            Label cowsLbl = new Label();
            cowsLbl.Location = new Point(130, 0);
            cowsLbl.AutoSize = true;
            cowsLbl.Font = new Font(FontFamily.GenericSansSerif, 16);
            cowsLbl.Text = cows + " c.";

            this.Controls.Add(numGuess);
            this.Controls.Add(bullsLbl);
            this.Controls.Add(cowsLbl);
        }   
        
    }
}
