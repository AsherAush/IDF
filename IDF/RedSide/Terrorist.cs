using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF.RedSide
{
    internal class Terrorist
    {
        public string Name;
        public  string GetName()
        {
            return Name;
        }
        public  void SetName(string name)
        {
            Name = name;
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
