using EDSL_Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL_Prototype.DAL
{
    class DAFunctions
    {
        private static List<Season> seasons = new List<Season>();
        private static List<Division> divisions = new List<Division>();
        private static List<Team> teams = new List<Team>();
        public static List<List<Round>> allRoundsList = new List<List<Round>>();
        public static Season ReadSeason(string season)
        {
            return seasons.Find(x => x.SeasonName == season);
        }

        public static List<string> GetDivisionTeams(int divID)
        {
            List<string> teamNames = new List<string>();
            foreach(Team team in teams)
            {
                if(team.DivisionID == divID)
                teamNames.Add(team.TeamName);
            }

            return teamNames;
        }

        public static void WriteSeason(Season season)
        {
            seasons.Add(season);
        }

        public static Division ReadDivision(string divName)
        {
            return divisions.Find(x => x.DivisionName == divName);
        }

        public static Team ReadTeam(string tName)
        {
            return teams.Find(x => x.TeamName == tName);
        }

        public static void LoadData()
        {
            //Seasons
            seasons.Add(new Season("2017", new DateTime(2017, 8, 12), 22));
            seasons.Add(new Season("2018", new DateTime(2018, 8, 11), 18));
            seasons.Add(new Season("2019", new DateTime(2019, 8, 10), 26));
            //Divisions
            divisions.Add(new Division(1, "A Division", "EDSL League"));
            divisions.Add(new Division(2, "B Division", "EDSL League"));
            divisions.Add(new Division(3, "C Division", "EDSL League"));
            //Teams
            teams.Add(new Team("Paok", "GK123", "Adonis", 1));
            teams.Add(new Team("Manchester UTD", "MC123", "Yeggs", 1));
            teams.Add(new Team("Real Madrid", "RM123", "Sanches", 1));
            teams.Add(new Team("Barcalona", "BA123", "Malone", 1));
            teams.Add(new Team("SoccerRoos", "SR123", "Aussie Man", 1));
            teams.Add(new Team("Liverpool", "LP123", "Savage", 1));
            teams.Add(new Team("Juventus", "JV123", "Eyebrow", 1));
            teams.Add(new Team("Athlectico", "AM123", "Ronaldo", 1));
            teams.Add(new Team("AC Milan", "AC123", "Mr Anderson", 1));
            teams.Add(new Team("Tottenham Spurs", "TS123", "Jon Elis", 1));
            teams.Add(new Team("Olypiacos", "TS123", "Lemonis", 1));
            teams.Add(new Team("Arsenal", "AS123", "Delavega", 1));
        }
    }
}
