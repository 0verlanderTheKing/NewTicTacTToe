using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        private const int O = 0;
        private const int X = 1;
        private const int Nothing = -1;
        private int wins = 0;
        private int losses = 0;
        private int ties = 0;
        private readonly int[,] board = new int[3, 3];
        private readonly int[,] preferredMoves =
        {
            { 1, 1 },{ 0, 0 },{ 0, 2 },{ 2, 0 },{ 2, 2 },{ 0, 1 },{ 1, 0 },{ 1, 2 },{ 2, 1 }
        };

        private bool gameOver = false;
        private bool playerTurn = true;
        private bool turnWait = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {     
            StartNewGame();
            UpdateStats();
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {
        }

        private Label CurrentState(int row, int column)
        {
            if (row == 0 && column == 0)
                return topLeftLabel;
            if (row == 0 && column == 1)
                return topMiddleLabel;
            if (row == 0 && column == 2)
                return topRightLabel;
            if (row == 1 && column == 0)
                return middleLeftLabel;
            if (row == 1 && column == 1)
                return centerLabel;
            if (row == 1 && column == 2)
                return middleRightLabel;
            if (row == 2 && column == 0)
                return bottomLeftLabel;
            if (row == 2 && column == 1)
                return bottomCenterLabel;

            return bottomRightLabel;
        }

        private void StartNewGame(bool askForRandomFirstTurn = false)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    board[row, column] = Nothing;
                    Label label = CurrentState(row, column);
                    label.Text = string.Empty;
                }
            }

            gameOver = false;
            turnWait = askForRandomFirstTurn;
            playerTurn = !askForRandomFirstTurn;
            randomFirstTurnButton.Visible = askForRandomFirstTurn;

            if (askForRandomFirstTurn)
            {
                SetBoardEnabled(false);
                resultLabel.Text = "Click Randomize First Turn.";
            }
            else
            {
                SetBoardEnabled(true);
                resultLabel.Text = "Your turn! You are X.";
            }
        }

        private void SetBoardEnabled(bool enabled)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    CurrentState(row, column).Enabled = enabled && board[row, column] == Nothing;
                }
            }
        }

        private void EndGame(int winner)
        {
            gameOver = true;
            playerTurn = false;
            turnWait = false;
            randomFirstTurnButton.Visible = false;

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    CurrentState(row, column).Enabled = false;
                }
            }

            if (winner == X)
            {
                wins = wins + 1;
                resultLabel.Text = "You won!";
            }
            else if (winner == O)
            {
                losses = losses + 1;
                resultLabel.Text = "The computer won!";
            }
            else
            {
                ties = ties + 1;
                resultLabel.Text = "It was a tie!";
            }

            UpdateStats();
        }

        private void MakeMove(int row, int column, int player)
        {
            board[row, column] = player;
            CurrentState(row, column).Text = player == X ? "X" : "O";
            CurrentState(row, column).Enabled = false;
        }

        private bool HasOpenSquares()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (board[row, column] == Nothing)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void computer()
        {
            if (gameOver || !HasOpenSquares())
            {
                return;
            }

            int bestRow;
            int bestColumn;
            FindBestMove(out bestRow, out bestColumn);
            MakeMove(bestRow, bestColumn, O);

            int winner = CheckWinner();
            if (winner != Nothing)
            {
                EndGame(winner);
                return;
            }

            if (!HasOpenSquares())
            {
                EndGame(Nothing);
                return;
            }

            playerTurn = true;
            SetBoardEnabled(true);
            resultLabel.Text = "Your turn. You are X!";
        }

        private void FindBestMove(out int bestRow, out int bestColumn)
        {
            int bestScore = int.MinValue;
            bestRow = -1;
            bestColumn = -1;

            for (int i = 0; i < preferredMoves.GetLength(0); i++)
            {
                int row = preferredMoves[i, 0];
                int column = preferredMoves[i, 1];

                if (board[row, column] != Nothing)
                {
                    continue;
                }

                board[row, column] = O;
                int score = Minimax(false);
                board[row, column] = Nothing;

                if (score > bestScore)
                {
                    bestScore = score;
                    bestRow = row;
                    bestColumn = column;
                }
            }

            if (bestRow != -1)
            {
                return;
            }

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (board[row, column] == Nothing)
                    {
                        bestRow = row;
                        bestColumn = column;
                        return;
                    }
                }
            }
        }

        private int Minimax(bool isComputerTurn)
        {
            int winner = CheckWinner();
            if (winner == O)
            {
                return 1;
            }

            if (winner == X)
            {
                return -1;
            }

            if (!HasOpenSquares())
            {
                return 0;
            }

            if (isComputerTurn)
            {
                int bestScore = int.MinValue;

                for (int i = 0; i < preferredMoves.GetLength(0); i++)
                {
                    int row = preferredMoves[i, 0];
                    int column = preferredMoves[i, 1];

                    if (board[row, column] != Nothing)
                    {
                        continue;
                    }

                    board[row, column] = O;
                    int score = Minimax(false);
                    board[row, column] = Nothing;

                    if (score > bestScore)
                    {
                        bestScore = score;
                    }
                }

                return bestScore;
            }

            int worstScore = int.MaxValue;

            for (int i = 0; i < preferredMoves.GetLength(0); i++)
            {
                int row = preferredMoves[i, 0];
                int column = preferredMoves[i, 1];

                if (board[row, column] != Nothing)
                {
                    continue;
                }

                board[row, column] = X;
                int score = Minimax(true);
                board[row, column] = Nothing;

                if (score < worstScore)
                {
                    worstScore = score;
                }
            }

            return worstScore;
        }

        private int CheckWinner()
        {
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] != Nothing && board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                {
                    return board[row, 0];
                }
            }

            for (int column = 0; column < 3; column++)
            {
                if (board[0, column] != Nothing && board[0, column] == board[1, column] && board[1, column] == board[2, column])
                {
                    return board[0, column];
                }
            }

            if (board[0, 0] != Nothing && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[0, 0];
            }

            if (board[0, 2] != Nothing && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return board[0, 2];
            }

            return Nothing;
        }

        private void UpdateStats()
        {
            winsLabel.Text = wins.ToString();
            lossesLabel.Text = losses.ToString();
            tiesLabel.Text = ties.ToString();
        }

        private void squareLabel_Click(object sender, EventArgs e)
        {
            if (gameOver || !playerTurn || turnWait)
            {
                return;
            }

            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.Tag == null)
            {
                return;
            }

            string[] position = clickedLabel.Tag.ToString().Split(',');
            int row = int.Parse(position[0]);
            int column = int.Parse(position[1]);

            if (board[row, column] != Nothing)
            {
                return;
            }

            MakeMove(row, column, X);
            playerTurn = false;
            SetBoardEnabled(false);

            int winner = CheckWinner();
            if (winner != Nothing)
            {
                EndGame(winner);
                return;
            }

            if (!HasOpenSquares())
            {
                EndGame(Nothing);
                return;
            }

            
            computer();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            StartNewGame(true);
        }

        private void randomFirstTurnButton_Click(object sender, EventArgs e)
        {
            turnWait = false;
            randomFirstTurnButton.Visible = false;

            bool userStarts = new Random().Next(2) == 0;

            if (userStarts)
            {
                playerTurn = true;
                SetBoardEnabled(true);
                resultLabel.Text = "You go first! You are X.";
            }
            else
            {
                playerTurn = false;
                resultLabel.Text = "Computer goes first.";
                computer();
            }
        }
        private void lossesLabel_Click(object sender, EventArgs e)
        {
        }

        private void scoreReset_Click(object sender, EventArgs e)
        {
            if (wins == 0 && ties == 0 && losses == 0)
            {
                MessageBox.Show ("You can't reset a score of 0!");
            }
            else
            {
                wins = wins - wins;
                losses = losses - losses;
                ties = ties - ties;
                winsLabel.Text = wins.ToString();
                lossesLabel.Text = losses.ToString();
                tiesLabel.Text = ties.ToString();

            }

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
