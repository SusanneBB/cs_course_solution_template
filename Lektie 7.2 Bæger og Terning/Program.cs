using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_7._2_Bæger_og_Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Bæger b = new Bæger();
            b.SkrivBæger();
            b.RystBæger();
            b.SkrivBæger();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
