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

        public Game()
        {
        }

        public Game(int gameNo, string homeTeam, string awayTeam, int homeGoals, int awayGoals)
        {
            GameNo = gameNo;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeGoals = homeGoals;
            AwayGoals = awayGoals;
        }

        public Game(int gameID, int gameNo, string homeTeam, string awayTeam, int homeGoals, int awayGoals)
        {
            GameID = gameID;
            GameNo = gameNo;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeGoals = homeGoals;
            AwayGoals = awayGoals;
        }
    }
}
