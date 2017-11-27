using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_11_generisk_klasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Personer1 p1 = new Personer1();
            p1.TilFøj(new Instruktør());
            p1.TilFøj(new Kursist());

            Personer2<Person> p2 = new Personer2<Person>();
            p2.Tilføj(new Instruktør());
            p2.Tilføj(new Kursist());
            Personer2<string> p5 = new Personer2<string>();

            Personer3<Person> p3 = new Personer3<Person>();
            p3.TilFøj(new Instruktør());
            p3.TilFøj(new Kursist());
            //Personer3<int> p4 = new Personer3<int>();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
