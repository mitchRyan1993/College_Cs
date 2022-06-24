using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class PlanetTwo : Form
    {
        Random random = new Random();
        Ship playerShip2 = new Ship();
        List<string> icons = new List<string>()
        {
            "!", "!","N","N",",",",","j","j",
            "b","b","v","v","w","w","z","z"
        };

        Label firstClicked, secondClicked;

        public PlanetTwo(Ship playerShip)
        {
            InitializeComponent();
            AssignIconsToSquares();
            playerShip2 = playerShip;
            MessageBox.Show("Your ship touches down near a large open air market. You approach a vendor with your list of supplies. " +
                "The vendor displays his wares and you begin looking through them for what you need.");
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
                return;

            if (clickedLabel.ForeColor == Color.Black)
                return;

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            CheckForWinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
                timer1.Start();
        }

        private void CheckForWinner()
        {
            Label label;
            for (int i = 0; i <tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }

            MessageBox.Show("You have collected all of the supplies you need. You leave the market well stocked.");
            playerShip2.planet2Result = true;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void AssignIconsToSquares()
        {
            Label label;
            int randomNumber;

            for (int i = 0; i <tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;

                randomNumber = random.Next(0, icons.Count);
                label.Text = icons[randomNumber];

                icons.RemoveAt(randomNumber);
            }
        }
    }
}
