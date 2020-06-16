using EDSL_Prototype.DAL;
using EDSL_Prototype.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            if (DAFunctions.ReadSeason(seasonName) == null && !seasonName.Equals(""))
            {

                DialogResult msg = MessageBox.Show("Dates for this Season Do Not Exist. Would you like to Create a New Set of Season Dates?", "Generate Dates", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    season = new Season(seasonName, startDate, Convert.ToInt32(num_Rounds));

                    FillGridd(grid_SeasonDates, season);
                }
                else
                {
                    MessageBox.Show("No Season Dates Created");
                }

            }
            else
            {
                if (seasonName.Equals(""))
                {
                    MessageBox.Show("Please Select Season");
                }
                else
                {
                    FillGridd(grid_SeasonDates, DAFunctions.ReadSeason(seasonName));
                }
            }

            return season;
        }

        public static void SaveSeasonDates(string seasonName)
        {
            DAFunctions.WriteSeason(season);
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
