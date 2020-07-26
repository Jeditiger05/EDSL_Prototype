using EDSL_Prototype.DAL;
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
        private static List<Round> rounds = new List<Round>();

        public EDSL_Results(EDSL_System systemGUI)
        {
            this.systemGUI = systemGUI;
            InitializeComponent();

        }

        private void GetDraw()
        {
            DAFunctions.GetDraw(SeasonHandler.SelectDraw(cbo_SelectSeason.Text));

            rounds = DAFunctions.draw;

        }

        private void btn_ViewResults_Click(object sender, EventArgs e)
        {
            if (cbo_SelectSeason.Text == "" || cbo_SelectDivision.Text == "")
            {
                MessageBox.Show("Please Select Season & Division to View Results");
            }
            else
            {
                int rNo = Convert.ToInt32(cbo_SelectRound.Text);
                lbl_Results.Text = "Results";

                GetDraw();
                rounds[0].GameList[0].HomeGoals = 2;
                rounds[0].GameList[0].AwayGoals = 2;

                dataGridView1.DataSource = rounds[rNo].GameList.Select((g, index) =>
                new
                {
                    Column0 = $"Game {index + 1}",
                    Column1 = $"{g.HomeTeam}",
                    Column2 = $" {g.HomeGoals}",
                    Column3 = $" {g.AwayTeam}",
                    Column4 = $" {g.AwayGoals}"

                }).ToArray();


                dataGridView1.Columns[0].HeaderText = "Game";
                dataGridView1.Columns[1].HeaderText = "Away Team";
                dataGridView1.Columns[2].HeaderText = "Score";
                dataGridView1.Columns[3].HeaderText = "Home Team";
                dataGridView1.Columns[4].HeaderText = "Score";
                dataGridView1.RowHeadersVisible = false;
            }

        }

        public static int CalcGoalsFor(string team)
        {
            int goals = 0;
            //adds all goals for when home team
            for (int i = 0; i < rounds.Count; i++)
            {
                for (int j = 0; j < rounds[i].GameList.Count; j++)
                {
                    if (rounds[i].GameList[j].HomeTeam.Equals(team))
                    {
                        goals += rounds[i].GameList[j].HomeGoals;
                    }
                }
            }
            //adds all goals for when away team
            for (int i = 0; i < rounds.Count; i++)
            {
                for (int j = 0; j < rounds[i].GameList.Count; j++)
                {
                    if (rounds[i].GameList[j].AwayTeam.Equals(team))
                    {
                        goals += rounds[i].GameList[j].AwayGoals;
                    }
                }
            }

            return goals;
        }

        public static int CalcGoalsAgainst(string team)
        {
            int goals = 0;
            //adds all goals against when home team
            for (int i = 0; i < rounds.Count; i++)
            {
                for (int j = 0; j < rounds[i].GameList.Count; j++)
                {
                    if (rounds[i].GameList[j].HomeTeam.Equals(team))
                    {
                        goals += rounds[i].GameList[j].AwayGoals;
                    }
                }
            }
            //adds all goals against when away team
            for (int i = 0; i < rounds.Count; i++)
            {
                for (int j = 0; j < rounds[i].GameList.Count; j++)
                {
                    if (rounds[i].GameList[j].AwayTeam.Equals(team))
                    {
                        goals += rounds[i].GameList[j].HomeGoals;
                    }
                }
            }

            return goals;
        }

        public static bool GamePlayed(string team)
        {
            bool played = false;
            for (int i = 0; i < rounds.Count; i++)
            {
                for (int j = 0; j < rounds[i].GameList.Count; j++)
                {
                    if (rounds[i].GameList[j].Played == true)
                    {
                        played = true;
                    }
                }
            }

            return played;
        }

        private void btn_ViewLadder_Click(object sender, EventArgs e)
        {
            if (cbo_SelectSeason.Text == "" || cbo_SelectDivision.Text == "")
            {
                MessageBox.Show("Please Select Season & Division to View Ladder");
            }
            else
            {
                List<string> teams = DAFunctions.GetDivisionTeams(1);

                List<Ladder> ladder = new List<Ladder>();
                for (int i = 0; i < teams.Count; i++)
                {
                    ladder.Add(new Ladder(teams[i], CalcGoalsFor(teams[i]), CalcGoalsAgainst(teams[i]), GamePlayed(teams[i])));
                }

                lbl_Results.Text = "Ladder";
                dataGridView1.DataSource = ladder;
                dataGridView1.Columns[4].HeaderText = "Goals For";
                dataGridView1.Columns[5].HeaderText = "Goals Against";
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoResizeColumns();
                dataGridView1.RowHeadersVisible = false;
            }


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

        private void btn_UpdateResults_Click(object sender, EventArgs e)
        {
            if (cbo_SelectSeason.Text == "" || cbo_SelectDivision.Text == "")
            {
                MessageBox.Show("Please Select Season & Division to Update Round Results");
            }
            else
            {
                MessageBox.Show("Round " + cbo_SelectRound.Text + " Results Updated");
            }

        }

        private void btn_UpdateLadder_Click(object sender, EventArgs e)
        {
            if (cbo_SelectSeason.Text == "" || cbo_SelectDivision.Text == "")
            {
                MessageBox.Show("Please Select Season & Division to Update Ladder");
            }
            else
            {
                MessageBox.Show($"Season {cbo_SelectSeason.Text} {cbo_SelectDivision.Text} Ladder Updated");
            }
        }
    }
}
