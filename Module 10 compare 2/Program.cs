using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_compare_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[3];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bella" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Robbie" };
            hunde[2] = new Hund() { Alder = 7, Navn = "Fido" };
            Array.Sort(hunde, new HundAlderCompare());
            Console.WriteLine("Sorteret efter alder");
            foreach (var hund in hunde)
            {
                Console.WriteLine($"Her er hunden {hund.Navn} som er {hund.Alder.ToString()} år gammel");
            }

            Array.Sort(hunde, new HundNavnCompare());
            Console.WriteLine("Sorteret efter navn");
            foreach (var hund in hunde)
            {
                Console.WriteLine($"Her er hunden {hund.Navn} som er {hund.Alder.ToString()} år gammel");
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
