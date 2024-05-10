using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square_Chaser
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(50, 120, 20, 20);
        Rectangle player2 = new Rectangle(200, 295, 20, 20);
        Rectangle whiteSquare = new Rectangle(290, 295, 10, 10);
        Rectangle yellowBoost = new Rectangle(290, 295, 10, 10);

        int player1Score = 0;
        int player2Score = 0;
        int winningScore = 5;

        int player1Speed = 3;
        int player2Speed = 3;
        int boostAmount = 2; // Increase in speed when colliding with yellow boost
        
        //movements
        bool wPressed = false;
        bool sPressed = false;
        bool upPressed = false;
        bool downPressed = false;
        bool aPressed = false;
        bool dPressed = false;
        bool leftPressed = false;
        bool rightPressed = false;


        Random random = new Random();

        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            player1Score = 0;
            player2Score = 0;
            player1.Y = 170;
            player2.Y = 170;
            ResetWhiteSquare();
            ResetYellowBoost();
            gameTimer.Start(); // Start the game timer
        }

        private void ResetWhiteSquare()
        {
            whiteSquare.X = random.Next(20, ClientSize.Width - 20);
            whiteSquare.Y = random.Next(20, ClientSize.Height - 20);
        }

        private void ResetYellowBoost()
        {
            yellowBoost.X = random.Next(20, ClientSize.Width - 20);
            yellowBoost.Y = random.Next(20, ClientSize.Height - 20);
        }



        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
                case Keys.Up:
                    upPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
                case Keys.Left:
                    leftPressed = false;
                    break;
                case Keys.Right:
                    rightPressed = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            MovePlayers();
            CheckCollisions();
            CheckWinCondition();
            Refresh();
        }
        private void MovePlayers()
        {
            if (wPressed && player1.Y > 0)
                player1.Y -= player1Speed;

            if (sPressed && player1.Y < ClientSize.Height - player1.Height)
                player1.Y += player1Speed;

            if (aPressed && player1.X > 0)
                player1.X -= player1Speed;

            if (dPressed && player1.X < ClientSize.Width - player1.Width)
                player1.X += player1Speed;

            if (upPressed && player2.Y > 0)
                player2.Y -= player2Speed;

            if (downPressed && player2.Y < ClientSize.Height - player2.Height)
                player2.Y += player2Speed;

            if (leftPressed && player2.X > 0)
                player2.X -= player2Speed;

            if (rightPressed && player2.X < ClientSize.Width - player2.Width)
                player2.X += player2Speed;
        }

        private void CheckCollisions()
        {
            if (player1.IntersectsWith(whiteSquare))
            {
                player1Score++; // Increment player 1 score
                player1WinLabel.Text = $"{player1Score}"; // Update player 1 win label
                ResetWhiteSquare();
            }

            if (player2.IntersectsWith(whiteSquare))
            {
                player2Score++; // Increment player 2 score
                player2WinLabel.Text = $"{player2Score}"; // Update player 2 win label
                ResetWhiteSquare();
            }

            if (player1.IntersectsWith(yellowBoost))
            {
                player1Speed += boostAmount; // Increase player1 speed
                ResetYellowBoost();
            }

            if (player2.IntersectsWith(yellowBoost))
            {
                player2Speed += boostAmount; // Increase player2 speed
                ResetYellowBoost();
            }
        }

        private void CheckWinCondition()
        {
            if (player1Score >= winningScore)
            {
                player1Score++; // Increment player 1 score
                player1WinLabel.Text = $"{player1Score}"; // Update player 1 win label
                winLabel.Text = "Player 1 Wins!";
                gameTimer.Stop();
            }
            else if (player2Score >= winningScore)
            {
                player2Score++; // Increment player 2 score
                player2WinLabel.Text = $"{player2Score}"; // Update player 2 win label
                winLabel.Text = "Player 2 Wins!";
                gameTimer.Stop();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(redBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, whiteSquare);
            e.Graphics.FillEllipse(yellowBrush, yellowBoost);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
                case Keys.Up:
                    upPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.Left:
                    leftPressed = true;
                    break;
                case Keys.Right:
                    rightPressed = true;
                    break;
            }
        }
    }
}
