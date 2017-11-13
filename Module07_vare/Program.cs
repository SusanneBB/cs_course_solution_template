using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_vare
{
    class Program
    {
        static void Main(string[] args)
        {

            Vare v1 = new Vare();
            v1.Navn = "Rugbrød";
            v1.Pris = 20;
            Vare v2 = new Vare(20, "hus forbi");
            Console.WriteLine(v1.Navn + " med moms koster " + v1.PrisMedMoms());
            Console.WriteLine(v2.Navn + " med moms koster " + v2.PrisMedMoms());
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
