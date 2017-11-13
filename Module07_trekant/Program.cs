using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_trekant
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t1 = new Trekant(1, 1);
            Console.WriteLine("Areal burde være 1/2 = " + t1.Areal.ToString("N2"));

            Trekant t2 = new Trekant(2, 2);
            Console.WriteLine("Areal burde være 2 = " + t2.Areal.ToString("N2"));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
