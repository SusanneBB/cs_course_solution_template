using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_trekant
{
   public class Trekant
    {
        public int Grundlinje { get; private set; }

        public int Højde { get; private set; }

        public double Areal
        {
        get
            {
                return (Højde * Grundlinje) / 2.00;
            }
        }

        public Trekant(int højde, int grundlinje)
        {
            Højde = højde;
            Grundlinje = grundlinje;
        }

    }
}
