using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;


namespace Project8B
{
    public partial class mainForm : Form
    {
        //list to hold person entities created
        List<person> personList = new List<person>();

        public mainForm()
        {
            InitializeComponent();
            setStage();//update listbox data and person list
            
        }
        private void setStage()
        {
            //open file and new list of strings
            StreamReader addBook = new StreamReader("../../Properties/addressBook.txt");
            List<string> addresses = new List<string>();

            listBuilder(addresses, addBook);//builds list of strings from input file
            personList.Clear();//clear any items in person list
            assignProp(addresses);
            displayNames(personList);
            addBook.Close();
        }
        private List<string> listBuilder(List<string> addresses, StreamReader addBook)
        {

            while (!addBook.EndOfStream)
            {
                addresses.Add(addBook.ReadLine());
            }

            return addresses;
        }
        private void assignProp(List<string> addresses)
        {
            //for each item in string list...
            for (int y = 0; y < addresses.Count; y++)
            {
                //create a person object
                person entity = new person();

                //tokenize the string into 3 strings
                char[] delim = { ';' };
                string information = addresses[y];
                string[] tokens = information.Split(delim);

                //if string is not empty, assign tokens to properties appropriately
                if (tokens[0] != "")
                {
                    entity.Name = tokens[0];
                    entity.Email = tokens[1];
                    entity.Phone = tokens[2];

                    //add person to the list
                    personList.Add(entity);
                }
            }
        }
        private void displayNames(List<person> personList)
        {
            //clear old names list
            nameViewBox.Items.Clear();

            //loop person name added to listbox
            for (int x = 0; x < personList.Count; x++)
            {
                person displEntity = new person();
                displEntity = personList.ElementAt(x);
                nameViewBox.Items.Add(displEntity.Name);
            }
        }

        public void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //selected index saved
                int selectedName = nameViewBox.SelectedIndex;

                //create person object
                person check = new person();
                
                //assign person on list at index to person object
                check = personList.ElementAt(selectedName);

                //create form
                displayAddressForm display = new displayAddressForm(check);

                //display form
                display.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Please click on a name");
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            person addPerson = new person();
            addAddressForm newEntry = new addAddressForm();
            newEntry.ShowDialog();
            setStage();//called to update listbox data and person list
            
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            nameViewBox.ClearSelected();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
