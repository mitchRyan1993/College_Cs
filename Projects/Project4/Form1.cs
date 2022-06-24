using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project4
{
    public partial class diceGame : Form
    {
        //create total variables
        int totalScoreP1;
        int totalScoreP2;
        bool gameover;

        public diceGame()
        {
            InitializeComponent();
        }

        private void diceGame_Load(object sender, EventArgs e)
        {
            //disable buttons and fields
            p1Box.Enabled = false;
            p2Box.Enabled = false;
            resetButton.Enabled = false;
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            //enable buttons and fields
            //set blank image
            gameover = false;
            p1Box.Enabled = true;
            startButton.Enabled = false;
            resetButton.Enabled = true;
            p1FirstDie.Image = Image.FromFile("../../Properties/Dice/blank.png");
            p1SecondDie.Image = Image.FromFile("../../Properties/Dice/blank.png");
            p2FirstDie.Image = Image.FromFile("../../Properties/Dice/blank.png");
            p2SecondDie.Image = Image.FromFile("../../Properties/Dice/blank.png");
        }
        private int rollDieOne()//generates random value 1-6
        {
            int roll;
            Random ranNum = new Random();
            roll = ranNum.Next(1, 7);
            return roll;
        }
        private int rollDieTwo(int firstroll)//generates random value 1-6
        {
            int rolltwo;
            Random ranNumtwo = new Random();
            rolltwo = ranNumtwo.Next(0, 1);//needed to clear random or repeat values were produced every time
            rolltwo = ranNumtwo.Next(1, 7);
            return rolltwo;
        }
        private void displayRoundP1(int pointsGained)//display points gained
        {
            p1PointsGainedText.Text = pointsGained.ToString();
        }
        private void displayRoundP2(int pointsGained)//display points gained
        {
            p2PointsGainedText.Text = pointsGained.ToString();
        }
        private void assignImageP1(int first, int second)
        {
            switch (first)//switch setting the die image to the appropriate roll value
            {
                case 1:
                    {
                        p1FirstDie.Image = Image.FromFile("../../Properties/Dice/1Die.bmp");
                        break;
                    }
                case 2:
                    {
                        p1FirstDie.Image = Image.FromFile("../../Properties/Dice/2Die.bmp");
                        break;
                    }
                case 3:
                    {
                        p1FirstDie.Image = Image.FromFile("../../Properties/Dice/3Die.bmp");
                        break;
                    }
                case 4:
                    {
                        p1FirstDie.Image = Image.FromFile("../../Properties/Dice/4Die.bmp");
                        break;
                    }
                case 5:
                    {
                        p1FirstDie.Image = Image.FromFile("../../Properties/Dice/5Die.bmp");
                        break;
                    }
                case 6:
                    {
                        p1FirstDie.Image = Image.FromFile("../../Properties/Dice/6Die.bmp");
                        break;
                    }
            }
            switch (second)//switch setting the die image to the appropriate roll value
            {
                case 1:
                    {
                        p1SecondDie.Image = Image.FromFile("../../Properties/Dice/1Die.bmp");
                        break;
                    }
                case 2:
                    {
                        p1SecondDie.Image = Image.FromFile("../../Properties/Dice/2Die.bmp");
                        break;
                    }
                case 3:
                    {
                        p1SecondDie.Image = Image.FromFile("../../Properties/Dice/3Die.bmp");
                        break;
                    }
                case 4:
                    {
                        p1SecondDie.Image = Image.FromFile("../../Properties/Dice/4Die.bmp");
                        break;
                    }
                case 5:
                    {
                        p1SecondDie.Image = Image.FromFile("../../Properties/Dice/5Die.bmp");
                        break;
                    }
                case 6:
                    {
                        p1SecondDie.Image = Image.FromFile("../../Properties/Dice/6Die.bmp");
                        break;
                    }
            }
        }
        private void assignImageP2(int first, int second)
        {
            switch (first)//switch setting the die image to the appropriate roll value
            {
                case 1:
                    {
                        p2FirstDie.Image = Image.FromFile("../../Properties/Dice/1Die.bmp");
                        break;
                    }
                case 2:
                    {
                        p2FirstDie.Image = Image.FromFile("../../Properties/Dice/2Die.bmp");
                        break;
                    }
                case 3:
                    {
                        p2FirstDie.Image = Image.FromFile("../../Properties/Dice/3Die.bmp");
                        break;
                    }
                case 4:
                    {
                        p2FirstDie.Image = Image.FromFile("../../Properties/Dice/4Die.bmp");
                        break;
                    }
                case 5:
                    {
                        p2FirstDie.Image = Image.FromFile("../../Properties/Dice/5Die.bmp");
                        break;
                    }
                case 6:
                    {
                        p2FirstDie.Image = Image.FromFile("../../Properties/Dice/6Die.bmp");
                        break;
                    }
            }
            switch (second)//switch setting the die image to the appropriate roll value
            {
                case 1:
                    {
                        p2SecondDie.Image = Image.FromFile("../../Properties/Dice/1Die.bmp");
                        break;
                    }
                case 2:
                    {
                        p2SecondDie.Image = Image.FromFile("../../Properties/Dice/2Die.bmp");
                        break;
                    }
                case 3:
                    {
                        p2SecondDie.Image = Image.FromFile("../../Properties/Dice/3Die.bmp");
                        break;
                    }
                case 4:
                    {
                        p2SecondDie.Image = Image.FromFile("../../Properties/Dice/4Die.bmp");
                        break;
                    }
                case 5:
                    {
                        p2SecondDie.Image = Image.FromFile("../../Properties/Dice/5Die.bmp");
                        break;
                    }
                case 6:
                    {
                        p2SecondDie.Image = Image.FromFile("../../Properties/Dice/6Die.bmp");
                        break;
                    }
            }
        }
        private void p1Wins()
        {
            //display fireworks, disable roll
            p1RollButton.Enabled = false;
            p1FirstDie.Image = Image.FromFile("../../Properties/Dice/fireworks.png");
            p1SecondDie.Image = Image.FromFile("../../Properties/Dice/fireworks.png");
            p2FirstDie.Image = Image.FromFile("../../Properties/Dice/fireworks.png");
            p2SecondDie.Image = Image.FromFile("../../Properties/Dice/fireworks.png");
            MessageBox.Show("Player 1 Wins!");
        }
        private void p2Wins()
        {
            //display fireworks, disable roll
            p2RollButton.Enabled = false;
            p2FirstDie.Image = Image.FromFile("../../Properties/Dice/fireworks.png");
            p2SecondDie.Image = Image.FromFile("../../Properties/Dice/fireworks.png");
            p1FirstDie.Image = Image.FromFile("../../Properties/Dice/fireworks.png");
            p1SecondDie.Image = Image.FromFile("../../Properties/Dice/fireworks.png");
            MessageBox.Show("Player 2 Wins!");
        }
        private void p1RollButton_Click(object sender, EventArgs e)
        {
            //variables created
            int firstDie;
            int secondDie;
            int thisRound;

            //clears opposing side for a cleaner look
            p2FirstDie.Image = Image.FromFile("../../Properties/Dice/blank.png");
            p2SecondDie.Image = Image.FromFile("../../Properties/Dice/blank.png");

            //rolls
            firstDie = rollDieOne();
            secondDie = rollDieTwo(firstDie);

            //calculate this round value and assign die
            thisRound = firstDie + secondDie;
            displayRoundP1(thisRound);
            assignImageP1(firstDie, secondDie);

            //add to total
            totalScoreP1 = totalScoreP1 + thisRound;
            p1TotalPointsText.Text = totalScoreP1.ToString();

            //check for winner
            if (totalScoreP1 >= 50)
            {
                gameover = true;
                p1Wins();
            }
            //check for double
            if(gameover == false && firstDie != secondDie)
            {
                p1Box.Enabled = false;
                p2Box.Enabled = true;
            }


        }

        private void p2RollButton_Click(object sender, EventArgs e)
        {
            //variables created
            int firstDie;
            int secondDie;
            int thisRound;

            //clears opposing side for a cleaner look
            p1FirstDie.Image = Image.FromFile("../../Properties/Dice/blank.png");
            p1SecondDie.Image = Image.FromFile("../../Properties/Dice/blank.png");

            //rolls
            firstDie = rollDieOne();
            secondDie = rollDieTwo(firstDie);

            //calculate this round value and assign die
            thisRound = firstDie + secondDie;
            displayRoundP2(thisRound);
            assignImageP2(firstDie, secondDie);

            //add to total
            totalScoreP2 = totalScoreP2 + thisRound;
            p2TotalScoreText.Text = totalScoreP2.ToString();

            //check for winner
            if (totalScoreP2 >= 50)
            {
                gameover = true;
                p2Wins();
            }

            //check for double
            if (gameover == false && firstDie != secondDie)
            {
                p2Box.Enabled = false;
                p1Box.Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //reset total values, clear all boxes and labels
            gameover = false;
            totalScoreP1 = 0;
            totalScoreP2 = 0;
            p1TotalPointsText.Clear();
            p2TotalScoreText.Clear();
            p1PointsGainedText.Clear();
            p2PointsGainedText.Clear();
            p1RollButton.Enabled = true;
            p2RollButton.Enabled = true;
            p2Box.Enabled = false;
            p1Box.Enabled = true;
            p1FirstDie.Image = Image.FromFile("../../Properties/Dice/blank.png");
            p1SecondDie.Image = Image.FromFile("../../Properties/Dice/blank.png");
            p2FirstDie.Image = Image.FromFile("../../Properties/Dice/blank.png");
            p2SecondDie.Image = Image.FromFile("../../Properties/Dice/blank.png");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit game
            this.Close();
        }
    }
}
