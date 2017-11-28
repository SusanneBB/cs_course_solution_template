using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11_Delegates
{
    class Program
    {
        //public delegate int Beregn(int a, int b);
        
        static void Main(string[] args)
        {
            int i = 24;
            int j = 3;
            Console.WriteLine($"{i}+{j} = " + Beregner(i, j, Plus));
            Console.WriteLine($"{i}-{j} = " + Beregner(i, j, Minus));
            Console.WriteLine($"{i}/{j} = " + Beregner(i, j, Divider));
            Console.WriteLine($"{i}*{j} = " + Beregner(i, j, Gange));
            Console.WriteLine($"{i}+({j}*{i}) = " + Beregner(i,j,(x,y) => x+(y*x)));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        public static int Beregner (int i1, int i2, Func<int, int, int> b)
        {
            return b(i1, i2);
        }
        public static int Plus(int i1, int i2)
        {
            return i1 + i2;
        }
        public static int Minus(int i1, int i2)
        {
            return i1 - i2;
        }
        public static int Divider(int i1, int i2)
        {
            if (i2 == 0)
            {
                return 1;
            }
            return i1 / i2;
        }
        public static int Gange(int i1, int i2)
        {
            return i1 * i2;
        }
    }
}
