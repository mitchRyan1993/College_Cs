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
    public partial class Planet5 : Form
    {
        Ship playerShip5 = new Ship();
        int enemyAA = 5;
        bool enemy1 = true;
        bool enemy2 = true;
        bool enemy3 = true;
        bool enemy4 = true;
        bool enemy5 = true;
        Random playerLuck = new Random();
        public Planet5(Ship playerShip)
        {
            InitializeComponent();
            playerShip5 = playerShip;
            enemyBox.Enabled = false;
        }
        private void update()
        {
            durabilityOutputLBL.Text = playerShip5.Durability.ToString();
        }
        private void EnemyTurn()
        {
            int playerNum = 15;
            int enemyNum = playerLuck.Next(0,25);
            if (enemyNum == playerNum)
            {
                playerShip5.Durability -= 20;
                MessageBox.Show("Your ship shakes violently as an enemy attack connects!");
                lastTurnOutputLBL.Text = "Enemy Hit!";
            }
            if(playerShip5.Durability <= 0)
            {
                this.Close();
            }
        }
        private void PlayerTurn(char row, int col)
        {
            if ((row == 'A' && col == 4) && (enemy1 == true))
            {
                A4IMG.Image = Image.FromFile("../../Resources/hit.png");
                MessageBox.Show("A hit! The weapon has been destroyed!");
                enemy1 = false;
                enemyAA -= 1;
                lastTurnOutputLBL.Text = "Hit!";
            }
            else if ((row == 'C' && col == 2) && (enemy2 == true))
            {
                C2IMG.Image = Image.FromFile("../../Resources/hit.png");
                MessageBox.Show("A hit! The weapon has been destroyed!");
                enemy2 = false;
                enemyAA -= 1;
                lastTurnOutputLBL.Text = "Hit!";
            }
            else if ((row == 'D' && col == 7) && (enemy3 == true))
            {
                D7IMG.Image = Image.FromFile("../../Resources/hit.png");
                MessageBox.Show("A hit! The weapon has been destroyed!");
                enemy3 = false;
                enemyAA -= 1;
                lastTurnOutputLBL.Text = "Hit!";
            }
            else if ((row == 'G' && col == 1) && (enemy4 == true))
            {
                G1IMG.Image = Image.FromFile("../../Resources/hit.png");
                enemy4 = false;
                MessageBox.Show("A hit! The weapon has been destroyed!");
                enemyAA -= 1;
                lastTurnOutputLBL.Text = "Hit!";
            }
            else if ((row == 'F' && col == 5) && (enemy5 == true))
            {
                F5IMG.Image = Image.FromFile("../../Resources/hit.png");
                enemy5 = false;
                MessageBox.Show("A hit! The weapon has been destroyed!");
                enemyAA -= 1;
                lastTurnOutputLBL.Text = "Hit!";
            }
            else { Miss(row, col); }
            CheckWin();
            EnemyTurn();
            update();
            
        }
        private void Miss(char row, int col)
        {
            if (row == 'A')
            {
                if(col == 1)
                {
                    MessageBox.Show("You fire and miss.");
                    A1IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 2)
                {
                    MessageBox.Show("You fire and miss.");
                    A2IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 3)
                {
                    MessageBox.Show("You fire and miss.");
                    A3IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 5)
                {
                    MessageBox.Show("You fire and miss.");
                    A5IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 6)
                {
                    MessageBox.Show("You fire and miss.");
                    A6IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 7)
                {
                    MessageBox.Show("You fire and miss.");
                    A7IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
            }
            else if (row == 'B')
            {
                if (col == 1)
                {
                    MessageBox.Show("You fire and miss.");
                    B1IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 2)
                {
                    MessageBox.Show("You fire and miss.");
                    B2IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 3)
                {
                    MessageBox.Show("You fire and miss.");
                    B3IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 4)
                {
                    MessageBox.Show("You fire and miss.");
                    B4IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 5)
                {
                    MessageBox.Show("You fire and miss.");
                    B5IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 6)
                {
                    MessageBox.Show("You fire and miss.");
                    B6IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 7)
                {
                    MessageBox.Show("You fire and miss.");
                    B7IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
            }
            else if (row == 'C')
            {
                if (col == 1)
                {
                    MessageBox.Show("You fire and miss.");
                    C1IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 3)
                {
                    MessageBox.Show("You fire and miss.");
                    C3IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 4)
                {
                    MessageBox.Show("You fire and miss.");
                    C4IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 5)
                {
                    MessageBox.Show("You fire and miss.");
                    C5IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 6)
                {
                    MessageBox.Show("You fire and miss.");
                    C6IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 7)
                {
                    MessageBox.Show("You fire and miss.");
                    C7IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
            }
            else if (row == 'D')
            {
                if (col == 1)
                {
                    MessageBox.Show("You fire and miss.");
                    D1IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 2)
                {
                    MessageBox.Show("You fire and miss.");
                    D2IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 3)
                {
                    MessageBox.Show("You fire and miss.");
                    D3IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 4)
                {
                    MessageBox.Show("You fire and miss.");
                    D4IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 5)
                {
                    MessageBox.Show("You fire and miss.");
                    D5IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 6)
                {
                    MessageBox.Show("You fire and miss.");
                    D6IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
            }
            else if (row == 'E')
            {
                if (col == 1)
                {
                    MessageBox.Show("You fire and miss.");
                    E1IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 2)
                {
                    MessageBox.Show("You fire and miss.");
                    E2IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 3)
                {
                    MessageBox.Show("You fire and miss.");
                    E3IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 4)
                {
                    MessageBox.Show("You fire and miss.");
                    E4IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 5)
                {
                    MessageBox.Show("You fire and miss.");
                    E5IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 6)
                {
                    MessageBox.Show("You fire and miss.");
                    E6IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 7)
                {
                    MessageBox.Show("You fire and miss.");
                    E7IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
            }
            else if (row == 'F')
            {
                if (col == 1)
                {
                    MessageBox.Show("You fire and miss.");
                    F1IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 2)
                {
                    MessageBox.Show("You fire and miss.");
                    F2IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 3)
                {
                    MessageBox.Show("You fire and miss.");
                    F3IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 4)
                {
                    MessageBox.Show("You fire and miss.");
                    F4IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 6)
                {
                    MessageBox.Show("You fire and miss.");
                    F6IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 7)
                {
                    MessageBox.Show("You fire and miss.");
                    F7IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
            }
            else if (row == 'G')
            {
                if (col == 2)
                {
                    MessageBox.Show("You fire and miss.");
                    G2IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 3)
                {
                    MessageBox.Show("You fire and miss.");
                    G3IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 4)
                {
                    MessageBox.Show("You fire and miss.");
                    G4IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 5)
                {
                    MessageBox.Show("You fire and miss.");
                    G5IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 6)
                {
                    MessageBox.Show("You fire and miss.");
                    G6IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
                else if (col == 7)
                {
                    MessageBox.Show("You fire and miss.");
                    G7IMG.Image = Image.FromFile("../../Resources/miss.png");
                    lastTurnOutputLBL.Text = "Miss";
                }
            }
        }
        private void CheckWin()
        {
            if (enemyAA == 0)
            {
                playerShip5.planet5Result = true;
                this.Close();
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            enemyBox.Enabled = true;
            startButton.Enabled = false;
            durabilityOutputLBL.Text = playerShip5.Durability.ToString();
        }
        private char rowSelected()
        {
            char rowChoice;
            if (rowARB.Checked == true)
            {
                rowChoice = 'A';
            }
            else if (rowBRB.Checked == true)
            {
                rowChoice = 'B';
            }
            else if (rowCRB.Checked == true)
            {
                rowChoice = 'C';
            }
            else if (rowDRB.Checked == true)
            {
                rowChoice = 'D';
            }
            else if (rowERB.Checked == true)
            {
                rowChoice = 'E';
            }
            else if (rowFRB.Checked == true)
            {
                rowChoice = 'F';
            }
            else if (rowGRB.Checked == true)
            {
                rowChoice = 'G';
            }
            else
            {
                rowChoice = 'Z';
            }
            return rowChoice;
        }
        private int colSelected()
        {
            int colChoice;
            if (col1RB.Checked == true)
            {
                colChoice = 1;
            }
            else if (col2RB.Checked == true)
            {
                colChoice = 2;
            }
            else if (col3RB.Checked == true)
            {
                colChoice = 3;
            }
            else if (col4RB.Checked == true)
            {
                colChoice = 4;
            }
            else if (col5RB.Checked == true)
            {
                colChoice = 5;
            }
            else if (col6RB.Checked == true)
            {
                colChoice = 6;
            }
            else if (col7RB.Checked == true)
            {
                colChoice = 7;
            }
            else
            {
                colChoice = 0;
            }

            return colChoice;
        }
        private void fireButton_Click(object sender, EventArgs e)
        {
            char rowChoice;
            int colChoice;

            rowChoice = rowSelected();
            colChoice = colSelected();

            //if((rowChoice != 'Z') && (colChoice != 0))
            //{
                PlayerTurn(rowChoice,colChoice);
            //}
        }
    }
}
