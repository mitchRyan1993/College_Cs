using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project6
{
    public partial class MainForm : Form
    {
        public MainForm()// initialize and open file to populate list box
        {
            InitializeComponent();
            openTeamsFile();
        }

        private void openTeamsFile()// open file and send to populate
        {
            StreamReader teamInput = File.OpenText("../../Properties/Teams.txt");
            populateTeams(teamInput);
        }

        private StreamReader openWinnersFile()// open file
        {
            StreamReader winnersInput = File.OpenText("../../Properties/WorldSeries.txt");
            return winnersInput;
        }

        private void populateTeams(StreamReader teamInput)// populate list box
        {
            while(!teamInput.EndOfStream)
            {
                teamBox.Items.Add(teamInput.ReadLine());
            }
        }
        /// <summary>
        /// Step through file to find and count wins. If statement checks selected team
        /// against file contents and adds to wins if the values match
        /// </summary>
        /// <param name="winput"> world series winner file</param>
        /// <param name="teamSelected"> team selected by user</param>
        /// <returns> team selected win count</returns>
        private int checkWins(StreamReader winput, string teamSelected)
        {
            int wins = 0;

            while(!winput.EndOfStream)
            {
                if(winput.ReadLine() == teamSelected)
                {
                    wins++;
                }
            }

            return wins;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //define variables
            int timesWon;
            string teamSelected;

            //open file
            StreamReader winnerFile = openWinnersFile();

            //cast selected item to string and assign to variable
            teamSelected = (string) teamBox.SelectedItem;

            //check times team won
            timesWon = checkWins(winnerFile, teamSelected);

            //display wins
            outputLabel.Visible = true;
            if (timesWon == 1)
            {
                outputLabel.Text = String.Format("The {0} have won the World Series 1 time", teamSelected); 
            }
            else { outputLabel.Text = String.Format("The {0} have won the World Series {1} times", teamSelected, timesWon); }
            
        }

        private void clearButton_Click(object sender, EventArgs e)// clear
        {
            outputLabel.Visible = false;
            teamBox.SelectedItem = false;
        }

        private void exitButton_Click(object sender, EventArgs e)// exit
        {
            this.Close();
        }
    }
}
