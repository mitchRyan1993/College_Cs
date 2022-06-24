using System;
using System.Windows.Forms;

namespace Project3
{
    public partial class convertForm : Form
    {
        public convertForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) // Close the application
        {
            this.Close(); 
        }

        private void clearButton_Click(object sender, EventArgs e) // Clear all inputs
        {
            inputText.Clear();
            inputList.ClearSelected();
            outputList.ClearSelected();
            outputText.Clear();
        }

        private void submitButton_Click(object sender, EventArgs e) // Submit input
        {
            try // try input
            {
                const int inchyards = 36; // constants
                const int inchfoot = 12;
                const int footyards = 3;

                double initialNum = double.Parse(inputText.Text); // try input
                double outputNum = 0;

                bool in_inches = false, // listbox conditions
                     in_feet = false,
                     in_yards = false,
                     out_inches = false,
                     out_feet = false,
                     out_yards = false;

                int input_case = inputList.SelectedIndex; // switch to set input units
                switch (input_case)
                {
                    case 0:
                        {
                            in_inches = true;
                            break;
                        }
                    case 1:
                        {
                            in_feet = true;
                            break;
                        }
                    case 2:
                        {
                            in_yards = true;
                            break;
                        }
                }
                int output_case = outputList.SelectedIndex; // switch to set output units
                switch (output_case)
                {
                    case 0:
                        {
                            out_inches = true;
                            break;
                        }
                    case 1:
                        {
                            out_feet = true;
                            break;
                        }
                    case 2:
                        {
                            out_yards = true;
                            break;
                        }
                }

                if(in_inches == true) // nested checks for conversion
                {
                    if(out_inches == true) // same value in-out causes error
                    {
                        MessageBox.Show("Please choose different input and output units",
                    "Select Different Units", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if(out_feet == true)
                    {
                        outputNum = initialNum / inchfoot;
                    }
                    if(out_yards == true)
                    {
                        outputNum = initialNum / inchyards;
                    }
                }
                if(in_feet == true)
                {
                    if (out_inches == true)
                    {
                        outputNum = initialNum * inchfoot;
                    }
                    if (out_feet == true)
                    {
                        MessageBox.Show("Please choose different input and output units",
                    "Select Different Units", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (out_yards == true)
                    {
                        outputNum = initialNum / footyards;
                    }
                }
                if(in_yards == true)
                {
                    if (out_inches == true)
                    {
                        outputNum = initialNum * inchyards;
                    }
                    if (out_feet == true)
                    {
                        outputNum = initialNum * footyards;
                    }
                    if (out_yards == true)
                    {
                        MessageBox.Show("Please choose different input and output units",
                    "Select Different Units", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                outputText.Text = outputNum.ToString(); // output to text box

            }

            catch // if input is invalid
            {
                MessageBox.Show("Please enter an integer or decimal",
                "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
