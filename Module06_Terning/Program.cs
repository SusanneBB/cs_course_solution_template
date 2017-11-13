using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            for (int i = 0; i < 10; i++)
            {
                t1.Ryst();
                t1.Skriv();
            }

            Terning t2 = new Terning(true);
            t2.Skriv();
            for (int i = 0; i < 10; i++)
            {
                t2.Ryst();
                t2.Skriv();
            }

            Terning t3 = new Terning();
            int antal = 150;
            var kast = new int[antal]; 
            for (int i = 0; i < antal; i++)
            {
                t3.Ryst();
                kast[i] = t3.værdi;
            }
            Console.WriteLine("Efter " + antal.ToString() + " kast er snittet " + kast.Average().ToString("N2"));

            Terning t4 = new Terning(true);
            for (int i = 0; i < antal; i++)
            {
                t4.Ryst();
                kast[i] = t4.værdi;
            }
            Console.WriteLine("Efter " + antal.ToString() + " kast er snittet med snyd sjovt nok " + kast.Average().ToString("N2"));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
