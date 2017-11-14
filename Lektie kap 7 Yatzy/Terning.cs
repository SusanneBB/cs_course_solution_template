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

        private int værdi;
        public int Værdi
        {
            get { return værdi; }
            set
            {
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

        public string Skriv()
        {
            return $"[{Værdi}]";
        }
    }
}
