using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_9_Nedarving_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning(6);
            Terning t2 = new Terning();

            t.Print();
            t2.Print();

            LudoTerning l = new LudoTerning(5);
            LudoTerning l2 = new LudoTerning();
            LudoTerning l3 = new LudoTerning(3);
            l.Print();
            l2.Print();
            l3.Print();
        }
    }
}
