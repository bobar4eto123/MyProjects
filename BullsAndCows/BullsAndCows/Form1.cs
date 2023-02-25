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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<int> validNumbers = new List<int>();
        List<int> possibleOptionsForPlayersNumber = new List<int>();
        Point savedLocationForPlayersGuesses = new Point(0, 0);
        Point savedLocationForBotsGuesses = new Point(0, 0);
        int botNumber = 0;

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            validNumbers = GenerateNumberList();
            possibleOptionsForPlayersNumber = GenerateNumberList();

            try
            {
                if (!validNumbers.Contains(int.Parse(playerNumberTxtBox.Text)))
                {
                    MessageBox.Show("Please, choose a valid 4-digit number.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please, choose a valid 4-digit number.");
                return;
            }      

            Random r = new Random();
            botNumber = validNumbers[r.Next(0, validNumbers.Count)];

            playerNumberTxtBox.ReadOnly = true;
            botNumberTxtBox.ReadOnly = false;
            guessTxtBox.ReadOnly = false;
            newGameBtn.Enabled = false;
            forfaitBtn.Enabled = true;
            guessBtn.Enabled = true;
        }

        private void forfaitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You lose.");

            ReturnStartView();
        }

        private void guessBtn_Click(object sender, EventArgs e)
        {
            string guess = guessTxtBox.Text;
            string botNum = botNumber.ToString();
            int bulls = 0, cows = 0;

            guessTxtBox.Text = "";
            try
            {
                if (!validNumbers.Contains(int.Parse(guess)))
                {
                    MessageBox.Show("Invalid number.");
                    return;
                }
            }
            catch 
            {
                MessageBox.Show("Invalid number.");
                return;
            }

            CalculateAndSaveBullsAndCows(guess, botNum, ref bulls, ref cows);

            PresentResultFromGuess(guess, bulls, cows, ref savedLocationForPlayersGuesses);

            CheckForWin(bulls);

            MakeBotsGuess(possibleOptionsForPlayersNumber, ref savedLocationForBotsGuesses);

            guessTxtBox.ReadOnly = true;
        }

        private void stateBtn_Click(object sender, EventArgs e)
        {

            int botsGuess = int.Parse(botGuessesPnl.Controls[savedLocationForBotsGuesses.Y / 25 - 1].Controls[0].Text);
            int statedBulls = int.Parse(botGuessesPnl.Controls[savedLocationForBotsGuesses.Y / 25 - 1].Controls[1].Text);
            int statedCows = int.Parse(botGuessesPnl.Controls[savedLocationForBotsGuesses.Y / 25 - 1].Controls[3].Text);

            CheckForWin(statedBulls);

            possibleOptionsForPlayersNumber = RefreshPossibleOptions(possibleOptionsForPlayersNumber, botsGuess, statedBulls, statedCows);

            guessTxtBox.ReadOnly = false;
            guessBtn.Enabled = true;
            stateBtn.Enabled = false;          
        }


        private List<int> GenerateNumberList()
        {
            List<int> numbers = new List<int>();
            for (int i = 1000; i <= 9999; i++)
            {
                bool noRepeats = true;
                char[] number = i.ToString().ToCharArray();
                for (int k = 0; k < number.Length; k++)
                {
                    for (int j = 0; j < number.Length; j++)
                    {
                        if (k != j && number[k] == number[j])
                        {
                            noRepeats &= false;
                        }
                    }
                }
                if (noRepeats)
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }

        private void CalculateAndSaveBullsAndCows(string playerGuess, string botNumber, ref int bulls, ref int cows)
        {

            for (int i = 0; i < playerGuess.Length; i++)
            {
                for (int k = 0; k < botNumber.Length; k++)
                {
                    if (i == k && playerGuess[i] == botNumber[k]) bulls++; //break;
                    else if (i != k && playerGuess[i] == botNumber[k]) cows++; //break;                
                }
            }
        }

        private void CheckForWin(int bulls)
        {
            if (bulls == 4)
            {
                MessageBox.Show("You win!");

                ReturnStartView();
            }
        }
      
        private void PresentResultFromGuess(string guess, int bulls, int cows, ref Point location)
        {
            Player_sGuess g = new Player_sGuess(guess, bulls, cows);
            g.Location = location;
            location = new Point(location.X, location.Y + 25);
            playerGuessesPnl.Controls.Add(g);
        }

        private void ReturnStartView()
        {
            savedLocationForPlayersGuesses = new Point(0, 0);
            savedLocationForBotsGuesses = new Point(0, 0);
            playerGuessesPnl.Controls.Clear();
            botGuessesPnl.Controls.Clear();
            playerNumberTxtBox.Text = "";
            playerNumberTxtBox.ReadOnly = false;
            botNumberTxtBox.Text = "????";
            botNumberTxtBox.ReadOnly = true;
            guessTxtBox.ReadOnly = true;
            forfaitBtn.Enabled = false;
            newGameBtn.Enabled = true;
            guessBtn.Enabled = false;
            stateBtn.Enabled = false;
        }

        private void MakeBotsGuess(List<int> options, ref Point location)
        {
            stateBtn.Enabled = true;
            guessBtn.Enabled = false;

            Bot_sGuess g = new Bot_sGuess(options);
            g.Location = location;
            location = new Point(location.X, location.Y + 25);
            botGuessesPnl.Controls.Add(g);
        }

        private List<int> RefreshPossibleOptions(List<int> oldOptions, int botGuess, int statedBulls, int statedCows)
        {
            List<int> options = oldOptions;

            for (int i = 0; i < options.Count; i++)
            {
                int numbersBulls = 0, numbersCows = 0;
                string number = options[i].ToString();
                string guess = botGuess.ToString();

                for (int k = 0; k < guess.Length; k++)
                {
                    for (int j = 0; j < number.Length; j++)
                    {
                        if (guess[k] == number[j] && k == j) numbersBulls++;
                        else if (guess[k] == number[j] && k != j) numbersCows++;
                    }
                }

                if (!(numbersBulls == statedBulls && numbersCows == statedCows))
                {
                    options.Remove(int.Parse(number));
                }
                
            }

            return options;
        }

    }
}
