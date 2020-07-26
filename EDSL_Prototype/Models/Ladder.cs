using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public bool Played { get; set; }

        public Ladder(string team, int goalsFor, int goalsAgainst, bool played)
        {
            Team = team;
            GetWins();
            GetLoses();
            GoalsFor = goalsFor;
            GoalsAgainst = goalsAgainst;
            Played = played;
            GetDraw();
            GetPoints();
        }

        public void GetDraw()
        {
            //MessageBox.Show(Played.ToString());
            if (Played.Equals(true))
            {
                if (GoalsFor == GoalsAgainst)
                    Draw += 1;
            }
        }

        public void GetLoses()
        {
            if (GoalsFor < GoalsAgainst)
                Loses += 1;
        }

        public void GetWins()
        {
            if (GoalsFor > GoalsAgainst)
                Wins += 1;
        }

        public void GetPoints()
        {
            Points = (Wins * 3) + (Draw);
        }
    }
}
