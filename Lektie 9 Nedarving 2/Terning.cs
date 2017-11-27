﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_9_Nedarving_2
{
    class Terning
    {
        public Terning()
        {
            værdi = Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

        private static Random rnd = new Random();
        private int værdi;

       public int Værdi
        {
            get { return værdi; }
            set
            {
                if (value > 0 & value < 7)
                {
                    værdi = value;
                }
                else
                {
                    værdi = 1;
                }
            }
        }

        public int Ryst()
        {
            return rnd.Next(1, 7);
        }

        public void Print()
        {
            Console.WriteLine($"[{Værdi}]");
        }
    }
}
