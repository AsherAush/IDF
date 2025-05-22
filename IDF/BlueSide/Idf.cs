using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF.BlueSide
{
    internal class Idf : Armi 
    {

        public List<StrikeOptions> StrikeOptionslist;

        public Idf(List<StrikeOptions> strikeOptionslist, DateTime dateOfEstablishment, string commanderName)
            : base(dateOfEstablishment, commanderName)
        {
            StrikeOptionslist = strikeOptionslist;
        }
       
    }
}
