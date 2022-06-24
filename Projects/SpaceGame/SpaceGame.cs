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

    public partial class SpaceGame : Form
    {
        bool planetResult1 = false;
        bool planetResult2 = false;
        bool planetResult3 = false;
        bool planetResult4 = false;

        Ship playerShip = new Ship();
        
        public SpaceGame()
        {
            InitializeComponent();
        }

        private void shipIMG_Click(object sender, EventArgs e)
        {
            //Story element
            MessageBox.Show("Your home has become a place of monotony and boredom. It is no longer what you want so you set out" +
                " in your ship. You receive an incoming message. The signal is scrambled, but it seems to be a description" +
                " of a beautiful planet that the inhabitants call Paradise. You must unscramble the signal to learn more.");
            //Planet 1
            playerShip.Money = 100;
            playerShip.Durability = 100;
            while (planetResult1 == false)
            {
                playerShip.planet1Result = false;
                playerShip.planet2Result = false;
                playerShip.planet3Result = false;
                playerShip.planet4Result = false;
                playerShip.planet5Result = false;
                planetResult2 = false;
                planetResult3 = false;
                planetResult4 = false;

                Planet1 imgSort = new Planet1(playerShip);

                imgSort.ShowDialog();
                if (playerShip.planet1Result == true)
                {
                    planetResult1 = true;
                }
            }

            //Story element
            MessageBox.Show("You have decoded the signal and found it points to a solar system nearby. Realizing you will" +
                " need supplies, you approach a small planet near your coordinates and request clearance to land." +
                " A friendly voice on communications grants landing permission and gives you instructions to the market.");
            //Planet 2
            while (planetResult2 == false)
            {

                playerShip.planet2Result = false;
                playerShip.planet3Result = false;
                playerShip.planet4Result = false;
                playerShip.planet5Result = false;

                PlanetTwo memory = new PlanetTwo(playerShip);

                memory.ShowDialog();
                if (playerShip.planet2Result == true)
                {
                    planetResult2 = true;
                }
            }

            //Story element
            MessageBox.Show("You have your supplies and are on your way to the solar system. After days of travel, you finally approach the planets within." +
                " Realizing you have no idea which planet is the described paradise, you set down on the closest one to ask the locals. Upon landing you meet " +
                "a friendly entity that seems to know the planet you describe. They say to earn their help you will have to answer three riddles correctly.");
            //Planet 3
            while (planetResult3 == false)
            {

                playerShip.planet3Result = false;
                playerShip.planet4Result = false;
                playerShip.planet5Result = false;

                Planet3 riddle = new Planet3(playerShip);

                riddle.ShowDialog();
                if (playerShip.planet3Result == true)
                {
                    planetResult3 = true;
                }
            }

            //Story element
            MessageBox.Show("Finally knowing your destination you leave the planet, excited to start your new life on paradise. A few hours from your destination " +
                "the onboard alarms begin sounding. You must land immediately to discover the problem. You approach a nearby planet and set your ship down. The alarm" +
                " notifies you that the electrical system is malfunctioning and needs to be reset. You begin working, annoyed with the delay but still optimisitic " +
                "about the prospect of paradise.");
            //Planet 4
            while (planetResult4 == false)
            {

                playerShip.planet4Result = false;
                playerShip.planet5Result = false;

                Planet4 lightsOut = new Planet4(playerShip);

                lightsOut.ShowDialog();
                if (playerShip.planet4Result == true)
                {
                    planetResult4 = true;
                }
            }

            //Story element
            MessageBox.Show("Your ship is functional again and you set off. You approach your new home, amazed with the beauty of the planet from afar. Suddenly, " +
                "the automated shields kick on as your ship begins taking fire from the planet. A lucky strike hits your shield generator and takes them down instantly. " +
                "If you are to land you will have to destroy the enemy forces on the planet.");
            //Planet 5
            playerShip.planet5Result = false;

            Planet5 battleship = new Planet5(playerShip);

            battleship.ShowDialog();
            if (playerShip.planet5Result == false)
            {
                MessageBox.Show("You panick and attempt to retreat, but a number of lucky shots hit your ship.");
                playerShip.Durability = 0;
            }
            if (playerShip.Durability <= 0)
            {
                //Story element
                MessageBox.Show("You lost");
                MessageBox.Show("Your ship was destroyed before you could make a landing. You float helplessly through" +
                    " space in your suit, wondering if you will ever be found. Eventually, a small craft picks you up near" +
                    " your home planet. You are returned home unharmed and begin to collect the tools for a new attempt. " +
                    "Eventually, you reconstuct a new ship and are ready to try again.");
                planetResult1 = false;
            }
            if ((playerShip.planet5Result == true) && (playerShip.Durability > 0))
            {
                //Story element
                MessageBox.Show("You win!");
                MessageBox.Show("You destroy the last of the AA guns and approach the planet surface. The area seems to be " +
                    "vacated with the automated defense systems left on. The planet is a paradise with bountiful resources," +
                    " fully automated cities to serve their inhabitants, and an abundance of any food you could hope for. You" +
                    " become the ruler of the vacated city and begin friendly relations with neighboring ones. Your population" +
                    " begins to fill out with people flocking to your benevolent leadership. This truly is paradise.");
                planetResult1 = false;
            }
        }
    }
}
