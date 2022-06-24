using System;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Planet4 : Form
    {
        Ship playerShip4 = new Ship();
        public Planet4(Ship playerShip)
        {
            InitializeComponent();
            playerShip4 = playerShip;
            LoadPictures();
            button1.Visible = false;
            moneyOutputLabel.Text = playerShip4.Money.ToString();
        }

        //Makes all squares red, and then randomly selects some to be blue
        void LoadPictures()
        {
            //Makes array of Picture boxes
            Control[,] Cells = new Control[5, 5] {
                {PicBox00,PicBox01,PicBox02,PicBox03,PicBox04},
                {PicBox10,PicBox11,PicBox12,PicBox13,PicBox14},
                {PicBox20,PicBox21,PicBox22,PicBox23,PicBox24},
                {PicBox30,PicBox31,PicBox32,PicBox33,PicBox34},
                {PicBox40,PicBox41,PicBox42,PicBox43,PicBox44},};
            //Makes squares red
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    PictureBox picture = (PictureBox)Cells[i, j];
                    
                    picture.Load("..\\..\\Resources\\RedSquare.png");

                }
            }
            // Randomly makes squares blue
            Random rand = new Random();
            for(int i = 0; i < 10; i++)
            { 
            int RandRow = rand.Next(0,5);
            int RandCol = rand.Next(0, 5);
                PictureBox StartBlue = (PictureBox)Cells[RandCol, RandRow];
                StartBlue.Load("..\\..\\Resources\\BlueSquare.png");
            }

        }

        //Switches color of blocks that are clicked
        void LightSwitch(int row, int col)
        {
            Control[,] Cells = new Control[5, 5] {
                {PicBox00,PicBox01,PicBox02,PicBox03,PicBox04},
                {PicBox10,PicBox11,PicBox12,PicBox13,PicBox14},
                {PicBox20,PicBox21,PicBox22,PicBox23,PicBox24},
                {PicBox30,PicBox31,PicBox32,PicBox33,PicBox34},
                {PicBox40,PicBox41,PicBox42,PicBox43,PicBox44},};

            //Checks edges of the board and doesn't attempt to change squares that would be out of bounds
            int top = row - 1;
            int bottom = row + 1;
            int left = col - 1;
            int right = col + 1;
            PictureBox TopPic = PicBoxPlaceHold;
            PictureBox RightPic = PicBoxPlaceHold;
            PictureBox LeftPic = PicBoxPlaceHold;
            PictureBox BottomPic = PicBoxPlaceHold;
            PictureBox CenterPic = (PictureBox)Cells[row, col];
            if (top != -1)
            { 
                TopPic = (PictureBox)Cells[top, col];
            }
            if (bottom != 5)
            {
                BottomPic = (PictureBox)Cells[bottom, col];
            }
            if (left != -1)
            { 
                LeftPic = (PictureBox)Cells[row, left];
            }
            if (right != 5)
            { 
                RightPic = (PictureBox)Cells[row, right];
            }

            //Switches red to blue, and blue to red on clicked squares.
            if (TopPic.ImageLocation == "..\\..\\Resources\\BlueSquare.png")
            {
                TopPic.Load("..\\..\\Resources\\RedSquare.png");
            }
            else
            {
                TopPic.Load("..\\..\\Resources\\BlueSquare.png");
            }
            if (LeftPic.ImageLocation == "..\\..\\Resources\\BlueSquare.png")
            {
                LeftPic.Load("..\\..\\Resources\\RedSquare.png");
            }
            else
            {
                LeftPic.Load("..\\..\\Resources\\BlueSquare.png");
            }
            if (RightPic.ImageLocation == "..\\..\\Resources\\BlueSquare.png")
            {
                RightPic.Load("..\\..\\Resources\\RedSquare.png");
            }
            else
            {
                RightPic.Load("..\\..\\Resources\\BlueSquare.png");
            }
            if (BottomPic.ImageLocation == "..\\..\\Resources\\BlueSquare.png")
            {
                BottomPic.Load("..\\..\\Resources\\RedSquare.png");
            }
            else
            {
                BottomPic.Load("..\\..\\Resources\\BlueSquare.png");
            }
            if (CenterPic.ImageLocation == "..\\..\\Resources\\BlueSquare.png")
            {
                CenterPic.Load("..\\..\\Resources\\RedSquare.png");
            }
            else
            {
                CenterPic.Load("..\\..\\Resources\\BlueSquare.png");
            }
            CheckWinner();
        }

        //Checks to see if all the tiles are lit up
        void CheckWinner()
        {

            Control[,] Cells = new Control[5, 5] {
                {PicBox00,PicBox01,PicBox02,PicBox03,PicBox04},
                {PicBox10,PicBox11,PicBox12,PicBox13,PicBox14},
                {PicBox20,PicBox21,PicBox22,PicBox23,PicBox24},
                {PicBox30,PicBox31,PicBox32,PicBox33,PicBox34},
                {PicBox40,PicBox41,PicBox42,PicBox43,PicBox44},};


            int i = 1;

            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    PictureBox CheckPictureBox = (PictureBox)Cells[k, j];

                    if (CheckPictureBox.ImageLocation == "..\\..\\Resources\\BlueSquare.png")
                    {
                        i++;
                    }



                    if (i >= 26)
                    {
                        MessageBox.Show("You have won!");
                        playerShip4.planet4Result = true;
                        this.Close();
                    }

                }
            }

        }
        //Click events passing location into the LightSwitch
        private void PicBox00_Click(object sender, EventArgs e)
        {
            LightSwitch(0, 0);
        }

        private void PicBox10_Click(object sender, EventArgs e)
        {
            LightSwitch(1, 0);
        }

        private void PicBox20_Click(object sender, EventArgs e)
        {
            LightSwitch(2, 0);
        }

        private void PicBox30_Click(object sender, EventArgs e)
        {
            LightSwitch(3, 0);
        }

        private void PicBox40_Click(object sender, EventArgs e)
        {
            LightSwitch(4, 0);
        }

        private void PicBox01_Click(object sender, EventArgs e)
        {
            LightSwitch(0, 1);
        }

        private void PicBox11_Click(object sender, EventArgs e)
        {
            LightSwitch(1, 1);
        }

        private void PicBox21_Click(object sender, EventArgs e)
        {
            LightSwitch(2, 1);
        }
        private void PicBox31_Click(object sender, EventArgs e)
        {
            LightSwitch(3, 1);
        }

        private void PicBox41_Click(object sender, EventArgs e)
        {
            LightSwitch(4, 1);
        }

        private void PicBox02_Click(object sender, EventArgs e)
        {
            LightSwitch(0, 2);
        }

        private void PicBox12_Click(object sender, EventArgs e)
        {
            LightSwitch(1, 2);
        }

        private void PicBox22_Click(object sender, EventArgs e)
        {
            LightSwitch(2, 2);
        }

        private void PicBox32_Click(object sender, EventArgs e)
        {
            LightSwitch(3, 2);
        }

        private void PicBox42_Click(object sender, EventArgs e)
        {
            LightSwitch(4, 2);
        }

        private void PicBox03_Click(object sender, EventArgs e)
        {
            LightSwitch(0, 3);
        }

        private void PicBox13_Click(object sender, EventArgs e)
        {
            LightSwitch(1, 3);
        }

        private void PicBox23_Click(object sender, EventArgs e)
        {
            LightSwitch(2, 3);
        }

        private void PicBox33_Click(object sender, EventArgs e)
        {
            LightSwitch(3, 3);
        }

        private void PicBox43_Click(object sender, EventArgs e)
        {
            LightSwitch(4, 3);
        }

        private void PicBox04_Click(object sender, EventArgs e)
        {
            LightSwitch(0, 4);
        }

        private void PicBox14_Click(object sender, EventArgs e)
        {
            LightSwitch(1, 4);
        }

        private void PicBox24_Click(object sender, EventArgs e)
        {
            LightSwitch(2, 4);
        }

        private void PicBox34_Click(object sender, EventArgs e)
        {
            LightSwitch(3, 4);

        }

        private void PicBox44_Click(object sender, EventArgs e)
        {
            LightSwitch(4, 4);
        }

        //Randomizes and resets the board
        private void Reset_Click(object sender, EventArgs e)
        {
            if (playerShip4.Money >= 10)
            {
                
                playerShip4.Money -= 10;
                moneyOutputLabel.Text = playerShip4.Money.ToString();
                LoadPictures(); 
            }
            else { MessageBox.Show("You do not have enough money."); button1.Visible = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Furious at the malfunction you punch the control panel. Suddenly, all the buttons " +
                "turn blue and the malfunction goes away.");
            playerShip4.planet4Result = true;
            this.Close();
        }
    }
}
