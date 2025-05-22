using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IDF.BlueSide.Weapons
{
    internal class Artillerycs : StrikeOptions
    {
        public Artillerycs(string name, int attacksRemaining, int fuelQuantity, List<string> intendedPurpose, List<string> typesBombs)
            : base(name, attacksRemaining, fuelQuantity, intendedPurpose, typesBombs)
        {
        }
    }
}
