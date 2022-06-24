using System;
using System.Windows.Forms;

namespace classExample
{
    public partial class Automotive : Form
    {
        public Automotive()
        {
            InitializeComponent();
        }

        private int oBox()//add checked boxes in OBox
        {
            int oBoxAdd = 0;

            if (oilCheck.Checked == true)
            {
                oBoxAdd += 26;
            }
            if (lubeCheck.Checked == true)
            {
                oBoxAdd += 18;
            }

            return oBoxAdd;
        }

        private int fBox()//add checked boxes in FBox
        {
            int fBoxAdd = 0;

            if (radCheck.Checked == true)
            {
                fBoxAdd += 30;
            }
            if (transCheck.Checked == true)
            {
                fBoxAdd += 80;
            }

            return fBoxAdd;
        }
        private int mBox()//add checked boxes in MBox
        {
            int mBoxAdd = 0;

            if (inspectCheck.Checked == true)
            {
                mBoxAdd += 15;
            }
            if (mufflerCheck.Checked == true)
            {
                mBoxAdd += 100;
            }
            if (tireCheck.Checked == true)
            {
                mBoxAdd += 20;
            }

            return mBoxAdd;

        }
        private double lBox()//add checked boxes in LBox
        {
            double lBoxAdd = 0;


            if (double.TryParse(laborInput.Text, out lBoxAdd))//parse as double
            {
                if (!(lBoxAdd >= 0))//if value is negative
                {
                    lBoxAdd = lBoxAdd * -1;
                    MessageBox.Show("Labor input cannot be a negative number. It is now positive.");
                    //makes input positive
                }
                return lBoxAdd;
            }
            else
            {
                MessageBox.Show("Labor input must be a positive number");//try failed
                return lBoxAdd;
            }


        }
        private void showOutput(double labor, double parts, double tax, double total)//display outputs
        {
            laborOutput.Text = labor.ToString("c");
            partsOutput.Text = parts.ToString("c");
            taxOutput.Text = tax.ToString("c");
            totalOutput.Text = total.ToString("c");
        }
        private void calcButton_Click(object sender, EventArgs e)//click event
        {

            double partsIn;//variables
            double laborIn;
            double total = 0;
            double tax = 0;

            total += oBox();//call functions
            total += fBox();
            total += mBox();
            
            if (double.TryParse(partsInput.Text, out partsIn))//parts input
            {
                if (!(partsIn >= 0))
                {
                    partsIn = partsIn * -1;
                    MessageBox.Show("Parts input cannot be a negative number. It is now positive.");
                    //makes input positive
                }
                tax = partsIn * 0.06;
                double newParts = partsIn + tax;
                total += newParts;
            }
            else
            {
                MessageBox.Show("Parts input must be a positive number");
            }
            laborIn = lBox();
            total += laborIn;

            showOutput(laborIn,partsIn,tax,total);//call show function
            
        }

        private void clearButton_Click(object sender, EventArgs e)//clear
        {
            oilCheck.Checked = false;
            lubeCheck.Checked = false;
            radCheck.Checked = false;
            transCheck.Checked = false;
            inspectCheck.Checked = false;
            mufflerCheck.Checked = false;
            tireCheck.Checked = false;
            partsInput.Clear();
            laborInput.Clear();
            laborOutput.Clear();
            partsOutput.Clear();
            taxOutput.Clear();
            totalOutput.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)//exit
        {
            this.Close();
        }
    }
}
