using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF.RedSide
{
    internal class Terrorist
    {
        protected string Name;
        public static string GetName()
        {
            return Name;
        }
        protected int Rank;
        protected string Status;
        protected List<string> Weapon;
    public Terrorist(string name, int  rank, string status, List<string> weapon)

        {
            Name = name;
            Rank = rank;
            Status = status;
            Weapon = weapon;

        }

    }
}
