using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL_Prototype.Models
{
    class Round
    {
        public int RoundID { get; set; }
        public int RoundNo { get; set; }
        public DateTime RoundDate { get; set; }
        public List<Game>  GameList { get; set; }
        public int SeasonID { get; set; }

        public Round(int roundNo, DateTime roundDate, int seasonID)
        {
            RoundNo = roundNo;
            RoundDate = roundDate;
            GameList = new List<Game>();
            SeasonID = seasonID;
        }

        public Round(int roundID, int roundNo, DateTime roundDate, List<Game> gameList, int seasonID)
        {
            RoundID = roundID;
            RoundNo = roundNo;
            RoundDate = roundDate;
            GameList = gameList;
            SeasonID = seasonID;
        }
    }
}
