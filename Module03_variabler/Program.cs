using System;

namespace Module03_variabler
{
    partial class Program
    {

        static void Main(string[] args)
        {
            int heltal = 10;
            System.Console.WriteLine(heltal.ToString());
            heltal++;
            System.Console.WriteLine(heltal.ToString());
            heltal--;
            System.Console.WriteLine(heltal.ToString());
            heltal += 20;
            System.Console.WriteLine(heltal.ToString());

            double kommatal = 12.5;
            System.Console.WriteLine(kommatal.ToString());
            kommatal++;
            System.Console.WriteLine(kommatal.ToString());
            kommatal--;
            System.Console.WriteLine(kommatal.ToString());
            kommatal *= 2;
            System.Console.WriteLine(kommatal.ToString());

            FilTyper ft = FilTyper.csv;
            System.Console.WriteLine(ft);
            System.Console.WriteLine(((int)ft).ToString());

            DateTime dato = DateTime.Now;
            System.Console.WriteLine(dato.ToString("ddMMyy"));
            System.Console.WriteLine(dato.ToString("d"));
            System.Console.WriteLine(dato.ToString("dMy"));
            System.Console.WriteLine(dato.ToLongDateString());
            System.Console.WriteLine(dato.ToString("f"));
            System.Console.WriteLine(dato.ToString("s"));
            System.Console.WriteLine(dato.ToString("dddd d. MMM yyyy"));
            System.Console.WriteLine(dato.ToString("t"));
            System.Console.WriteLine(dato.ToString("T"));

            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";
            System.Console.WriteLine(p.Navn);
            System.Console.WriteLine(p.Id.ToString());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
