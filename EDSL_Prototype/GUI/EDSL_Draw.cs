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

namespace EDSL_Prototype.GUI
{
    public partial class EDSL_Draw : Form
    {
        private string divName;
        public EDSL_Draw(string divName)
        {
            this.divName = divName;
            InitializeComponent();
        }

        private void FillGridFixtures()
        {
            List<Game> rounds = DAFunctions.fixtures;

            if (rounds.Count == 0)
                MessageBox.Show("No Fixtures to Display");
            else
                grid_Draw.DataSource = rounds.Select((g, index) => new
                { GameNo = g.GameNo, g.HomeTeam, g.HomeGoals, g.AwayTeam, g.AwayGoals }).ToList();
        }

        private void FillGrid()
        {
            List<Round> rounds = DAFunctions.draw;

            grid_Draw.DataSource = rounds.Select((r, index) =>
            new
            {
                Round = $"Round {r.RoundNo} {r.RoundDate.ToShortDateString()}",
                Game1 = $"{r.GameList[0].HomeTeam} vs {r.GameList[0].AwayTeam}",
                Game2 = $"{r.GameList[1].HomeTeam} vs {r.GameList[1].AwayTeam}",
                Game3 = $"{r.GameList[2].HomeTeam} vs {r.GameList[2].AwayTeam}",
                Game4 = $"{r.GameList[3].HomeTeam} vs {r.GameList[3].AwayTeam}",
                Game5 = $"{r.GameList[4].HomeTeam} vs {r.GameList[4].AwayTeam}",
            }).ToList();

            grid_Draw.RowHeadersVisible = false;

            grid_Draw.Columns[0].HeaderText = "Round";
            grid_Draw.Columns[1].HeaderText = "Game 1";
            grid_Draw.Columns[2].HeaderText = "Game 2";
            grid_Draw.Columns[3].HeaderText = "Game 3";
            grid_Draw.Columns[4].HeaderText = "Game 4";
            grid_Draw.Columns[5].HeaderText = "Game 5";

            grid_Draw.Columns[0].Width = 155;
            grid_Draw.Columns[1].Width = 170;
            grid_Draw.Columns[2].Width = 170;
            grid_Draw.Columns[3].Width = 170;
            grid_Draw.Columns[4].Width = 170;
            grid_Draw.Columns[5].Width = 170;

           // grid_Draw.AutoResizeColumns();
        }

        private void btn_Fixtures_Click(object sender, EventArgs e)
        {
            FillGridFixtures();
        }

        private void btn_Rounds_Click(object sender, EventArgs e)
        {
            lbl_Division.Text = divName;
            FillGrid();
        }
    }

}
