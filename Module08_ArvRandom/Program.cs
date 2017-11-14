using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08_ArvRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandmom r = new UdvidetRandmom();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(r.NextBool());

            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
