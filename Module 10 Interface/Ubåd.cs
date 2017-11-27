using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_Interface
{
    class Ubåd : IDbFunktioner
    {
        public Ubåd(int nummer, double tubine)
        {
            Nummer = nummer;
            Tubine = tubine;

        }
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine($"Gemmer ubåd {Nummer.ToString()} med turbine {Tubine.ToString()}");
        }
    }
}
