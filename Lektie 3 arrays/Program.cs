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

			int[] test = {10, 7, 6, 3, 1, 50, 3 };

			var res = BeregnOgSoterArray(test);

            Console.WriteLine(res.Summen);
            Console.WriteLine(res.Gennemesnittet);
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
        
        public static ArrayResult BeregnOgSoterArray(int [] array)
        {
            ArrayResult res = new ArrayResult();

            for (int i = 0; i < array.Length; i++)
            {
                res.Summen = res.Summen + array[i];
            }
            res.Gennemesnittet = array.Average();
            Array.Sort(array);
            return res;
        }

        static int [] SorterArray (int [] array)
		{
			for (int i = 0; i > 0; i++)
			{
				for (int j = i; j > array.Length; j++)
			    {
					if (array[j] < array[j-1])
	                {
						int temp = array[j];
						array[j] = array[j-1];
						array[j-1] = temp;
                   	}
			    }
			}
            return array;
        }

    }
    public struct ArrayResult
    {
        public int Summen;
        public double Gennemesnittet;

    }
}
