using System;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Planet2 : Form
    {
        Ship playerShip2 = new Ship();
        int clickCounter = 0;
        int matchCheck = 0;

        public Planet2(Ship playerShip)
        {
            InitializeComponent();
            playerShip2 = playerShip;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            playerShip2.planet2Result = true;
            this.Close();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            if (matchCheck == 0 && clickCounter == 0)
            {
                pictureBox1.ImageLocation = "..\\..\\Resources\\jackofhearts.jpg";
                MessageBox.Show("Find the match");
            }
            //pictureBox1.ImageLocation = "..\\..\\Resources\\jackofhearts.jpg";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (matchCheck == 0 && clickCounter == 0)//compare picBox1 to picBox2
            {
                pictureBox2.ImageLocation = "..\\..\\Resources\\queenOfHearts.jpg";
                MessageBox.Show("No Match");
                clickCounter = 0;
                pictureBox1.ImageLocation = "..\\..\\Resources\\PlayingCard.jpg";
                pictureBox2.ImageLocation = "..\\..\\Resources\\PlayingCard.jpg";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {       
                pictureBox11.ImageLocation = "..\\..\\Resources\\jackofhearts.jpg";           
        }
    }
}
