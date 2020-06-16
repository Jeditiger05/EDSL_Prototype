using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL_Prototype.Models
{
    class Results
    {
        public int Game { get; set; }
        public string AwayTeam { get; set; }
        public int AwayResult { get; set; }
        public string HomeTeam { get; set; }
        public int HomeResult { get; set; }

        public Results(int game, string awayTeam, int awayResult, string homeTeam, int homeResult)
        {
            Game = game;
            AwayTeam = awayTeam;
            AwayResult = awayResult;
            HomeTeam = homeTeam;
            HomeResult = homeResult;
        }

    }
}
