using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL_Prototype.Models
{
    class Team
    {
        public string TeamName { get; set; }
        public string ClubCode { get; set; }
        public string ManagerName { get; set; }
        public int DivisionID { get; set; }

        public Team(string teamName, string clubCode, string managerName, int divisionID)
        {
            TeamName = teamName;
            ClubCode = clubCode;
            ManagerName = managerName;
            DivisionID = divisionID;
        }
    }
}
