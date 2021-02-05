using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JáratKezelő
{
    public class JaratKezelo
    {
        Jarat jarat = new Jarat();

        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            List<Jarat> jaratok = new List<Jarat>();

            jarat.jarat = jaratSzam;
            jarat.honnanRepter = repterHonnan;
            jarat.hovaRepter = repterHova;
            jarat.indulas = indulas;


        }

        public void Keses(string jaratSzam, int keses)
        {
            jarat.jarat = jaratSzam;
            jarat.keses = keses;
            if (keses<0)
            {
                throw new NegativKesesException(jaratSzam, keses);
            }
        }

        public DateTime MikorIndul(string jaratSzam)
        {
            DateTime datum = new DateTime();
            jarat.jarat = jaratSzam;
            jarat.indulas = datum;
            return datum;
        }

        public List<string> Jaratokrepuloterrol(string repter)
        {
            List<string> jaratok = new List<string>();
            jarat.honnanRepter = repter;
            jaratok.Add(repter);
            return jaratok;
        }




        class Jarat
        {

            public string jarat { get; set; }
            public string honnanRepter { get; set; }
            public string hovaRepter { get; set; }
            public DateTime indulas { get; set; }
            public int keses { get; set; }
        }
    }
}
