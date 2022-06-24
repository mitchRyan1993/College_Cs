using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Planet3 : Form
    {
        Ship playerShip3 = new Ship();
        int riddleCounter = 0;
        public Planet3(Ship playerShip)
        {
            InitializeComponent();
            playerShip3 = playerShip;
            moneyOutputLabel.Text = playerShip3.Money.ToString();
        }


        public void btnSubmit_Click(object sender, EventArgs e)
        {
            string riddle;
            riddle = txtBoxRiddle.Text.ToLower();

            if (riddleCounter == 0) 
            {
                if (riddle == "umbrella")
                {
                    MessageBox.Show("That is correct!");
                    riddleCounter = 1;
                    txtBoxRiddle.Clear();
                    //Load riddle #2
                    lblRiddle.Text = "What get's bigger as you take away from it?";
                }
                else if (riddle == "an umbrella")
                {
                    MessageBox.Show("That is correct!");
                    riddleCounter = 1;
                    txtBoxRiddle.Clear();
                    //Load riddle #2
                    lblRiddle.Text = "What get's bigger as you take away from it?";
                }
                else if (riddle == "a umbrella")
                {
                    MessageBox.Show("That is correct!");
                    riddleCounter = 1;
                    txtBoxRiddle.Clear();
                    //Load riddle #2
                    lblRiddle.Text = "What get's bigger as you take away from it?";
                }
                else
                {
                    txtBoxRiddle.Clear();
                }
            }

            if (riddleCounter == 1)
            {
                if (riddle == "hole")
                {
                    MessageBox.Show("That is correct!");
                    riddleCounter = 2;
                    txtBoxRiddle.Clear();
                    //Load riddle #3
                    lblRiddle.Text = "I am not alive, but I grow. I don't have lungs but I need air.\n Water kills me. What am I?";
                }
                else if (riddle == "a hole")
                {
                    MessageBox.Show("That is correct!");
                    riddleCounter = 2;
                    txtBoxRiddle.Clear();
                    //Load riddle #3
                    lblRiddle.Text = "I am not alive, but I grow. I don't have lungs but I need air.\n Water kills me. What am I?";
                }
                else if (riddle == "pit")
                {
                    MessageBox.Show("That is correct!");
                    riddleCounter = 2;
                    txtBoxRiddle.Clear();
                    //Load riddle #3
                    lblRiddle.Text = "I am not alive, but I grow. I don't have lungs but I need air.\n Water kills me. What am I?";
                }
                else if (riddle == "a pit")
                {
                    MessageBox.Show("That is correct!");
                    riddleCounter = 2;
                    txtBoxRiddle.Clear();
                    //Load riddle #3
                    lblRiddle.Text = "I am not alive, but I grow. I don't have lungs but I need air.\n Water kills me. What am I?";
                }
                else if (riddle == "trench")
                {
                    MessageBox.Show("That is correct!");
                    riddleCounter = 2;
                    txtBoxRiddle.Clear();
                    //Load riddle #3
                    lblRiddle.Text = "I am not alive, but I grow. I don't have lungs but I need air.\n Water kills me. What am I?";
                }
                else if (riddle == "a trench")
                {
                    MessageBox.Show("That is correct!");
                    riddleCounter = 2;
                    txtBoxRiddle.Clear();
                    //Load riddle #3
                    lblRiddle.Text = "I am not alive, but I grow. I don't have lungs but I need air. Water kills me. What am I?";
                }
                else
                {
                    txtBoxRiddle.Clear();
                }
            }
            if (riddleCounter == 2)
            {
                if (riddle == "fire")
                {
                    MessageBox.Show("That is correct!");
                    MessageBox.Show("Excellent, you have proven your worth to me. \n I will tell you what you wish to know.");
                    riddleCounter = 3;
                    txtBoxRiddle.Clear();
                    //All Riddles are Completed
                    //Load Home Page
                    youWin();
                }
                else if (riddle == "a fire")
                {
                    MessageBox.Show("That is correct!");
                    MessageBox.Show("Excellent, you have proven your worth to me. \n I will tell you what you wish to know.");
                    riddleCounter = 3;
                    txtBoxRiddle.Clear();
                    //All Riddles are Completed
                    //Load Home Page
                    youWin();    
                }
                else
                {
                    txtBoxRiddle.Clear();
                }
            }
        }

        private void youWin()
        {
            playerShip3.Money += 50;
            playerShip3.planet3Result = true;
            this.Close();
        }
        private void btnHint_Click(object sender, EventArgs e)
        {
            if (playerShip3.Money >= 10)
            {
                if (riddleCounter == 0)
                {
                    MessageBox.Show("It starts with the letter 'U'");
                    playerShip3.Money -= 10;
                }
                if (riddleCounter == 1)
                {
                    MessageBox.Show("If it gets big enough, you can fall in.");
                    playerShip3.Money -= 10;
                }
                if (riddleCounter == 2)
                {
                    MessageBox.Show("I can keep you warm.");
                    playerShip3.Money -= 10;
                }
                moneyOutputLabel.Text = playerShip3.Money.ToString();
            }
            else { MessageBox.Show("You do not have enough money."); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
