using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_3_arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sum af 1 og 2 = " + Beregn(1,2));
            Console.WriteLine("Sum af 1,2 og 3 =" + Beregn(1,2,3));
            Console.WriteLine("Sum af 1,2,3 og 4 = " +Beregn(1,2,3,4));
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        static int Beregn (int a, int b)
			{
            return a+b;
            }
        static int Beregn (int a, int b, int c)
			{
            return a+b+c;
            }
        static int Beregn (int a, int b, int c, int d)
			{
            //return a+b+c+d;
            //return (Beregn(a, Beregn(b, Beregn(c, d))));
            return Beregn(a, b) + Beregn(c, d);
        }
    }
}
