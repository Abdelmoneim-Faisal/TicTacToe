namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Game gInst;
        public Form1()
        {
            InitializeComponent();
            gInst = new Game();
        }

        #region choose X or O
        private void rb_pl1X_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pl1X.Checked)
            {
                rb_pl2O.Checked = true;
            }
        }

        private void rb_pl1O_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pl1O.Checked)
            {
                rb_pl2X.Checked = true;
            }
        }

        private void rb_pl2X_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pl2X.Checked)
            {
                rb_pl1O.Checked = true;
            }
        }

        private void rb_pl2O_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pl2O.Checked)
            {
                rb_pl1X.Checked = true;
            }
        }
        #endregion

        #region Setting players data and start game
        private void btn_start_Click(object sender, EventArgs e)
        {
            string pl1 = txt_pl1Name.Text;
            string pl2 = txt_pl2Name.Text;
            string pl1S;
            string pl2S;
            if (pl1 == string.Empty || pl2 == string.Empty)
            {
                MessageBox.Show("Please enter the names of both players", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!rb_pl1X.Checked && !rb_pl1O.Checked)
            {
                MessageBox.Show("Both of you have to select a sign to start the game", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rb_pl1X.Checked)
                {
                    pl1S = rb_pl1X.Text;
                    pl2S = rb_pl2O.Text;
                }
                else
                {
                    pl1S = rb_pl1O.Text;
                    pl2S = rb_pl2X.Text;
                }
                gInst.pl1N = pl1;
                gInst.pl2N = pl2;
                gInst.pl1Sign = pl1S;
                gInst.pl2Sign = pl2S;
                this.Hide();
                gInst.ShowDialog();
                this.Close();
            }
        }
        #endregion
    }
}
