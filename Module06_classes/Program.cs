using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_classes
{
    class Program
    {
        static void Main(string[] args)
        {

            var MigSelv = new Person("Susanne Brogaard", "Bondesen", 1962);
            Console.WriteLine("Navn " + MigSelv.FuldtNavn(MigSelv));
            Console.WriteLine("Alder ca. " + MigSelv.Alder(MigSelv).ToString());

            var Nina = new Person();
            Nina.Fornavn = "Nina Brogaard";
            Nina.Efternavn = "Pedersen";
            Nina.Fødselsår = 1995;
            Console.WriteLine("Navn " + Nina.FuldtNavn(Nina));
            Console.WriteLine("Alder ca. " + Nina.Alder(Nina).ToString());

            var Sofia = new Person2();
            Sofia.SetEfternavn("Pedersen");
            Sofia.SetFornavn("Sofia Brogaard");
            Sofia.SetFødselsår(1997);
            Console.WriteLine("Navn " + Sofia.FuldtNavn());
            Console.WriteLine("Alder ca. " + Sofia.Alder().ToString());


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
