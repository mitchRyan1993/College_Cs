using System;
using System.Drawing;
using System.Windows.Forms;


namespace SpaceGame
{
    public partial class Planet1 : Form
    {
        Ship playerShip1 = new Ship();
        public Planet1(Ship playerShip)
        {
            InitializeComponent();
            playerShip1 = playerShip;            
            main();
            MessageBox.Show("The message is complex but you are confident you can handle it. " +
                "You do have access to the shiny new I-Unscrambler, but the thing is mostly useless and will charge you " +
                "about 10 gold to basically just randomize the input. Probably best to solve it yourself.");
            playerGoldOutput.Text = playerShip1.Money.ToString();
            button1.Visible = false;
        }
      
        public int main()
        {
            placeNumbers();
            return 0;
        }

        void placeNumbers()
        {
            Control[,] Cells = new Control[4, 4] {
                {pictureBox00,pictureBox01,pictureBox02,pictureBox03},
                {pictureBox10,pictureBox11,pictureBox12,pictureBox13 },
                {pictureBox20,pictureBox21,pictureBox22,pictureBox23 },
                {pictureBox30,pictureBox31,pictureBox32,pictureBox33 } };

            int[] numbers = new int[16];
            int randomLoc;
            int temp;
            Random rand = new Random();

            for (int i = 0; i < 16; i++)
            {
                numbers[i] = i;
            }

            for (int i = 0; i < 16; i++)
            {
                randomLoc = rand.Next(1,16);
                
                temp = numbers[i];
                numbers[i] = numbers[randomLoc];
                numbers[randomLoc] = temp;
            }
            int j = 0;
            for (int rows = 0; rows < 4; rows++)
            {
                for (int cols = 0; cols < 4; cols++)
                {
                    PictureBox picture = (PictureBox)Cells[rows, cols];
                    
                    if (numbers[j] != 0)
                    { 
                        picture.Load("..\\..\\Resources\\" + numbers[j] + ".png");
                        j++;
                    }

                    //Cells[rows, cols] = numbers[j];
                    else
                    {
                        picture.Load("..\\..\\Resources\\16.png");
                        j++;
                    }
                     
                }
            }
        }

        void doClick(int row, int col)
        {
            Control[,] Cells = new Control[4, 4] {
                {pictureBox00,pictureBox01,pictureBox02,pictureBox03},
                {pictureBox10,pictureBox11,pictureBox12,pictureBox13 },
                {pictureBox20,pictureBox21,pictureBox22,pictureBox23 },
                {pictureBox30,pictureBox31,pictureBox32,pictureBox33 } };

            int top = row - 1;
            int bottom = row + 1;
            int left = col - 1;
            int right = col + 1;
            PictureBox TopPic = pictureBoxEhh;
            PictureBox RightPic = pictureBoxEhh;
            PictureBox LeftPic = pictureBoxEhh;
            PictureBox BottomPic = pictureBoxEhh;
            if (top == -1)
            { }
            else
            {
                TopPic = (PictureBox)Cells[top, col];
            }
            if (bottom == 4)
            { }
            else
            {
                
                BottomPic = (PictureBox)Cells[bottom, col];
            }
            if (left == -1)
            { }
            else
            {
                LeftPic = (PictureBox)Cells[row, left];
            }
            if (right == 4)
            { }
            else
            {
                RightPic = (PictureBox)Cells[row, right];
            }



            
            //bool swapped = false;
            if (top != -1 && TopPic.ImageLocation == "..\\..\\Resources\\16.png")
            {
                swap((PictureBox)Cells[row, col], (PictureBox)Cells[top, col]);
            }
            else if (right != 4 && RightPic.ImageLocation == "..\\..\\Resources\\16.png")
            {
                swap((PictureBox)Cells[row,col], (PictureBox)Cells[row,right]);
            }
            else if (bottom != 4 && BottomPic.ImageLocation == "..\\..\\Resources\\16.png")
            {
                swap((PictureBox)Cells[row,col], (PictureBox)Cells[bottom,col]);
            }
            else if (left != -1 && LeftPic.ImageLocation == "..\\..\\Resources\\16.png")
            {
                swap((PictureBox)Cells[row,col], (PictureBox)Cells[row,left]);
            }
            else
            {
                //MessageBox.Show("Illegal Move");
            }
            
            CheckWinner();
        }
        void swap(PictureBox firstCell, PictureBox secondCell)
        {
            //swapped = true;
            string SecondCellPath = secondCell.ImageLocation;
            secondCell.Load(firstCell.ImageLocation) ;
            firstCell.Load(SecondCellPath);
        }

        public void ChangePicture(PictureBox picture)
        {
            picture.Image = Image.FromFile("..\\..\\Resources\\1.png");
        }

        void CheckWinner()
        {
            
            Control[,] Cells = new Control[4, 4] {
                {pictureBox00,pictureBox01,pictureBox02,pictureBox03},
                {pictureBox10,pictureBox11,pictureBox12,pictureBox13 },
                {pictureBox20,pictureBox21,pictureBox22,pictureBox23 },
                {pictureBox30,pictureBox31,pictureBox32,pictureBox33 } };

            
            int i = 0;
            int p = 1;
                for(int j = 0; j < 4; j++)
                {
                    for(int k = 0; k < 4; k++)
                    {
                        PictureBox CheckPictureBox = (PictureBox)Cells[k, j];
                    

                    if (CheckPictureBox.ImageLocation == "..\\..\\Resources\\" + p + ".png")
                        {
                        

                        i++;
                        }
                    p++;
                    //Console.WriteLine("I is; " + i);



                    }
                
                }
            
            
            if (i >= 15)
                {
                MessageBox.Show("Success! The message has been decyphered!");
                playerShip1.planet1Result = true;
                this.Close();
                }
            
        }

        private void pictureBox00_Click(object sender, EventArgs e)
        {

            doClick(0, 0);
        }
        private void pictureBox01_Click(object sender, EventArgs e)
        {
            doClick(0, 1);
        }
        private void pictureBox02_Click(object sender, EventArgs e)
        {
            doClick(0, 2);
        }

        private void pictureBox03_Click(object sender, EventArgs e)
        {
            doClick(0, 3);
        }


        private void pictureBox10_Click(object sender, EventArgs e)
        {

            doClick(1, 0);
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            doClick(1, 1);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            doClick(1, 2);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            doClick(1, 3);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            doClick(2, 0);
        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            doClick(2, 1);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            doClick(2, 2);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            doClick(2, 3);
        }


        private void pictureBox30_Click(object sender, EventArgs e)
        {
            doClick(3, 0);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            doClick(3, 1);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            doClick(3, 2);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            doClick(3, 3);
        }

        private void pictureBoxEhh_Click(object sender, EventArgs e)
        {
            
            

        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            if (playerShip1.Money >= 10)
            {
                playerShip1.Money -= 10;
                playerGoldOutput.Text = playerShip1.Money.ToString();
                placeNumbers();
            }
            else { MessageBox.Show("You do not have enough money"); button1.Visible = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mentally exhausted you collapse onto the I-Unscrambler. You accidentally press a button and the " +
                "machine finally does its job and unscrambles the message.");
            playerShip1.planet1Result = true;
            this.Close();
        }
    }
    

}


