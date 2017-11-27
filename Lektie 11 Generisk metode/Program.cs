using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_11_Generisk_metode
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 10;
            int i2 = 25;
            Console.WriteLine($"Før swap   i1={i1} og i2={i2}");
            Swap(ref i1, ref i2);
            Console.WriteLine($"Efter swap i1={i1} og i2={i2}");

            string s1 = "abc";
            string s2 = "def";
            Console.WriteLine($"Før swap   s1={s1} og s2={s2}");
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"Efter swap s1={s1} og s2={s2}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
