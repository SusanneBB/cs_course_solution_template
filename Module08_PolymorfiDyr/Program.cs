﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08_PolymorfiDyr
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] ListeAfDyr = new Dyr[20];

            for (int i = 0; i < 20; i++)
            {
                ListeAfDyr[i] = Dyr.TilfældigtDyr();
            }

            for (int i = 0; i < 20; i++)
            {
                ListeAfDyr[i].SigNoget();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
