using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_kap_7_Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Værdi = 5;
            Terning t2 = new Terning(4);
            t.Skriv();
            t2.Skriv();
            t.Ryst();
            t2.Ryst();
            t.Skriv();
            t2.Skriv();
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
