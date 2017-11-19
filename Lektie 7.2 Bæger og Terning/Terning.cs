using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_7._2_Bæger_og_Terning
{
    class Terning
    {
        private int Værdi;

        protected static Random rnd = new Random();

        public Terning(int værdi)
        {
            this.værdi = værdi;
        }

        public Terning()
        {
            this.værdi = rnd.Next(1, 7);
        }

        public int værdi
        {
            get { return Værdi; }
            set {
                if (value > 0 && value < 7)
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
            return rnd.Next(1,7);
        }

        public void Skriv()
        {
            Console.Write($"[{værdi}]");
        }
    }
}
