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

        public static List<Terrorist> Terroristlist;

        public Hamas(List<Terrorist> terroristlist, DateTime dateOfEstablishment, string commanderName)
            : base(dateOfEstablishment, commanderName)
        {
            Terroristlist = terroristlist;
        }

    }
}
