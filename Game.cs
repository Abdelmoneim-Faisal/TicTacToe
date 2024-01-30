using Microsoft.Data.SqlClient;

namespace TicTacToe
{
    public partial class Game : Form
    {
        public string pl1N { get; set; }
        public string pl2N { get; set; }
        public string pl1Sign { get; set; }
        public string pl2Sign { get; set; }
        public int pl1Sc { get; set; }
        public int pl2Sc { get; set; }

        private Label[,] labelArray;
        public int turn { get; set; }

        SqlConnection con;
        public Game()
        {
            InitializeComponent();
            InitializeLabelArray();
            boardDisabled();
            con = new SqlConnection("Server=.;Database=tictactoe;Trusted_Connection=True;TrustServerCertificate=True");
        }
        private void boardDisabled()
        {
            int rows = 3;
            int columns = 3;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    string panelName = $"panel{row * columns + col}";
                    Panel panel = Controls.Find(panelName, true).First() as Panel;
                    panel.Enabled = false;
                }
            }
        }
        private void InitializeLabelArray()
        {
            int rows = 3;
            int columns = 3;
            labelArray = new Label[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    string labelName = $"pos{row * columns + col}";
                    Label label = Controls.Find(labelName, true).FirstOrDefault() as Label;
                    labelArray[row, col] = label;
                }
            }
        }
        private void Game_Load(object sender, EventArgs e)
        {
            lbl_pl1Name.Text = pl1N;
            lbl_pl2Name.Text = pl2N;
            lbl_pl1Sign.Text = pl1Sign;
            lbl_pl2Sign.Text = pl2Sign;
            setTheBoard();
            if (pl1Sign == "X")
            {
                turn = 1;
            }
            else
            {
                turn = 2;
            }
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            boardDisabled();
            setTheBoard();
            pl1Score.Text = "0";
            pl2Score.Text = "0";
            pl1Sc = int.Parse(pl1Score.Text);
            pl2Sc = int.Parse(pl2Score.Text);
            if (pl1Sign == "X")
            {
                turn = 1;
            }
            else
            {
                turn = 2;
            }
            btn_newGame.Enabled = true;
        }
        private void btn_newGame_Click(object sender, EventArgs e)
        {
            setTheBoard();
            if (changeTurn() == 1)
            {
                turn = 2;
            }
            else
            {
                turn = 1;
            }
            int rows = 3;
            int columns = 3;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    string panelName = $"panel{row * columns + col}";
                    Panel panel = Controls.Find(panelName, true).First() as Panel;
                    panel.Enabled = true;
                    labelArray[row, col].BackColor = Color.White;
                }
            }
            btn_newGame.Enabled = false;
        }

        #region playing
        private int changeTurn()
        {
            if (turn == 1)
            {
                turn = 2;
                return turn;
            }
            else
            {
                turn = 1;
                return turn;
            }
        }
        private void play(int row, int col)
        {
            if (labelArray[row, col].Text == string.Empty)
            {
                if (turn == 1)
                {
                    labelArray[row, col].Text = pl1Sign;
                    checkForWin();
                    changeTurn();
                }
                else
                {
                    labelArray[row, col].Text = pl2Sign;
                    checkForWin();
                    changeTurn();
                }
            }
        }
        private void panel0_Click(object sender, EventArgs e)
        {
            play(0, 0);
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            play(0, 1);
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            play(0, 2);
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            play(1, 0);
        }
        private void panel4_Click(object sender, EventArgs e)
        {
            play(1, 1);
        }
        private void panel5_Click(object sender, EventArgs e)
        {
            play(1, 2);
        }
        private void panel6_Click(object sender, EventArgs e)
        {
            play(2, 0);
        }
        private void panel7_Click(object sender, EventArgs e)
        {
            play(2, 1);
        }
        private void panel8_Click(object sender, EventArgs e)
        {
            play(2, 2);
        }
        #endregion

        #region win, lose and draw
        private void checkForWin()
        {
            bool row = checkForRows();
            bool col = checkForCols();
            bool diag = checkForDiag();
            if (row || col || diag)
            {
                if (turn == 1)
                {
                    MessageBox.Show("Player2 wins!");
                }
                else
                {
                    MessageBox.Show("Player1 wins!");
                }
            }
            bool draw = checkForDraw();
            if (draw)
            {
                if (!row && !col && !diag)
                {
                    MessageBox.Show("It's a draw");
                    boardDisabled();
                    btn_newGame.Enabled = true;
                }

            }
        }
        private bool checkForRows()
        {
            for (int row = 0; row < labelArray.GetLength(0); row++)
            {
                for (int col = 0; col < labelArray.GetLength(1) - 2; col++)
                {
                    if (!string.IsNullOrEmpty(labelArray[row, col].Text) &&
                        labelArray[row, col].Text == labelArray[row, col + 1].Text &&
                        labelArray[row, col + 2].Text == labelArray[row, col].Text)
                    {
                        labelArray[row, col].BackColor = Color.PowderBlue;
                        labelArray[row, col + 1].BackColor = Color.PowderBlue;
                        labelArray[row, col + 2].BackColor = Color.PowderBlue;
                        if (turn == 1)
                        {
                            boardDisabled();
                            updateScore();
                            btn_newGame.Enabled = true;
                            turn = 2;
                            return true;
                        }
                        else
                        {
                            boardDisabled();
                            updateScore();
                            btn_newGame.Enabled = true;
                            turn = 1;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private bool checkForCols()
        {
            for (int col = 0; col < labelArray.GetLength(1); col++)
            {
                for (int row = 0; row < labelArray.GetLength(0) - 2; row++)
                {
                    if (!string.IsNullOrEmpty(labelArray[row, col].Text) &&
                        labelArray[row, col].Text == labelArray[row + 1, col].Text &&
                        labelArray[row + 2, col].Text == labelArray[row, col].Text)
                    {
                        labelArray[row, col].BackColor = Color.PowderBlue;
                        labelArray[row + 1, col].BackColor = Color.PowderBlue;
                        labelArray[row + 2, col].BackColor = Color.PowderBlue;
                        if (turn == 1)
                        {
                            boardDisabled();
                            updateScore();
                            btn_newGame.Enabled = true;
                            turn = 2;
                            return true;
                        }
                        else
                        {
                            boardDisabled();
                            updateScore();
                            btn_newGame.Enabled = true;
                            turn = 1;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private bool checkForDiag()
        {
            bool leftDig = (!string.IsNullOrEmpty(labelArray[0, 0].Text) &&
               labelArray[0, 0].Text == labelArray[1, 1].Text &&
               labelArray[0, 0].Text == labelArray[2, 2].Text);
            bool rightDig = (!string.IsNullOrEmpty(labelArray[0, 2].Text) &&
               labelArray[0, 2].Text == labelArray[1, 1].Text &&
               labelArray[0, 2].Text == labelArray[2, 0].Text);
            if (leftDig || rightDig)
            {
                if (leftDig)
                {
                    labelArray[0, 0].BackColor = Color.PowderBlue;
                    labelArray[1, 1].BackColor = Color.PowderBlue;
                    labelArray[2, 2].BackColor = Color.PowderBlue;
                }
                else
                {
                    labelArray[0, 2].BackColor = Color.PowderBlue;
                    labelArray[1, 1].BackColor = Color.PowderBlue;
                    labelArray[2, 0].BackColor = Color.PowderBlue;
                }
                if (turn == 1)
                {
                    boardDisabled();
                    updateScore();
                    btn_newGame.Enabled = true;
                    turn = 2;
                    return true;
                }
                else
                {
                    boardDisabled();
                    updateScore();
                    btn_newGame.Enabled = true;
                    turn = 1;
                    return true;
                }
            }
            return false;
        }
        private bool checkForDraw()
        {
            bool isDraw = true;
            for (int row = 0; row < labelArray.GetLength(0); row++)
            {
                for (int col = 0; col < labelArray.GetLength(1); col++)
                {
                    if (string.IsNullOrEmpty(labelArray[row, col].Text))
                    {
                        isDraw = false;
                        break;
                    }
                }
            }
            return isDraw;
        }
        #endregion

        #region handle score
        private void updateScore()
        {
            int pl1NewScore, pl2NewScore;
            if (turn == 1)
            {
                pl1NewScore = int.Parse(pl1Score.Text);
                pl1NewScore++;
                pl1Score.Text = pl1NewScore.ToString();
                pl1Sc = pl1NewScore;
            }
            else if (turn == 2)
            {
                pl2NewScore = int.Parse(pl2Score.Text);
                pl2NewScore++;
                pl2Score.Text = pl2NewScore.ToString();
                pl2Sc = pl2NewScore;
            }
        }
        private void setTheBoard()
        {
            for (int row = 0; row < labelArray.GetLength(0); row++)
            {
                for (int col = 0; col < labelArray.GetLength(1); col++)
                {
                    labelArray[row, col].Text = string.Empty;
                }
            }
        }
        #endregion

        #region save game data

        SqlCommand sqlCommand;
        private void acessDB()
        {
            int rows = 0;
            try
            {
                con.Open();
                rows = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "tic tac toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
            if (rows > 0)
            {
                MessageBox.Show("Data has been added to players table successfully", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                GameScoreForm form = new GameScoreForm();
                form.ShowDialog();
                this.Close();
            }
        }
        private void btn_saveScore_Click(object sender, EventArgs e)
        {
            if (pl1Sign == "X")
            {
                sqlCommand = new SqlCommand($"Insert into GameScore ([plXName],[plXScore],[plOName],[plOScore],[gameDate]) Values ('{pl1N}','{pl1Sc}','{pl2N}','{pl2Sc}',getdate())", con);
                if (pl1Sc == 0 && pl2Sc == 0)
                {
                    MessageBox.Show("No Data");
                }
                else
                {
                    acessDB();
                }
            }
            else
            {
                sqlCommand = new SqlCommand($"Insert into GameScore ([plXName],[plXScore],[plOName],[plOScore],[gameDate]) Values ('{pl2N}','{pl2Sc}','{pl1N}','{pl1Sc}',getdate())", con);
                if (pl1Sc == 0 && pl2Sc == 0)
                {
                    MessageBox.Show("No Data");
                }
                else
                {
                    acessDB();
                }
            }
        }
        #endregion

    }
}