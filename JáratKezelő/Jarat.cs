using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JáratKezelő
{
    class Jarat
    {
        string jaratSzam;
        string honnanRepter;
        string hovaRepter;
        DateTime indulas;
         public Jarat(string jaratSzam, string honnanRepter, string hovaRepter, DateTime indulas)
        {
            JaratSzam = jaratSzam;
            HonnanRepter = honnanRepter;
            HovaRepter = hovaRepter;
            Indulas = indulas;
            Keses = 0;
        }

        public string JaratSzam { get; set; }
        public string HonnanRepter { get; set; }
        public string HovaRepter { get; set; }
        public DateTime Indulas { get; set; }
        public int Keses { get; set; }
   


    }
}
