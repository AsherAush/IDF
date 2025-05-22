using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF.BlueSide.Weapons
{
    internal class Drone : StrikeOptions
    {
            List<object> DroneTypes = new List<object>();
        public Drone (string name, int attacksRemaining, int fuelQuantity, List<string> intendedPurpose, List<string> typesBombs)
            : base (name, attacksRemaining, fuelQuantity, intendedPurpose, typesBombs)
        {
        //    DroneTypes.Add(name);
        //    DroneTypes.Add(attacksRemaining);
        //    DroneTypes.Add(fuelQuantity);
        //}
        //public void printDrone()
        //{
        //    foreach (var item in DroneTypes)
        //    {
        //        Console.WriteLine(item);
        //    }
        }
    }
}
