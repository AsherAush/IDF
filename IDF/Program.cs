using IDF.BlueSide;
using IDF.BlueSide.Weapons;
using IDF.RedSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terrorist achmad = new Terrorist("achmad", 4, "live", new List<string> { "Knife", "M16" });
            Terrorist sami = new Terrorist("sami", 2, "live", new List<string> { "Knife", "AK47" });
            Hamas hammas = new Hamas(new DateTime(1988, 02, 13), "masuf", new List<Terrorist> { achmad, sami });
            string nameTerrorist = hammas.Terroristlist[0].Name;
            IntelDiv intelDiv = new IntelDiv();
            intelDiv.setName(nameTerrorist);

        }
    }
}
