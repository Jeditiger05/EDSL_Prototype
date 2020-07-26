using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL_Prototype.Models
{
    class Game
    {
        public int GameID { get; set; }
        public int GameNo { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public bool Played { get; set; }

        public Game(bool played)
        {
            Played = played;
        }


        public Game(int gameNo, string homeTeam, string awayTeam, bool played)
        {
            GameNo = gameNo;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            Played = played;
        }
        public Game(int gameNo, string homeTeam, string awayTeam, int homeGoals, int awayGoals, bool played)
        {
            GameNo = gameNo;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeGoals = homeGoals;
            AwayGoals = awayGoals;
            Played = played;
        }

        public Game(int gameID, int gameNo, string homeTeam, string awayTeam, int homeGoals, int awayGoals, bool played)
        {
            GameID = gameID;
            GameNo = gameNo;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeGoals = homeGoals;
            AwayGoals = awayGoals;
            Played = played;
        }
    }
}
