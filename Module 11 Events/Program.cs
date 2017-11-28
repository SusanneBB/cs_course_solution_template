using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { Navn = "Susanne", KreditMax = -500 };
            k.KreditOverskredet += (s, e) => { Console.WriteLine($"Krediten er overskredet for { (s as Kunde).Navn}");};
            k.Køb(100);
            Console.WriteLine("Saldo er nu " + k.Saldo.ToString());
            k.Køb(401);
            Console.WriteLine("Saldo er nu " + k.Saldo.ToString());
            k.Indsæt(100);
            Console.WriteLine("Saldo er nu " + k.Saldo.ToString());
            k.Køb(95);
            Console.WriteLine("Saldo er nu " + k.Saldo.ToString());
            k.Køb(10);
            Console.WriteLine("Saldo er nu " + k.Saldo.ToString());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
