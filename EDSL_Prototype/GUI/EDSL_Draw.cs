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
        public EDSL_Draw()
        {
            InitializeComponent();
            List<Round> rounds = SeasonHandler.CreateDivisionDraw("A Division");
            //List<Game> rounds = DAFunctions.fixtures;

            //grid_Draw.DataSource = rounds.Select(g => new
            //{ RoundNo = g.GameNo, g.HomeTeam, g.HomeGoals, g.AwayTeam, g.AwayGoals }).OrderBy(g => g.RoundNo).ToList();

            grid_Draw.DataSource = rounds.Select((r, index) =>
            new
            {
                Round = $"Round {r.RoundNo} {r.RoundDate.ToShortDateString()}",
                Game1 = $"{r.GameList[0].HomeTeam} vs {r.GameList[0].AwayTeam}",
                Game2 = $"{r.GameList[1].HomeTeam} vs {r.GameList[1].AwayTeam}",
                Game3 = $"{r.GameList[2].HomeTeam} vs {r.GameList[2].AwayTeam}",
                Game4 = $"{r.GameList[3].HomeTeam} vs {r.GameList[3].AwayTeam}",
                Game5 = $"{r.GameList[4].HomeTeam} vs {r.GameList[4].AwayTeam}",
                Game6 = $"{r.GameList[5].HomeTeam} vs {r.GameList[5].AwayTeam}"
            }).ToList();

            grid_Draw.RowHeadersVisible = false;
            grid_Draw.Columns[0].HeaderText = "Round";
            grid_Draw.Columns[1].HeaderText = "Game 1";
            grid_Draw.Columns[2].HeaderText = "Game 2";
            grid_Draw.Columns[3].HeaderText = "Game 3";
            grid_Draw.Columns[4].HeaderText = "Game 4";
            grid_Draw.Columns[5].HeaderText = "Game 5";
            grid_Draw.Columns[6].HeaderText = "Game 6";

            grid_Draw.Columns[0].Width = 140;
            grid_Draw.Columns[1].Width = 140;
            grid_Draw.Columns[2].Width = 140;
            grid_Draw.Columns[3].Width = 140;
            grid_Draw.Columns[4].Width = 140;
            grid_Draw.Columns[5].Width = 140;
            grid_Draw.Columns[6].Width = 140;

            grid_Draw.AutoResizeColumns();

        }
    }
}
