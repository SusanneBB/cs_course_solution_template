using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_strenge
{
    class Program
    {
        static void Main(string[] args)
        {

            string fornavn = "Susanne";
            string mellemnavn = "Brogaard";
            string efternavn = "Bondesen";
            string fuldenavn = fornavn + " " + mellemnavn + " " + efternavn;
            Console.WriteLine("Fornavn " + fornavn);
            Console.WriteLine("Mellemnavn " + mellemnavn);
            Console.WriteLine("Efternavn " + efternavn);
            Console.WriteLine("Fulde navn " + fuldenavn);

            string navnStort = fuldenavn.ToUpper();
            string navnLille = fuldenavn.ToLower();

            string initialer = fornavn.Substring(0,1) + mellemnavn.Substring(0,1) + efternavn.Substring(0,1);

            Console.WriteLine("Navn med stort " + navnStort);
            Console.WriteLine("Navn med småt  " + navnLille);
            Console.WriteLine("Initialer " + initialer);

            string[] navneArray = fuldenavn.Split(' ');
            for (int i = 0; i < navneArray.Length; i++)
            {
                Console.WriteLine(navneArray[i]);
            }

            string navnPå3Liner = fornavn + "\r\n" + mellemnavn + "\r\n" + efternavn;
            Console.WriteLine("På 3 linier?? " + navnPå3Liner);

            string navnMedTab = fornavn + "\t" + mellemnavn + "\t" + efternavn;
            Console.WriteLine("Nu med tab?? " + navnMedTab);

            string filIndHold = "Once a upon a time ...";
            string filNavn = @"X:\Eventyr ";
            System.IO.File.WriteAllText(filNavn, filIndHold);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
