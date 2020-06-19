using EDSL_Prototype.Handlers;
using EDSL_Prototype.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDSL_Prototype
{
    public partial class EDSL_Results : Form
    {
        EDSL_System systemGUI;
        public EDSL_Results(EDSL_System systemGUI)
        {
            this.systemGUI = systemGUI;
            InitializeComponent();

        }

        private void btn_ViewResults_Click(object sender, EventArgs e)
        {
            int rNo = Convert.ToInt32(cbo_SelectRound.Text);
            lbl_Results.Text = "Results";
            List<Round> rounds = new List<Round>();
            rounds = ResultsHandler.GetRoundsList();

            dataGridView1.DataSource = rounds[rNo].GameList.Select((g, index) =>
            new
            {
                Column0 = $"Game {index +1}",
                Column1 = $"{g.HomeTeam}",
                Column2 = $" {g.HomeGoals}",
                Column3 = $" {g.AwayTeam}",
                Column4 = $" {g.AwayGoals}"

            }).ToList();


            dataGridView1.Columns[0].HeaderText = "Game";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].HeaderText = "Away Team";
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].HeaderText = "Score";
            dataGridView1.Columns[3].HeaderText = "Home Team";
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].HeaderText = "Score";
            dataGridView1.RowHeadersVisible = false;
        }

        private void btn_ViewLadder_Click(object sender, EventArgs e)
        {
            lbl_Results.Text = "Ladder";
            List<Ladder> ladder = new List<Ladder>();
            ladder.Add(new Ladder("Paok", 0, 0, 0, 0, 0, 125));
            ladder.Add(new Ladder("Manchester UTD", 0, 0, 0, 0, 0, 110));
            ladder.Add(new Ladder("Real Madrid", 0, 0, 0, 0, 0, 85));
            ladder.Add(new Ladder("Barcalona", 0, 0, 0, 0, 0, 80));
            ladder.Add(new Ladder("Socceroos", 0, 0, 0, 0, 0, 70));
            ladder.Add(new Ladder("Liverpool", 0, 0, 0, 0, 0, 65));
            ladder.Add(new Ladder("Juventus", 0, 0, 0, 0, 0, 50));
            ladder.Add(new Ladder("Athletico Madrid", 0, 0, 0, 0, 0, 45));
            ladder.Add(new Ladder("AC Milan", 0, 0, 0, 0, 0, 35));
            ladder.Add(new Ladder("Tottenham Spurs", 0, 0, 0, 0, 0, 25));
            ladder.Add(new Ladder("Olympiacos", 0, 0, 0, 0, 0, 22));
            ladder.Add(new Ladder("Arsenal", 0, 0, 0, 0, 0, 15));

            dataGridView1.DataSource = ladder;
            dataGridView1.Columns[4].HeaderText = "Goals For";
            dataGridView1.Columns[5].HeaderText = "Goals Against";
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.RowHeadersVisible = false;

        }

        private void btn_Season_Click(object sender, EventArgs e)
        {
            this.Hide();
            systemGUI.Show();
        }

        private void EDSL_Results_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.systemGUI.Dispose();
        }

    }
}
