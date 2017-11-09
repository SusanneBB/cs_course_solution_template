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

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
        
        static int BeregnOgSoterArray(int [] array)
        {
			array = SorterArray(array);
            return array.Average;
        }

        static int [] SorterArray (int [] array)
		{
			for (int i = array.Length; i > 0; i--)
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
        }
    }
}
