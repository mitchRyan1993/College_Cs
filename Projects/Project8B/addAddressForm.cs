using System;
using System.Windows.Forms;
using System.IO;

namespace Project8B
{
    public partial class addAddressForm : Form
    {
        public addAddressForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //create person object. populate properties with entered data
            person addPerson = new person();
            string firstName = firstnameText.Text;
            string lastName = lastnameText.Text;
            string name = firstName + " " + lastName;
            addPerson.Name = name;
            addPerson.Phone = phoneText.Text;
            addPerson.Email = emailText.Text;

            write(addPerson);//send person to write()
            this.Close();
        }
        private void write(person entity)
        {
            //open output file. append person data to file
            StreamWriter outputFile;
            outputFile = File.AppendText("../../Properties/addressBook.txt");
            outputFile.Write(entity.Name);
            outputFile.Write(";");
            outputFile.Write(entity.Email);
            outputFile.Write(";");
            outputFile.WriteLine(entity.Phone);
            outputFile.Close();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            firstnameText.Clear();
            lastnameText.Clear();
            phoneText.Clear();
            emailText.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
