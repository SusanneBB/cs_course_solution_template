using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[3];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bella"};
            hunde[1] = new Hund() { Alder = 5, Navn = "Robbie"};
            hunde[2] = new Hund() { Alder = 7, Navn = "Fido" };
            Array.Sort(hunde);
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

        class Hund : IComparable
        {
            public string Navn { get; set; }
            public int Alder { get; set; }
            public int CompareTo(object obj)
            {
                Hund h1 = this;
                Hund h2 = obj as Hund;
                //if (h1.Alder > h2.Alder)
                //{
                //    return 1;
                //}
                //if (h1.Alder < h2.Alder)
                //{
                //    return -1;
                //}
                //return 0;
                return h1.Alder - h2.Alder;
            }
        }
    }
}
