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

            int antal = 3;
            Vare[] VareListe = new Vare[antal];

            VareListe[0] = new Vare(50, "Gave");
            VareListe[1] = new Vare(75, "Bøffer");
            VareListe[2] = new Vare(100, "Rødvin");

            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine(VareListe[i].Navn + " koster med moms " + VareListe[i].PrisMedMoms());
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
