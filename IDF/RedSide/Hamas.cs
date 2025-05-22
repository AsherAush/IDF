using IDF.BlueSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF.RedSide
{
    internal class Hamas : Armi
    {

        public  List<Terrorist> Terroristlist;

        public Hamas( DateTime dateOfEstablishment, string commanderName, List<Terrorist> terroristlist)
            : base(dateOfEstablishment, commanderName)
        {
            Terroristlist = terroristlist;
        }



    }
}
