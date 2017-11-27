using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Bil b = new Bil();
            b.BilId = 1;
            b.Model = "Toyota";
            b.AntalCylindre = 4;

            Lastbil l = new Lastbil() { BilId = 2, Model = "", AntalCylindre = 7 };

            b.Print();
            l.Print();

            Personbil p = new Personbil() { Model = "Fantastiske Toyota" };
            p.Print();

            Bil[] biler = new Bil[4];
            biler[0] = b;
            biler[1] = l;
            biler[2] = p;
            biler[3] = new Bil(7);
            foreach (var bil in biler)
            {
                bil.Print();
            }

        }
    }
}
