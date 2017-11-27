using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_7._2_Bæger_og_Terning
{
    class Bæger
    {
        private Terning[] Terninger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < Terninger.Length; i++)
            {
                Terninger[i] = new Terning();
            }
        }

        public void RystBæger()
        {
            for (int i = 0; i < Terninger.Length; i++)
            {
                Terninger[i].værdi = Terninger[i].Ryst();
            }
        }

        public void SkrivBæger()
        {
            for (int i = 0; i < Terninger.Length; i++)
            {
                Terninger[i].Skriv();
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        //private bool FemEns()
        //{

        //}
        //private bool FireEns()
        //{

        //}
        //private bool TreEns()
        //{

        //}
        //private bool Par()
        //{

        //}
        //private bool ToPar()
        //{

        //}
        //private bool Hus()
        //{

        //}
        //private bool Lille()
        //{

        //}
        //private bool Stor()
        //{

        //}
        //private bool Yatzy()
        //{

        //}







    }
}
