using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_Terning
{
    class Terning
    {
        private static System.Random rnd = new System.Random();

        public int værdi;

        private bool snyd;

        public Terning()
        {
            værdi = 1;
            snyd = false;
        }

        public Terning(bool JegVilSnyde)
        {
            værdi = 1;
            snyd = JegVilSnyde;
        }
        public void Skriv()
        {
            if (snyd)
            {
                Console.WriteLine("Værdi med snyd: " + værdi.ToString());
            }
            else
            {
                Console.WriteLine("Værdi uden snyd: " + værdi.ToString());
            }
        }

        public void Ryst()
        {
            if (snyd)
            {
                værdi = 6;
            }
            else
            {
                værdi = rnd.Next(1, 7);
            }
        }
    }
}
