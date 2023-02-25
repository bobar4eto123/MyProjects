using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeral_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> inBinary = new List<int>(), inOctal = new List<int>(), inDecimal = new List<int>();
        List<string> hexaLetters = new List<string>() { "A", "B", "C", "D", "E", "F" };
        List<string> inHexadecimal = new List<string>();
        int entryNumber = 0;
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void entryTextBox_TextChanged(object sender, EventArgs e)
        {
            inBinary.Clear();
            inOctal.Clear();
            inDecimal.Clear();
            inHexadecimal.Clear();
            binaryTextBox.Text = string.Empty;
            octalTextBox.Text = string.Empty;
            decimalTextBox.Text = string.Empty;
            hexadecimalTextBox.Text = string.Empty;

            bool NaN = false;

            if (!hexadecimalRadioButton.Checked)
            {
                try
                {
                    entryNumber = int.Parse(entryTextBox.Text);
                }
                catch
                {
                    NaN = true;
                }
            }  
            
            if (!string.IsNullOrEmpty(entryTextBox.Text) && !NaN && entryNumber != 0)
            {
                if (decimalRadioButton.Checked)
                {
                    ConvertNums(inBinary, 2, binaryTextBox);
                    ConvertNums(inOctal, 8, octalTextBox);
                    decimalTextBox.Text = entryNumber.ToString();
                    DecToHex();
                }

                else if (binaryRadioButton.Checked)
                {
                    for (int i = 0; i < entryTextBox.Text.Length; i++)
                    {
                        if (entryTextBox.Text.ToCharArray()[i] != '0' && entryTextBox.Text.ToCharArray()[i] != '1')
                        {
                            return;
                        }
                    }

                    BinOrOctalToDecimal(entryTextBox.Text.ToCharArray(), inBinary, 2);

                    binaryTextBox.Text = entryTextBox.Text;
                    ConvertNums(inOctal, 8, octalTextBox);
                    decimalTextBox.Text = entryNumber.ToString();
                    DecToHex();
                }

                else if (octalRadioButton.Checked)
                {
                    if (entryTextBox.Text.ToCharArray().Contains('8') || entryTextBox.Text.ToCharArray().Contains('9') )
                    {
                        return;
                    }

                    BinOrOctalToDecimal(entryTextBox.Text.ToCharArray(), inOctal, 8);

                    ConvertNums(inBinary, 2, binaryTextBox);
                    octalTextBox.Text = entryTextBox.Text;
                    decimalTextBox.Text = entryNumber.ToString();
                    DecToHex();
                }
            }

            if (hexadecimalRadioButton.Checked)
            {
                if (!string.IsNullOrEmpty(entryTextBox.Text))
                {
                    int result = 0;
                    inHexadecimal = ConvertToStringList( entryTextBox.Text.ToUpper().ToList() );         

                    inHexadecimal.Reverse();                  

                    for (int i = 0; i < inHexadecimal.Count; i++)
                    {
                        switch (inHexadecimal[i])
                        {
                            case "A":
                                inHexadecimal[i] = "10";
                                break;
                            case "B":
                                inHexadecimal[i] = "11";
                                break;
                            case "C":
                                inHexadecimal[i] = "12";
                                break;
                            case "D":
                                inHexadecimal[i] = "13";
                                break;
                            case "E":
                                inHexadecimal[i] = "14";
                                break;
                            case "F":
                                inHexadecimal[i] = "15";
                                break;
                        }
                    }

                    try
                    {
                        for (int i = 0; i < inHexadecimal.Count; i++)
                        {
                            result += int.Parse(inHexadecimal[i]) * (int)Math.Pow(16, (int)i);
                        }
                    }
                    catch (Exception)
                    {
                        return;
                    }                    

                    entryNumber = result;

                    if (entryNumber == 0)
                    {
                        return;
                    }

                    ConvertNums(inBinary, 2, binaryTextBox);
                    ConvertNums(inOctal, 8, octalTextBox);
                    decimalTextBox.Text = entryNumber.ToString();
                    hexadecimalTextBox.Text = entryTextBox.Text.ToUpper();
                }
            }
        }

        private void ConvertNums(List<int> digits, int baseNumber, TextBox textBox)
        {
            int num = entryNumber;

            while (num != 0)
            {
                digits.Add(num % baseNumber);
                num /= baseNumber;
            }

            digits.Reverse();

            textBox.Text = string.Join("", digits);
        }

        private void DecToHex()
        {
            List<int> inHexadecimal2 = new List<int>();

            while (entryNumber >= 16)
            {
                inHexadecimal2.Add(entryNumber % 16);
                entryNumber /= 16;
            }

            inHexadecimal2.Add(entryNumber);

            for (int i = 0; i < inHexadecimal2.Count; i++)
            {
                int position;

                inHexadecimal.Add(inHexadecimal2[i].ToString());

                if (inHexadecimal2[i] > 9)
                {
                    position = inHexadecimal2[i] - 10;
                    inHexadecimal[i] = hexaLetters[position];
                }
            }

            inHexadecimal.Reverse();

            hexadecimalTextBox.Text = string.Join("", inHexadecimal);
        }

        private void BinOrOctalToDecimal(char[] array, List<int> list, int baseNumber)
        {
            int result = 0;

            foreach (char item in array)
            {
                list.Add(int.Parse(item.ToString()));
            }
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                result += list[i] * (int)Math.Pow(baseNumber, (int)i);
            }

            entryNumber = result;
        }

        private List<string> ConvertToStringList(List<char> chars)
        {
            List<string> output = new List<string>();
            foreach (char item in chars)
            {
                output.Add(item.ToString());
            }
            return output;
        }
    }
}
