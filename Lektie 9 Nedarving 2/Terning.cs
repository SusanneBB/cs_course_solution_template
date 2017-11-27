using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_9_Nedarving_2
{
    class Terning
    {
        public Terning()
        {
            værdi = Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

        private static Random rnd = new Random();
        private int værdi;

       public int Værdi
        {
            get {
                Console.WriteLine($"Nu læses værdien {værdi}");
                return værdi;
                }
            set
            {
                if (value > 0 & value < 7)
                {
                    værdi = value;
                }
                else
                {
                    værdi = 1;
                }
            Console.WriteLine($"Sættes til {value}");
            }
        }

        public int Ryst()
        {
            return rnd.Next(1, 7);
        }

        public virtual void Print()
        {
            Console.WriteLine($"[{Værdi}]");
        }
    }
}
