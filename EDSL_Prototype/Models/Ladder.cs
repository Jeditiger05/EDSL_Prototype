using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL_Prototype.Models
{
    class Ladder
    {

        public string Team { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Draw { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int Points { get; set; }

        public Ladder(string team, int wins, int loses, int draw, int goalsFor, int goalsAgainst, int points)
        {
            Team = team;
            Wins = wins;
            Loses = loses;
            Draw = draw;
            GoalsFor = goalsFor;
            GoalsAgainst = goalsAgainst;
            Points = points;
        }
    }
}
