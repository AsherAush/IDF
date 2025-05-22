using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IDF.BlueSide
{
    internal abstract class StrikeOptions
    {
        protected string Name;
        protected int AttacksRemaining;
        protected int FuelQuantity;
        protected List<string> IntendedPurpose;
        protected List<string> TypesBombs;



        public StrikeOptions(string name, int attacksRemaining, int fuelQuantity, List<string> intendedPurpose, List<string> typesBombs)
        {
            Name = name;
            AttacksRemaining = attacksRemaining;
            FuelQuantity = fuelQuantity;
            IntendedPurpose = intendedPurpose;
            TypesBombs = typesBombs;
        }
    }
}
