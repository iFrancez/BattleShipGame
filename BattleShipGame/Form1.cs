using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace BattleShipGame
{
    public partial class Form1 : Form
    {

        List<Button> playerPositionButtons; 
        List<Button> enemyPositionButtons; 

        Random rand = new Random(); 


        int totalShips = 3; 
        int round = 10; 
        int playerScore; 
        int enemyScore; 




        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void EnemyPlayTimerEvent(object sender, EventArgs e)
        {
            if (playerPositionButtons.Count > 0 && round > 0)
            {
                round -= 1;

                txtRounds.Text = "Round: " + round;

                int index = rand.Next(playerPositionButtons.Count);

                if ((string)playerPositionButtons[index].Tag == "playerShip")
                {
                    playerPositionButtons[index].BackgroundImage = Properties.Resources.fireIcon;
                    enemyMove.Text = playerPositionButtons[index].Text;
                    playerPositionButtons[index].Enabled = false;
                    playerPositionButtons[index].BackColor = Color.DarkBlue;
                    playerPositionButtons.RemoveAt(index);
                    enemyScore += 1;
                    txtEnemy.Text = enemyScore.ToString();
                    EnemyPlayTimer.Stop();
                }
                else
                {
                    playerPositionButtons[index].BackgroundImage = Properties.Resources.missIcon;
                    enemyMove.Text = playerPositionButtons[index].Text;
                    playerPositionButtons[index].Enabled = false;
                    playerPositionButtons[index].BackColor = Color.DarkBlue;
                    playerPositionButtons.RemoveAt(index);
                    EnemyPlayTimer.Stop();
                }
            }

            if (round < 1 || enemyScore > 2 || playerScore > 2)
            {

                if (playerScore > enemyScore)
                {
                    MessageBox.Show("Chúc mừng bạn đã thắng!!","Chiến thắng");
                    RestartGame();
                }
                else if (enemyScore > playerScore)
                {
                    MessageBox.Show("Bạn đã thua kẻ địch đã thắng!","Thua cuộc");
                    RestartGame();
                }
                else if (enemyScore == playerScore)
                {
                    MessageBox.Show("Không có ai thắng.","Hoà");
                    RestartGame();
                }
            }
        }

        private void AttackButtonEvent(object sender, EventArgs e)
        {

            if (EnemyLocationListBox.Text != "")
            {

                var attackPosition = EnemyLocationListBox.Text.ToLower();

                int index = enemyPositionButtons.FindIndex(a => a.Name == attackPosition);

                if (enemyPositionButtons[index].Enabled && round > 0)
                {
                    round -= 1;
                    txtRounds.Text = "Round: " + round;


                    if ((string)enemyPositionButtons[index].Tag == "enemyShip")
                    {

                        enemyPositionButtons[index].Enabled = false;
                        enemyPositionButtons[index].BackgroundImage = Properties.Resources.fireIcon;
                        enemyPositionButtons[index].BackColor = Color.DarkBlue;
                        playerScore += 1;
                        txtPlayer.Text = playerScore.ToString();
                        EnemyPlayTimer.Start();

                    }
                    else
                    {
                        enemyPositionButtons[index].Enabled = false;
                        enemyPositionButtons[index].BackgroundImage = Properties.Resources.missIcon;
                        enemyPositionButtons[index].BackColor = Color.DarkBlue;
                        EnemyPlayTimer.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Trước tiên, hãy chọn một vị trí từ menu thả xuống", "Information");
            }
        }

        private void PlayerPositionButtonsEvent(object sender, EventArgs e)
        {

            if (totalShips > 0)
            {
                var button = (Button)sender;
                button.Enabled = false;
                button.Tag = "playerShip";
                button.BackColor = Color.Orange;
                totalShips -= 1;
            }

            if (totalShips == 0)
            {
                btnAttack.Enabled = true;
                btnAttack.BackColor = Color.Red;
                btnAttack.ForeColor = Color.White;

                txtHelp.Text = "2) Bây giờ chọn vị trí tấn công từ trình đơn thả xuống";
            }
        }


        private void RestartGame()
        {

            playerPositionButtons = new List<Button> { w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4 };
            enemyPositionButtons = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };

            EnemyLocationListBox.Items.Clear(); 

            EnemyLocationListBox.Text = null;

            txtHelp.Text = "1) Nhấp vào ba vị trí con thuyền khác nhau để bắt đầu!";


            for (int i = 0; i < enemyPositionButtons.Count; i++)
            {
                enemyPositionButtons[i].Enabled = true;
                enemyPositionButtons[i].Tag = null;
                enemyPositionButtons[i].BackColor = Color.White;
                enemyPositionButtons[i].BackgroundImage = null;
                EnemyLocationListBox.Items.Add(enemyPositionButtons[i].Text);
            }

            for (int i = 0; i < playerPositionButtons.Count; i++)
            {
                playerPositionButtons[i].Enabled = true;
                playerPositionButtons[i].Tag = null;
                playerPositionButtons[i].BackColor = Color.White;
                playerPositionButtons[i].BackgroundImage = null;
            }

            playerScore = 0; 
            enemyScore = 0;
            round = 10;
            totalShips = 3;

            txtPlayer.Text = playerScore.ToString();
            txtEnemy.Text = enemyScore.ToString();
            enemyMove.Text = "A1"; 

            btnAttack.Enabled = false;

            enemyLocationPicker();
        }

        private void enemyLocationPicker()
        {

            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(enemyPositionButtons.Count); 

                if (enemyPositionButtons[index].Enabled == true && (string)enemyPositionButtons[index].Tag == null)
                {
                    enemyPositionButtons[index].Tag = "enemyShip";

                    Debug.WriteLine("Enemy Position: " + enemyPositionButtons[index].Text);
                }
                else
                {
                    index = rand.Next(enemyPositionButtons.Count);
                }
            }
        }
    }
}
