using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_9_Nedarving_2
{
    class Terning
    {
        private static Random rnd = new Random();
        private int værdi;

       public int Værdi
        {
            get { return Værdi; }
            set
            {
                if (value > 0 & value < 7)
                {
                    Værdi = value;
                }
                else
                {
                    Værdi = 1;
                }
            }
        }

        public int Ryst()
        {
            return rnd.Next(1, 7);
        }

    }
}
