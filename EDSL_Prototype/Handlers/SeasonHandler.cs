using EDSL_Prototype.DAL;
using EDSL_Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EDSL_Prototype.Handlers
{
    class SeasonHandler
    {
        private static Season season;
        DateTimePicker dtp = new DateTimePicker();

        public static Season GenerateSeasonDates(string seasonName, DateTime startDate,
            DataGridView grid_SeasonDates, int num_Rounds)
        {
            DialogResult dialogResult;

            if (DAFunctions.ReadSeason(seasonName) != null)
            {
                MessageBox.Show("Season Exists");
                return null;
            }
            if (seasonName.Equals(""))
            {
                MessageBox.Show("Please Enter Season Name");
                return null;
            }
            if (num_Rounds == 0)
            {
                MessageBox.Show("Enter Number of Rounds");
                return null;
            }
            if (startDate.Date.ToShortDateString().Equals(DateTime.Now.Date.ToShortDateString()))
            {
                dialogResult = MessageBox.Show("Are you sure you want to Start Season from Today?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Select a New Start Date");
                    return null;
                }
                else
                {
                    season = new Season(seasonName, startDate, Convert.ToInt32(num_Rounds));
                    FillGridd(grid_SeasonDates, season);
                    SaveSeasonDates();
                }
            }

            return season;
        }

        public static Season ViewSeasonDates(DataGridView grid_SeasonDates, string seasonName)
        {
            if (DAFunctions.ReadSeason(seasonName) != null)
            {
                if (seasonName.Equals(""))
                {
                    MessageBox.Show("Please Enter Season Name");
                }
                else
                {
                    season = DAFunctions.ReadSeason(seasonName);
                    FillGridd(grid_SeasonDates, season);
                }
            }
            else
            {
                MessageBox.Show("Season Does Not Exists");
            }

            return season;
        }

        public static void SaveSeasonDates()
        {
            DAFunctions.WriteSeason(season);
        }

        //public static void CreateDivisionDraw(string divName)
        //{
        //    Fixtures.GetGames(divName);
        //}

        public static List<Round> CreateDivisionDraw(string divName)
        {
            Division division = DAFunctions.ReadDivision(divName);
            List<string> teams = DAFunctions.GetDivisionTeams(division.DivisionID);
            List<Round> rounds = new List<Round>();
            Round round;
            Game game;

            //3. Loop through Each Season Round and Add Home and Away Teams
            for (int i = 0; i < season.SeasonDates.Count; i++)
            {
                int gameNum = 1;
                round = new Round(i + 1, season.SeasonDates[i], 1);

                for (int j = 0; j < teams.Count; j += 2)
                {
                    if (!teams[j].Equals(teams[j + 1]))
                    {
                        game = new Game(gameNum, teams[j], teams[j + 1], 0, 0);
                    round.GameList.Add(game);
                    gameNum += 1;
                    }

                }
                teams.Reverse();
                ShiftTeams(teams);
                rounds.Add(round);
            }

            DAFunctions.allRoundsList.Add(rounds);
            return rounds;
        }

        public static void ShiftTeams(List<string> teams)
        {
            var homeTeam = teams[0];
            var awayTeam = teams[1];
            teams.RemoveAt(0);
            teams.RemoveAt(1);
            teams.Add(awayTeam);
            teams.Add(homeTeam);
            homeTeam = teams[2];
            awayTeam = teams[3];
            teams.RemoveAt(2);
            teams.RemoveAt(3);
            teams.Add(awayTeam);
            teams.Add(homeTeam);
            homeTeam = teams[4];
            awayTeam = teams[5];
            teams.RemoveAt(4);
            teams.RemoveAt(5);
            teams.Add(awayTeam);
            teams.Add(homeTeam);
        }

        public static void FillGridd(DataGridView grid, Season season)
        {
            grid.DataSource = season.SeasonDates.Select((sd, index) =>
            new { Round = $"Round {index + 1}", Date = sd.Date.ToLongDateString(), Day = sd.DayOfWeek, sd.Year }).ToList();

            grid.RowHeadersVisible = false;
            grid.AutoResizeColumns();

        }
    }
}