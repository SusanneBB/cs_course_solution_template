﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08_PolymorfiDyr
{
    class Hund : Dyr
    {
        public Hund(string navn)
        {
            this.Navn = navn;
        }
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en hund og hedder {Navn}"); ;
        }
    }
}
