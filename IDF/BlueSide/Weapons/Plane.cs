using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF.BlueSide.Weapons
{
    internal class Plane : StrikeOptions
    {
        protected string Operator;


        public Plane(string name, int attacksRemaining, int fuelQuantity, List<string> intendedPurpose, List<string> typesBombs, string operatorType)
            : base(name, attacksRemaining, fuelQuantity, intendedPurpose, typesBombs)
        {
            Operator = operatorType;
        }


    }
}
