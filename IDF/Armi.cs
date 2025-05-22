using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF
{
    internal abstract class Armi
    {
        protected DateTime DateOfEstablishment;
        protected string Commanderame;

        public Armi(DateTime dateOfEstablishment, string commanderName)
        {
            DateOfEstablishment = dateOfEstablishment;
            Commanderame = commanderName;
        }
    }
}
