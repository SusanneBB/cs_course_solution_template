using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_arrays
{
    class Program
    {



        static void Main(string[] args)
        {


            int[] månedsløn = { 1000, 2000, 3000, 4000, 1000, 2000, 3000, 4000, 1000, 2000, 3000, 4000 };
            double gns;
            gns = månedsløn.Average();
            for (int i = 0; i < månedsløn.Length; i++)
            {
                System.Console.WriteLine(månedsløn[i].ToString("n2"));
            }
            System.Console.Write("Gennemsnit ");
            System.Console.WriteLine(gns.ToString("n2"));

            int min = månedsløn.Min();
            int max = månedsløn.Max();

            System.Console.Write("Min ");
            System.Console.WriteLine(min.ToString("n2"));
            System.Console.Write("Max ");
            System.Console.WriteLine(max.ToString("n2"));

            System.Console.WriteLine("Så er der sorteret!");

            for (int j = 0; j < månedsløn.Length; j++)
            {

                for (int i = (månedsløn.Length - 1); i > 0; i--)
                {
                    if (månedsløn[i] < månedsløn[i - 1])
                    {
                        int temp = månedsløn[i - 1];
                        månedsløn[i - 1] = månedsløn[i];
                        månedsløn[i] = temp;
                    }
                }
            }

            for (int i = 0; i < månedsløn.Length; i++)
            {
                System.Console.WriteLine(månedsløn[i].ToString("n2"));
            }

            UdskrivArray(månedsløn, månedsløn.Length);

             var res = månedsløn.Where(i => i> 0).OrderBy(i => 1) ;
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

            void UdskrivArray (int [] array, int længde)
            {
                for (int i = 0; i < længde; i++)
                {
                    System.Console.WriteLine(array[i].ToString("n2"));
                }    

            }
        }
    }
}
