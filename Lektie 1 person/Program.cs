using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_1_person
{
    class Program
    {
        class Person
        {
            public string navn;

        }

        static void Main(string[] args)
        {

            Person p1 = new Person();
            Person p2 = new Person();

            p1.navn = "A";
            p2.navn = "B";

            System.Console.WriteLine(p1.navn);
            System.Console.WriteLine(p2.navn);

            p1 = p2;
            System.Console.WriteLine("efter assignment 1");
            System.Console.WriteLine(p1.navn);
            System.Console.WriteLine(p2.navn);

            p1.navn = "C";
            System.Console.WriteLine("efter assignment 2");
            System.Console.WriteLine(p1.navn);
            System.Console.WriteLine(p2.navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
