using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_9._1_Summeringsopgave
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            KursusDeltager k = new KursusDeltager("Susanne", "071162-1830");
            k.Skriv();
            if (KursusDeltager.CprOK(k.CprNummer))
            {
                Console.WriteLine($"Cpr nummer {k.CprNummer} er OK");
            }
            else
        	{
                Console.WriteLine($"Cpr nummer {k.CprNummer} er ikke OK");
            }

            Instruktør i = new Instruktør("Michel", "xxxxxx-xxxx", "Nøgle");
            i.Skriv();
            if (Instruktør.CprOK (i.CprNummer))
            {
                Console.WriteLine($"Cpr nummer {i.CprNummer} er OK");
            }
            else
            {
                Console.WriteLine($"Cpr nummer {i.CprNummer} er ikke OK");
            }

            Elev e = new Elev("Mig selv", "yyyyyy-yyyy", "42");
            e.Skriv();
            if (Elev.CprOK(e.CprNummer))
            {
                Console.WriteLine($"Cpr nummer {e.CprNummer} er OK");
            }
            else
            {
                Console.WriteLine($"Cpr nummer {e.CprNummer} er ikke OK");
            }

            Person[] pa = new Person[3];
            pa[0] = new KursusDeltager("Susanne", "123456-7890");
            pa[1] = new Instruktør("Michel", "234567-8901", "Key");
            pa[2] = new Elev("Hr Hansen", "456789-0123", "42");
            for (int j   = 0; j < pa.Length; j++)
            {
                pa[j].Skriv();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
