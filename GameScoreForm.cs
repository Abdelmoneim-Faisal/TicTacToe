using Microsoft.Data.SqlClient;
using System.Data;

namespace TicTacToe
{
    public partial class GameScoreForm : Form
    {
        SqlConnection con;
        public GameScoreForm()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=tictactoe;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public void show(bool show)
        {
            btn_delete.Visible = show;
        }
        public void GetPlayers()
        {
            SqlCommand cmd = new SqlCommand("SELECT [Id],[plXName],[plXScore],[plOName],[plOScore],[gameDate] FROM [GameScore];", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            dgv_gameScore.AllowUserToAddRows = false;
            dgv_gameScore.DataSource = dt;
        }
        private void GameScoreForm_Load(object sender, EventArgs e)
        {
            GetPlayers();
            show(false);
        }
        
        int curruetR = 0;
        private void dgv_gameScore_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv_gameScore.SelectedRows[0];
            curruetR = (int)row.Cells["Id"].Value;
            show(true);
            dgv_gameScore.Enabled = false;
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"delete from GameScore where ([Id]) = ({curruetR})", con);
            int rows = 0;
            try
            {
                con.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            if (rows > 0)
            {
                MessageBox.Show("Game data has been sucessfully deleted from table", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetPlayers();
            }
            show(false);
            dgv_gameScore.Enabled = true;
            if (dgv_gameScore.Rows.Count == 0)
            {
                MessageBox.Show("No game data available. Closing the form.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void GameScoreForm_MouseDown(object sender, MouseEventArgs e)
        {
            show(false);
            dgv_gameScore.Enabled = true;
        }
    }
}
