using System;
using System.Collections.Generic;
using System.Linq;

namespace EDSL_Prototype.Models
{
    class Season
    {
        public int SeasonID { get; set; }
        public string SeasonName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string LeagueName { get; set; }
        public int NoOfRounds { get; set; }
        public List<DateTime> SeasonDates { get; set; }

        //New Season Constructor
        public Season(string seasonName, DateTime startDate, int noOfRounds)
        {
            SeasonName = seasonName;
            StartDate = startDate;
            LeagueName = "EDSL League";
            NoOfRounds = noOfRounds;
            GererateDates();
            FinishDate = SeasonDates.Last();
        }

        //Existing Season Constructor
        public Season(int seasonID, string seasonName, DateTime startDate, DateTime finishDate, int noOfRounds, List<DateTime> seasonDates)
        {
            SeasonID = seasonID;
            SeasonName = seasonName;
            StartDate = startDate;
            FinishDate = finishDate;
            LeagueName = "EDSL league";
            NoOfRounds = noOfRounds;
            SeasonDates = seasonDates;
        }

        //Generates new Season dates by the Start Date and Number of Rounds
        private void GererateDates()
        {
            SeasonDates = new List<DateTime>();
            SeasonDates.Add(StartDate);

            for (int i = 1; i < NoOfRounds; i++)
            {
                SeasonDates.Add(SeasonDates[i -1].AddDays(7));
            }
        }
    }
}
