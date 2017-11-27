using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] df = new IDbFunktioner[4];
            df[0] = new Hund("Robbie");
            df[1] = new Ubåd(1, 42);
            df[2] = new Hund("Bella");
            df[3] = new Ubåd(2, 84);

            foreach (var item in df)
            {
                item.Gem();
            }
        }
    }
}
