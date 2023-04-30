using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace TakeHome_W8
{
    public partial class ShowMatch : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=titi020504;database=premier_league";
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string query = "";
        DataTable dtTeam = new DataTable();
        DataTable dtTanggal= new DataTable();
        DataTable dtHome = new DataTable();
        DataTable dtAway = new DataTable();
        DataTable dtMatch= new DataTable();
        DataTable dtDetail= new DataTable();
        string pilih = "";
        public ShowMatch()
        {
            InitializeComponent();
        }
        private void updateLabel()
        {
            cmb_match.ValueMember = "t1";
            if (cmb_match.SelectedValue != null)
                label_home.Text = cmb_match.SelectedValue.ToString();

            cmb_match.ValueMember = "t2";
            if (cmb_match.SelectedValue != null)
                label_away.Text = cmb_match.SelectedValue.ToString();
            cmb_match.ValueMember = "ID";
        }
        private void ShowMatch_Load(object sender, EventArgs e)
        {
            
            query = "SELECT team_name FROM premier_league.team;";
            sqlConnection = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);


            dtTeam = new DataTable();
            sqlDataAdapter.Fill(dtTeam);

            // Set the team combo box data source and display member
            cmb_team.DataSource = dtTeam;
            cmb_team.DisplayMember = "team_name";
        }

        private void cmb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set up the query to select matches for the selected team
            pilih = cmb_team.Text;
            query = $"SELECT m.match_date as 'tanggal', t1.team_name as 't1', t2.team_name as 't2', m.match_id as 'ID' " +
                    $"FROM team t1, team t2, premier_league.match m " +
                    $"WHERE (t1.team_name='{pilih}' or t2.team_name='{pilih}') AND " +
                    $"t1.team_id=m.team_home AND t2.team_id=m.team_away;";
            sqlConnection = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

          
            dtTanggal = new DataTable();
            sqlDataAdapter.Fill(dtTanggal);


            cmb_match.DataSource = dtTanggal;
            cmb_match.DisplayMember = "tanggal";
            updateLabel();
        }

        private void cmb_match_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set up the query to select team names for the selected match
            query = $"SELECT t1.team_name as 't1', t2.team_name as 't2' " +
                    $"FROM premier_league.match m, team t1, team t2 " +
                    $"WHERE m.team_home = t1.team_id and m.team_away = t2.team_id and " +
                    $"m.match_id = '{cmb_match.SelectedValue.ToString()}';";
            sqlConnection = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

            // Fill the DataTable with team names
            dtMatch = new DataTable();
            sqlDataAdapter.Fill(dtMatch);

            // Update the label
            updateLabel();
        }


        private void btn_info_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            dtgrid_away.Visible = true;
            dtgrid_detail.Visible = true;
            dtgrid_home.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            pictureBox1.Visible = false;

            // Query for home team players
            string queryHome = $"SELECT t.team_name, p.player_name, IF(p.playing_pos='G','GoalKeeper',IF(p.playing_pos='M','MidFielder',IF(p.playing_pos='D','Defender','Forward'))) AS 'Position' FROM player p, team t WHERE p.team_id=t.team_id AND t.team_name='{label_home.Text}'";
            MySqlCommand commandHome = new MySqlCommand(queryHome, sqlConnection);
            MySqlDataAdapter adapterHome = new MySqlDataAdapter(commandHome);
            DataTable dtHome = new DataTable();
            adapterHome.Fill(dtHome);
            dtgrid_home.DataSource = dtHome;

            // Query for away team players
            string queryAway = $"SELECT t.team_name, p.player_name, IF(p.playing_pos='G','GoalKeeper',IF(p.playing_pos='M','MidFielder',IF(p.playing_pos='D','Defender','Forward'))) AS 'Position' FROM player p, team t WHERE p.team_id=t.team_id AND t.team_name='{label_away.Text}'";
            MySqlCommand commandAway = new MySqlCommand(queryAway, sqlConnection);
            MySqlDataAdapter adapterAway = new MySqlDataAdapter(commandAway);
            DataTable dtAway = new DataTable();
            adapterAway.Fill(dtAway);
            dtgrid_away.DataSource = dtAway;

            // Query for match details
            string queryDetail = $"SELECT d.minute AS 'minute', t.team_name AS 'team name', p.player_name AS 'player name', IF(d.type='CY','Yellow Card',IF(d.type='CR','Red Card',IF(d.type='GO','Goal',IF(d.type='GP','Goal Penalty',IF(d.type='GW','Own Goal','Penalty Miss'))))) AS 'type' FROM dmatch d, team t, player p WHERE d.team_id=t.team_id AND d.player_id=p.player_id AND d.match_id='{cmb_match.SelectedValue.ToString()}'";
            MySqlCommand commandDetail = new MySqlCommand(queryDetail, sqlConnection);
            MySqlDataAdapter adapterDetail = new MySqlDataAdapter(commandDetail);
            DataTable dtDetail = new DataTable();
            adapterDetail.Fill(dtDetail);
            dtgrid_detail.DataSource = dtDetail;

        }
    }
}
