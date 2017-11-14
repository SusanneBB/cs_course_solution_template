using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08_PolymorfiDyr
{
    class Dyr
    {
        private static Random rnd = new Random();
        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine($"Jeg er et dyr og hedder {Navn}");
        }

        public static Dyr TilfældigtDyr()
        {
            Dyr dyr;
            int j = rnd.Next(1, 3);
            if (j == 1)
            {                dyr = new Hund();
            }
            else
	        {
                dyr = new Kat();
            }
            return dyr;
        }
    }
}
