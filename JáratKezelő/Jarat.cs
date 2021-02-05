using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JáratKezelő
{
    class Jarat
    {
        private string jaratszam;
        private string honnanRepter;
        private string hovaRepte;
        private DateTime indulas;
        private int keses;

        public string Jaratszam { get => jaratszam; set => jaratszam = value; }
        public string HonnanRepter { get => honnanRepter; set => honnanRepter = value; }
        public string HovaRepte { get => hovaRepte; set => hovaRepte = value; }
        public DateTime Indulas { get => indulas; set => indulas = value; }
        public int Keses { get => keses; set => keses = value; }

        public Jarat(string jaratszam, string honnanRepter, string hovaRepte, DateTime indulas, int keses)
        {
            Jaratszam = jaratszam;
            HonnanRepter = honnanRepter;
            HovaRepte = hovaRepte;
            Indulas = indulas;
            Keses = keses;
        }


    }
}
