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

        

       
    
    
        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Close this form.
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // Declare a dictionary to hold all the values.
            Dictionary<char, String> mCode = new Dictionary<char, String>()
            {
                // Codes
                {' ' , "space"},
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
            // Create a variable to hold user input.
            string textInput = textBoxString.Text;

            // Convert user input to all uppercase.
            textInput = textInput.ToUpper();


            // Building the string to convert from user input to morse code.
            var variablestring = new StringBuilder();

            // A for loop to check each letter of the user textInput.
            // The loop ends at .Length, or the end of the textInput string.
            for (int index = 0; index < textInput.Length; index++)
            {
                var x = textInput[index];
                string morseCodeHolder;

                // TryGetValue gets the value associated with the specific key
                // In this case, mCode.TryGetValue converts user input
                // to a variable string ouput, morseHolder.
               
                if (mCode.TryGetValue(x, out morseCodeHolder))
                {
                    variablestring.Append(morseCodeHolder);
                }
            }
            // Print the new string we converted to the labelOutput textbox.
            labelOutput.Text = variablestring.ToString();




        }
    }
}
