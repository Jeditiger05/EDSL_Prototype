using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL_Prototype.Models
{
    class Division
    {
        public int DivisionID { get; set; }
        public string DivisionName { get; set; }
        public string LeagueName { get; set; }

        public Division( string divisionName, string leagueName)
        {
            DivisionName = divisionName;
            LeagueName = leagueName;
        }

        public Division(int divisionID, string divisionName, string leagueName)
        {
            DivisionID = divisionID;
            DivisionName = divisionName;
            LeagueName = leagueName;
        }
    }
}
