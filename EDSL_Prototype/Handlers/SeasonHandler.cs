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
                    season = new Season(DAFunctions.seasons.Count + 1, seasonName, startDate, Convert.ToInt32(num_Rounds));
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

        public static void CreateDivisionDraw(string seasName, string divName)
        {
            Fixtures.GetGames(seasName, divName);
        }

        public static void FillGridd(DataGridView grid, Season season)
        {
            grid.DataSource = season.SeasonDates.Select((sd, index) =>
            new { Round = $"Round {index + 1}", Date = sd.Date.ToLongDateString(), Day = sd.DayOfWeek, sd.Year }).ToList();

            grid.RowHeadersVisible = false;
            grid.AutoResizeColumns();

        }

        public static int SelectDraw(string seasonName)
        {
            int drawID = 0;

            switch (seasonName)
            {
                case "2017":
                    drawID = 0;
                    break;
                case "2018":
                    drawID = 1;
                    break;
                case "2019":
                    drawID = 2;
                    break;
                case "2020":
                    drawID = 3;
                    break;
                case "2021":
                    drawID = 4;
                    break;
                case "2022":
                    drawID = 5;
                    break;
            }

            DAFunctions.GetDraw(drawID);
            return drawID;
        }
    }
}