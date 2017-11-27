using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            KortBunke b = new KortBunke();
            b.TilføjKort(new Kort() {Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.VisKort();

            var k = b.FjernKort();
            Console.WriteLine("");
            Console.WriteLine(k);
            Console.WriteLine("");

            b.VisKort();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
