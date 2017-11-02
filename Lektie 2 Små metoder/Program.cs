using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_2_Små_metoder
{
    class Program
    {





        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine("Mon res = 7? " + res);

            double res2 = BeregnAreal(5);
            Console.WriteLine("Mon det er ca 78.53 ? " + res2);

            Udskriv();
            Udskriv("Dette er en test af min Udskriv");

            double res3 = BeregnMoms(100.35);
            Console.WriteLine("Mon det er ca. 25.09? " + res3);

            double res4 = BeregnMoms(100.35, 25);
            Console.WriteLine("Mon det er ca. 25.09? " + res4);

            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine("Mon det er 15.000 ? " + gns);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
        
        static int LægSammen(int i1, int i2)
        {
            return i1 + i2;
        }

        static double BeregnAreal(int radius)
        {
            return radius * radius * Math.PI;
        }

        static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }

        static void Udskriv()
        {
            Console.WriteLine("");
        }

        static double BeregnMoms(double beløb, double momsPct)
        {
            return (beløb / 100) * momsPct;
        }
        static double BeregnMoms(double beløb)
        {
            return (beløb / 100) * 25;
        }

        static double Gennemsnit(int[] array)
        {
            return array.Average();
        }
    }
}
