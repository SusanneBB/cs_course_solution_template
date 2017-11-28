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
        private int[] Counter = new int[6];

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

        public void SorterBærger()
        {
            Array.Sort(Terninger);
        }

        public void TælEns()
        {
            for (int i = 0; i < Counter.Length; i++)
            {
                Counter[i] = 0;
            }

            for (int i = 0; i < Terninger.Length; i++)
            {
                //switch (Terninger[i].værdi)
                //{
                //    case 1: Counter[Terninger[i].værdi] = Counter[Terninger[i].værdi] + 1;
                //    case 2
                //    case 3
                //    case 4
                //    case 5
                //    case 6
                //    default:
                //        break;
                //}
            }
        }
        private bool FemEns()
        {
            for (int i = 1; i < Terninger.Length; i++)
            {
                if (Terninger[i] != Terninger[i-1])
                {
                    return false;
                }
            }
            return true;
        }

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







    }
}
