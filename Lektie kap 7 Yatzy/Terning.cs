using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_kap_7_Yatzy
{
    public class Terning
    {
        private static Random rnd = new Random();

        public Terning()
        {

        }
        public Terning(int værdi)
        {
            Værdi = værdi;
        }
        private int værdi;
        public int Værdi
        {
            get {
                Console.WriteLine($"Nu aflæses værdien.");
                return værdi; }
            set
            {
                Console.WriteLine($"Nu tildeles en værdi");
                if ((value < 1) || (value > 6))
                {
                    værdi = 1;
                }
                else
                {
                    værdi = value;
                }
            }
        }

        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"[{Værdi}]");
        }
    }
}
