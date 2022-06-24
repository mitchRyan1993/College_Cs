using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace Project8A
{

    public partial class MainForm : Form
    {
        //open source file. create a generic list to read from source. create a generic list of students
        StreamReader namesFile = new StreamReader("../../Properties/Names.txt");
        List<string> inputList = new List<string>();
        List<student> nameDOB = new List<student>();

        public MainForm()
        {
            InitializeComponent();
            
            //create list of students and years
            while(!namesFile.EndOfStream)
            {
                string nameDate = namesFile.ReadLine();
                inputList.Add(nameDate);
            }

            //send list to listbox
            populateLB(inputList);

            //break list into student objects and assign values as properties
            studentObjects(inputList);
        }
        private void populateLB(List<string> namesList)
        {
            //display names and years in listbox
            namesList.Sort();
            for(int y = 0; y < namesList.Count; y++)
            {
                outputList.Items.Add(namesList.ElementAt(y));
            }
        }

        private void studentObjects(List<string> studentList)
        {
            //create student object. set names and years
            for(int x = 0; x < studentList.Count; x++)
            {
                string fullNameDob = studentList.ElementAt(x);
                //since the last 4 are the year I use this as a placeholder. this was done to try substrings
                int z = (fullNameDob.Length)-4;

                student newKid = new student();
                newKid.Name = fullNameDob.Substring(0, (z-1));//I know tokenizing is probably better, but I wanted to experiment
                newKid.Year = fullNameDob.Substring(z, 4);

                //add to the list of students
                nameDOB.Add(newKid);
            }
        }

        private void checkList(int requested)
        {
            //cast to string for comparison
            string request = requested.ToString();
            bool found = false;

            for(int x = 0; x < nameDOB.Count; x++)
            {
                //check student at place in list for matching year
                student oldKid = nameDOB[x];
                if(oldKid.Year == request)
                {
                    found = true;
                    nameInfoList.Items.Add(oldKid.Name);
                }
            }
            //if no students found
            if(found == false)
            {
                nameInfoList.Items.Add("No Students Found");
            }
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            int requestYear;
            nameInfoList.Items.Clear();

            //parse input as integer
            int.TryParse(yearInputText.Text, out requestYear);
            {
                checkList(requestYear);
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear boxes
            yearInputText.Clear();
            nameInfoList.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close
            this.Close();
        }
    }
}
