using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JáratKezelő
{
    public class JaratKezelo
    {
        List<Jarat> jaratok = new List<Jarat>();
        Jarat jarat;

        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {


            var jaratt = new Jarat(jaratSzam, repterHonnan, repterHova, indulas);
            foreach (var jarat in jaratok)
            {
                if (jarat.JaratSzam.Equals(jaratSzam))
                {
                    throw new ArgumentException("Ilyen járat már van");
                }
            }
            jaratok.Add(jaratt);


        }

        public void Keses(string jaratszam, int keses)
        {
            foreach (var jarat in jaratok)
            {
                if (jaratszam.Equals(jarat.JaratSzam))
                {
                    if ((jarat.Keses + keses) < 0)
                    {
                        throw new NegativKesesException(jaratszam,keses);
                    }
                    else
                    {
                        jarat.Keses += keses;
                    }
                }
            }
        }

        public DateTime MikorIndul(string jaratSzam)
        {
            foreach (var jarat in jaratok)
            {
                if (jaratSzam.Equals(jarat.JaratSzam))
                {
                    return jarat.Indulas.AddMinutes(jarat.Keses);
                }
            }
            throw new ArgumentException("Nem volt ilyen járat!");
        }

        public List<string> Jaratokrepuloterrol(string repter)
        {
            List<string> jaratokList = new List<string>();
            foreach (var jarat in jaratok)
            {
                if (repter.Equals(jarat.HonnanRepter))
                {
                    jaratokList.Add(jarat.JaratSzam);

                }
            }
            if (jaratokList.Count == 0)
            {
                throw new ArgumentException();
            }
            return jaratokList;
        }




    }
}
