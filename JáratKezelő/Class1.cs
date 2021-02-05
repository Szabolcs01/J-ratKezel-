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
                throw new NegativKeses(jaratSzam, keses);
            }
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
