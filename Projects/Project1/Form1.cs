// Ryan Mitchell
// COP2551.001
// 8-28-2021
// Four cards are displayed on screen. Clicking on a card will cause a message to display
// showing the name of the card.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class fiveCardHand : Form
    {
        public fiveCardHand()
        {
            InitializeComponent();
        }

        private void cardOne_Click(object sender, EventArgs e) // click event
        {
            MessageBox.Show("The Nine of Spades"); // click action
        }

        private void cardTwo_Click(object sender, EventArgs e) // click event
        {
            MessageBox.Show("The Five of Diamonds"); // click action
        }

        private void cardThree_Click(object sender, EventArgs e) // click event
        {
            MessageBox.Show("The Ten of Hearts"); // click action
        }

        private void cardFour_Click(object sender, EventArgs e) // click event
        {
            MessageBox.Show("The Two of Clubs"); // click action
        }

        private void cardFive_Click(object sender, EventArgs e) // click event
        {
            MessageBox.Show("The Queen of Diamonds"); // click action
        }
    }
}
