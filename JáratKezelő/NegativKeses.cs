using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JáratKezelő
{
    class NegativKesesException : Exception
    {
        public NegativKesesException(string jaratSzam, int keses)
           : base("Nem lehet negatív szám a késés! Járat: " + jaratSzam + " Késés: " + keses)
        {
        }
    }
}
