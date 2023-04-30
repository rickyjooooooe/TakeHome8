using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TakeHome_W8
{
    public partial class label : Form
    {

        string connectionString = "server=localhost;uid=root;pwd=titi020504;database=premier_league";
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string query = "";
        DataTable dtTeam=new DataTable();
        DataTable dtPlayer= new DataTable();
        DataTable dtInfoPemain1=new DataTable();
        DataTable dtidPemain=new DataTable();
        DataTable dtInfoPemain2= new DataTable();
        public label()
        {
            InitializeComponent();
        }
        private void idPemain(string namaPlayer)
        {
            dtidPemain = new DataTable();
            query = $"SELECT player_id\r\nFROM player\r\nWhere player_name='{namaPlayer}';";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtidPemain);
        }
        private void PlayerData_Load(object sender, EventArgs e)
        {
            query = "SELECT team_name FROM premier_league.team;";
            sqlConnection =new MySqlConnection(connectionString);
            sqlCommand=new MySqlCommand(query,sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam);

            cmb_team.DataSource= dtTeam;
            cmb_team.DisplayMember= "team_name";
        }

        private void cmb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pilih=cmb_team.Text;
            dtPlayer = new DataTable();
            query = $"SELECT p.player_name as'player'\r\nfrom player p,premier_league.team t \r\nwhere p.team_id=t.team_id and t.team_name='{pilih}' ;";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtPlayer);

            cmb_player.DataSource = dtPlayer;
            cmb_player.DisplayMember = "player";
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            labell.Visible = true;
            labell1.Visible = true;
            labell2.Visible = true;
            labell3.Visible = true;
            labell5.Visible = true;
            labell6.Visible = true;
            labell7.Visible = true;
            labell8.Visible = true;
            name.Visible = true;
            team.Visible = true;
            pos.Visible = true;
            nation.Visible = true;
            number.Visible = true;
            yellow.Visible = true;
            red.Visible = true;
            goal.Visible = true;
            penalty.Visible = true;
            labell4.Visible = true;

            dtInfoPemain1 = new DataTable();
            string namaTeam = cmb_team.Text;
            string namaPlayer = cmb_player.Text;

            query = $"SELECT p.player_name, t.team_name, " +
                    $"CASE p.playing_pos " +
                    $"WHEN 'G' THEN 'GoalKeeper' " +
                    $"WHEN 'M' THEN 'MidFielder' " +
                    $"WHEN 'D' THEN 'Defender' " +
                    $"ELSE 'Forward' END AS 'Position', " +
                    $"n.nation, p.team_number " +
                    $"FROM player p " +
                    $"INNER JOIN nationality n ON p.nationality_id = n.nationality_id " +
                    $"INNER JOIN team t ON p.team_id = t.team_id " +
                    $"WHERE p.player_name = '{namaPlayer}' AND t.team_name = '{namaTeam}'";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtInfoPemain1);

            if (dtInfoPemain1.Rows.Count > 0)
            {
                DataRow row = dtInfoPemain1.Rows[0];
                name.Text = row["player_name"].ToString();
                team.Text = row["team_name"].ToString();
                pos.Text = row["Position"].ToString();
                nation.Text = row["nation"].ToString();
                number.Text = row["team_number"].ToString();

                idPemain(namaPlayer);
                dtInfoPemain2 = new DataTable();
                string _idPemain = dtidPemain.Rows[0][0].ToString();
                query = $"SELECT d.type FROM dmatch d WHERE d.player_id='{_idPemain}';";
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtInfoPemain2);

                int cy = 0, cr = 0, go = 0, pm = 0;

                foreach (DataRow matchRow in dtInfoPemain2.Rows)
                {
                    string matchType = matchRow["type"].ToString();
                    switch (matchType)
                    {
                        case "CY":
                            cy++;
                            break;
                        case "CR":
                            cr++;
                            break;
                        case "GO":
                            go++;
                            break;
                        case "PM":
                            pm++;
                            break;
                        default:
                            break;
                    }
                }

                yellow.Text = cy.ToString();
                red.Text = cr.ToString();
                goal.Text = go.ToString();
                penalty.Text = pm.ToString();
            }
            else
            {
                // player not found
                MessageBox.Show("Player not found");
            }
        }

        private void label_penalty_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
