using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_Interface
{
    class Hund : IDbFunktioner
    {
        public Hund(string navn)
        {
            Navn = navn;
        }
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine($"Gemmer hunden {Navn}"); ;
        }
    }
}
