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
        private static List<Season> seasonsList = new List<Season>();
        public static Season ReadSeason(string season)
        {
            
            seasonsList.Add(new Season("2017", new DateTime(2017, 8, 12), 22));
            seasonsList.Add(new Season("2018", new DateTime(2018, 8, 11), 18));
            seasonsList.Add(new Season("2019", new DateTime(2019, 8, 10), 26));

            return seasonsList.Find(x => x.SeasonName == season);

        }

        public static void WriteSeason(Season season)
        {
            seasonsList.Add(season);
        }
    }
}
