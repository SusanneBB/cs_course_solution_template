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

            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);

            int j = rnd.Next(1, 21);
            if (j % 2 == 0)
            {
                dyr = new Hund(navne[j]);
            }
            else
	        {
                dyr = new Kat(navne[j]);
            }
            return dyr;
        }
    }
}
