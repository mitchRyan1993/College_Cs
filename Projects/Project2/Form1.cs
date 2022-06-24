using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class paintEstimate : Form
    {
        //constant varaibles
        const int SIZE = 155;
        const int LABOR = 8;
        const int PERHOUR = 20;

        public paintEstimate()
        {
            InitializeComponent();
        }

        private void submitEstimate_Click(object sender, EventArgs e)//click the paint button
        {
            //local variables
            double jobInput, paintInput, paintCost, laborCost, totalCost, gallonsNeeded, laborHours;

            //try to parse the entry
            try
            {
                jobInput = double.Parse(jobSizeInput.Text);
                while (jobInput <= 0)//catches negative or zero input
                {
                    MessageBox.Show("Please enter a number greater than zero.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paintInput = double.Parse(paintCostInput.Text);
                while (paintInput <= 0)//catches negative or zero input
                {
                    MessageBox.Show("Please enter a number greater than zero.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //calculations for variable assignment
                gallonsNeeded = jobInput / SIZE;
                paintCost = gallonsNeeded * paintInput;
                laborHours = gallonsNeeded * LABOR;
                laborCost = laborHours * PERHOUR;
                totalCost = laborCost + paintCost;

                //a way to practice using cast and round to 2 decimal places
                gallonsNeeded = (gallonsNeeded * 100);
                laborHours = (laborHours * 100);
                int roundGallons = (int)(gallonsNeeded);
                int roundHours = (int)(laborHours);
                gallonsNeeded = roundGallons;
                laborHours = roundHours;
                gallonsNeeded = (gallonsNeeded / 100);
                laborHours = (laborHours / 100);

                //output to text boxes
                gallonsOutput.Text = gallonsNeeded.ToString() + " gallons of paint";
                paintTotalOutput.Text = paintCost.ToString("c");
                laborHoursOutput.Text = laborHours.ToString() + " labor hours";
                laborChargeOutput.Text = laborCost.ToString("c");
                totalCostOutput.Text = totalCost.ToString("c");
            }
            //in case of failed parse
            catch
            {
                MessageBox.Show("Please enter an integer or decimal.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void clearInput_Click(object sender, EventArgs e)//clear all and reset focus
        {
            jobSizeInput.Clear();
            paintCostInput.Clear();
            gallonsOutput.Clear();
            paintTotalOutput.Clear();
            laborHoursOutput.Clear();
            laborChargeOutput.Clear();
            totalCostOutput.Clear();

            jobSizeInput.Focus();

        }

        private void exitForm_Click(object sender, EventArgs e)//exit form
        {
            this.Close();
        }
    }
}
