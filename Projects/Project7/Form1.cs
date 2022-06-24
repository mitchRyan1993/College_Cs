using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project7
{
    public partial class MainForm : Form
    {
        //variables and instantiating random class
        decimal bet = 0;
        decimal won = 0;
        decimal spent = 0;
        Random randNum = new Random();

        public MainForm()
        {
            InitializeComponent();
            betText.Text = bet.ToString("c");
        }

        private void addOneDollar_Click(object sender, EventArgs e)//add $1 to bet
        {
            bet += 1;
            betText.Text = bet.ToString("c");
        }
        
        private void addFiveDollars_Click(object sender, EventArgs e)//add $5 to bet
        {
            bet += 5;
            betText.Text = bet.ToString("c");
        }

        private void addTenDollars_Click(object sender, EventArgs e)//add $10 to bet
        {
            bet += 10;
            betText.Text = bet.ToString("c");
        }

        private void addTwentyDollars_Click(object sender, EventArgs e)//add $20 to bet
        {
            bet += 20;
            betText.Text = bet.ToString("c");
        }

        private void addFortyDollars_Click(object sender, EventArgs e)//add $40 to bet
        {
            bet += 40;
            betText.Text = bet.ToString("c");
        }

        private void addSixtyDollars_Click(object sender, EventArgs e)//add $60 to bet
        {
            bet += 60;
            betText.Text = bet.ToString("c");
        }
        private int genRand()//generate random number 1-10
        {
            int rand;
            rand = randNum.Next(1, 11);
            return rand;
        }
        private void slotSpin(decimal moneyIn)//get values for each slot
        {
            int slotOne = genRand();
            setImageOne(slotOne);// set image
            int slotTwo = genRand();
            setImageTwo(slotTwo);// set image
            int slotThree = genRand();
            setImageThree(slotThree);// set image

            compareSlots(slotOne,slotTwo,slotThree, moneyIn);//send to compare
        }
        private void setImageOne(int imgNum)//set image for slot
        {
            switch(imgNum)
            {
                case 1:
                    {
                        firstIMG.Image = Image.FromFile("../../Properties/Apple.bmp");
                        break;
                    }
                case 2:
                    {
                        firstIMG.Image = Image.FromFile("../../Properties/Banana.bmp");
                        break;
                    }
                case 3:
                    {
                        firstIMG.Image = Image.FromFile("../../Properties/Cherries.bmp");
                        break;
                    }
                case 4:
                    {
                        firstIMG.Image = Image.FromFile("../../Properties/Grapes.bmp");
                        break;
                    }
                case 5:
                    {
                        firstIMG.Image = Image.FromFile("../../Properties/Lemon.bmp");
                        break;
                    }
                case 6:
                    {
                        firstIMG.Image = Image.FromFile("../../Properties/Lime.bmp");
                        break;
                    }
                case 7:
                    {
                        firstIMG.Image = Image.FromFile("../../Properties/Orange.bmp");
                        break;
                    }
                case 8:
                    {
                        firstIMG.Image = Image.FromFile("../../Properties/Pear.bmp");
                        break;
                    }
                case 9:
                    {
                        firstIMG.Image = Image.FromFile("../../Properties/Strawberry.bmp");
                        break;
                    }
                case 10:
                    {
                        firstIMG.Image = Image.FromFile("../../Properties/Watermelon.bmp");
                        break;
                    }
            }
        }
        private void setImageTwo(int imgNum)//set image for slot
        {
            switch (imgNum)
            {
                case 1:
                    {
                        secondIMG.Image = Image.FromFile("../../Properties/Apple.bmp");
                        break;
                    }
                case 2:
                    {
                        secondIMG.Image = Image.FromFile("../../Properties/Banana.bmp");
                        break;
                    }
                case 3:
                    {
                        secondIMG.Image = Image.FromFile("../../Properties/Cherries.bmp");
                        break;
                    }
                case 4:
                    {
                        secondIMG.Image = Image.FromFile("../../Properties/Grapes.bmp");
                        break;
                    }
                case 5:
                    {
                        secondIMG.Image = Image.FromFile("../../Properties/Lemon.bmp");
                        break;
                    }
                case 6:
                    {
                        secondIMG.Image = Image.FromFile("../../Properties/Lime.bmp");
                        break;
                    }
                case 7:
                    {
                        secondIMG.Image = Image.FromFile("../../Properties/Orange.bmp");
                        break;
                    }
                case 8:
                    {
                        secondIMG.Image = Image.FromFile("../../Properties/Pear.bmp");
                        break;
                    }
                case 9:
                    {
                        secondIMG.Image = Image.FromFile("../../Properties/Strawberry.bmp");
                        break;
                    }
                case 10:
                    {
                        secondIMG.Image = Image.FromFile("../../Properties/Watermelon.bmp");
                        break;
                    }
            }
        }
        private void setImageThree(int imgNum)//set image for slot
        {
            switch (imgNum)
            {
                case 1:
                    {
                        thirdIMG.Image = Image.FromFile("../../Properties/Apple.bmp");
                        break;
                    }
                case 2:
                    {
                        thirdIMG.Image = Image.FromFile("../../Properties/Banana.bmp");
                        break;
                    }
                case 3:
                    {
                        thirdIMG.Image = Image.FromFile("../../Properties/Cherries.bmp");
                        break;
                    }
                case 4:
                    {
                        thirdIMG.Image = Image.FromFile("../../Properties/Grapes.bmp");
                        break;
                    }
                case 5:
                    {
                        thirdIMG.Image = Image.FromFile("../../Properties/Lemon.bmp");
                        break;
                    }
                case 6:
                    {
                        thirdIMG.Image = Image.FromFile("../../Properties/Lime.bmp");
                        break;
                    }
                case 7:
                    {
                        thirdIMG.Image = Image.FromFile("../../Properties/Orange.bmp");
                        break;
                    }
                case 8:
                    {
                        thirdIMG.Image = Image.FromFile("../../Properties/Pear.bmp");
                        break;
                    }
                case 9:
                    {
                        thirdIMG.Image = Image.FromFile("../../Properties/Strawberry.bmp");
                        break;
                    }
                case 10:
                    {
                        thirdIMG.Image = Image.FromFile("../../Properties/Watermelon.bmp");
                        break;
                    }
            }
        }
        private void compareSlots(int first, int second, int third, decimal moneyIn)//compare slots and add matches
        {
            bool oneMatch = false;
            bool twoMatch = false;


            //make comparisons
            if (first == second)
            {
                oneMatch = true;
                if (first == third)
                {
                    twoMatch = true;
                }
            }
            if ((first == third) && (oneMatch == false))
            {
                oneMatch = true;
            }
            if ((second == third) && (oneMatch == false))
            {
                oneMatch = true;
            }

            //add matches
            int matches = 0;
            if (oneMatch == true)
            {
                matches += 1;
            }
            if(twoMatch == true)
            {
                matches += 1;
            }
            results(matches, moneyIn);//send to results
        }
        private void results(int matches, decimal moneyIn)//display money won
        {
            decimal thisWin = 0.00m;
            if (matches == 2)//multiply winnings
            {
                thisWin += (moneyIn * 3);
            }
            if (matches == 1)//multiply winnings
            {
                thisWin += (moneyIn * 2);
            }

            if(matches > 0)//display winnings
            {
                won += thisWin;
                MessageBox.Show(String.Format("Congratulations! You've won {0}!", thisWin.ToString("c")));
            }
            else
            {
                MessageBox.Show("Better luck next time! You've won $0.");
            }
        }
        private void spinBttn_Click(object sender, EventArgs e)
        {
            string insertMoney = betText.Text;
            if(insertMoney[0] == '$')//check for $ and remove
            {
                insertMoney = insertMoney.Remove(0, 1);
            }
            if (decimal.TryParse(insertMoney, out bet))//cast to decimal and call slotSpin
            {
                spent += bet;
                slotSpin(bet);
            }
            else //check input and reject
            { 
                MessageBox.Show("Invalid input. Please enter an amount in the currency format.");
                bet = 0;
                betText.Text = bet.ToString("c");
            }
        }

        private void clearBttn_Click(object sender, EventArgs e)//clear
        {
            bet = 0;
            betText.Text = bet.ToString("c");
        }

        private void exitBttn_Click(object sender, EventArgs e)//display winnings/losings and close
        {
            MessageBox.Show(String.Format("Thank you for playing! You won {0} and spent {1}",won.ToString("c"),spent.ToString("c")));
            this.Close();
        }
    }
}
