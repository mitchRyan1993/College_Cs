using System;
using System.Windows.Forms;

namespace Project8B
{
    public partial class displayAddressForm : Form
    {

        public displayAddressForm(person check)//accept person from mainForm
        {
            InitializeComponent();

            //create person object and assign mainForm person to it
            person newPerson = new person();
            newPerson = check;

            //display person properties
            titleLbl.Text = newPerson.Name;
            phoneOutput.Text = newPerson.Phone;
            emailOutput.Text = newPerson.Email;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
