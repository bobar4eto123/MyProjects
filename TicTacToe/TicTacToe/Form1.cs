using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool turn = true;
        int row1, row2, row3, col1, col2, col3, diag1, diag2;

        private void button1_Click(object sender, EventArgs e)
        {
            Clickk(button1, ref row1, ref col1, ref diag1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clickk(button2, ref row1, ref col2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clickk(button3, ref row1, ref col3, ref diag2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clickk(button4, ref row2, ref col1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clickk(button5, ref row2, ref col2, ref diag1, ref diag2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clickk(button6, ref row2, ref col3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clickk(button7, ref row3, ref col1, ref diag2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clickk(button8, ref row3, ref col2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clickk(button9, ref row3, ref col3, ref diag1);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            labelPlayer.Text = "Current Player: 1";
            turn = true;
            row1 = 0; row2 = 0; row3 = 0; col1 = 0; col2 = 0; col3 = 0; diag1 = 0; diag2 = 0;
        }

        private void Clickk(Button button, ref int row, ref int col, ref int diag)
        {
            if (button.Text == "")
            {
                if (turn)
                {
                    button.Text = "X";
                    labelPlayer.Text = "Current Player: " + 2;
                    row += 1;
                    col += 1;
                    diag += 1;
                }
                else
                {
                    button.Text = "O";
                    labelPlayer.Text = "Current Player: " + 1;
                    row += 4;
                    col += 4;
                    diag += 4;
                }
                turn = !turn;
            }
            Check();
        }

        private void Clickk(Button button, ref int row, ref int col, ref int diag, ref int diag1)
        {
            if (button.Text == "")
            {
                if (turn)
                {
                    button.Text = "X";
                    labelPlayer.Text = "Current Player: " + 2;
                    row += 1;
                    col += 1;
                    diag += 1;
                    diag1 += 1;
                }
                else
                {
                    button.Text = "O";
                    labelPlayer.Text = "Current Player: " + 1;
                    row += 4;
                    col += 4;
                    diag += 4;
                    diag1 += 4;
                }
                turn = !turn;
            }
            Check();
        }

        private void Clickk(Button button, ref int row, ref int col)
        {
            if (button.Text == "")
            {
                if (turn)
                {
                    button.Text = "X";
                    labelPlayer.Text = "Current Player: " + 2;
                    row += 1;
                    col += 1;
                }
                else
                {
                    button.Text = "O";
                    labelPlayer.Text = "Current Player: " + 1;
                    row += 4;
                    col += 4;
                }
                turn = !turn;
            }
            Check();
        }

        private void Check()
        {
            if (row1 == 3 || row2 == 3 || row3 == 3 || col1 == 3 || col2 == 3 || col3 == 3 || diag1 == 3 || diag2 == 3)
            {
                MessageBox.Show("X is the winner!");
                clearButton_Click(new object(), new EventArgs());
            }
            else if (row1 == 12 || row2 == 12 || row3 == 12 || col1 == 12 || col2 == 12 || col3 == 12 || diag1 == 12 || diag2 == 12)
            {
                MessageBox.Show("O is the winner!");
                clearButton_Click(new object(), new EventArgs());
            }
            else if(button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("No winner!");
                clearButton_Click(new object(), new EventArgs());
            }
            
        }
    }
}