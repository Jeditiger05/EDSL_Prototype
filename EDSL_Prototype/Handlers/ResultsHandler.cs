using EDSL_Prototype.DAL;
using EDSL_Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL_Prototype.Handlers
{
    class ResultsHandler
    {
        public static List<Round> GetRoundsList()
        {
            return DAFunctions.draw;
            
        }
    }
}
