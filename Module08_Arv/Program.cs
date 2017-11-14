using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Susanne Brogaard";
            p1.Efternavn = "Bondesen";
            Console.WriteLine(p1.FuldtNavn());

            Elev e1 = new Elev();
            e1.Fornavn = "Nina Brogaard";
            e1.Efternavn = "Pedersen";
            e1.Klasselokale = "10";
            Console.WriteLine(e1.FuldtNavn());
            Console.WriteLine(e1.Klasselokale);

            Instruktør i1 = new Instruktør();
            i1.Fornavn = "Sofia Brogaard";
            i1.Efternavn = "Pedersen";
            i1.NøgleId = 42;
            Console.WriteLine(i1.FuldtNavn());
            Console.WriteLine(i1.NøgleId.ToString());
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
