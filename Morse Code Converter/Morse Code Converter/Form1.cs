using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Code_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
    private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CovertBTN_Click(object sender, EventArgs e)
        {
            //create a dictionary to hold all values
            Dictionary<char, string> mcode = new Dictionary<char, string>()
            {
                //Morse Code

                {' ' , " "},
                {',' , "--..--"},
                {'.' , ".-.-.-"},
                {'?' , "..--.."},
                {'0' , "-----"},
                {'1' , ".----"},
                {'2' , "..---"},
                {'3' , "...--"},
                {'4' , "....-"},
                {'5' , "....."},
                {'6' , "-...."},
                {'7' , "--..."},
                {'8' , "---.."},
                {'9' , "----."},
                {'A' , ".-"},
                {'B' , "-..."},
                {'C' , "-.-."},
                {'D' , "-.."},
                {'E' , "."},
                {'F' , "..-."},
                {'G' , "--."},
                {'H' , "...."},
                {'I' , ".."},
                {'J' , ".---"},
                {'K' , "-.-"},
                {'L' , ".-.."},
                {'M' , "--"},
                {'N' , "-."},
                {'O' , "---"},
                {'P' , ".--."},
                {'Q' , "--.-"},
                {'R' , ".-."},
                {'S' , "..."},
                {'T' , "-"},
                {'U' , "..-"},
                {'V' , "...-"},
                {'W' , ".--"},
                {'X' , "-..-"},
                {'Y' , "-.--"},
                {'Z' , "--.."},
            };

            //Variable to hold user input
            string UserInput = Input.Text;

            //Convert Input to UpperCase Letters
            UserInput = UserInput.ToUpper();

            //String used to convert user input to morse code
            var StringConvert = new StringBuilder();

            //Check each letter of the user input
            //Ends loop at the end of the UserInput string
            for (int index = 0; index < UserInput.Length; index++)
            {
                var y = UserInput[index];
                string MorseCodeHolder;

                // TryGetValue gets the value associated with the specific key
                // In this case, mCode.TryGetValue converts user input
                // to a variable string ouput, morseHolder.

                if(mcode.TryGetValue(y, out MorseCodeHolder))
                {
                    StringConvert.Append(MorseCodeHolder);
                }
            }

            //print morse code to the output label
            OutputLB.Text = StringConvert.ToString();
        }
    }
}
//Credit goes to: Gabriel codeF7
//His work has helped me understand what I need to do and
//know exactly what each command does.