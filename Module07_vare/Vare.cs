using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_vare
{
    class Vare
    {
        private string navn;

        public Vare()
        {

        }

        public Vare(int pris, string navn)
        {
            this.Navn = navn;
            this.Pris = pris;

        }
        public string Navn
        {
            get
            {
                Console.WriteLine("Nu læser vi navnet");
                return navn;
            }
            set
            {
                Console.WriteLine("Nu er der nogen der angiver navnet til " + value);
                navn = value; }
        }

        private double pris;

        public double Pris
        {
            get
            {
                Console.WriteLine("Nu er der nogen der læser prisen");
                return pris;
            }
            set
            {
                Console.WriteLine("Nu er der nogen der sætter prisen til " + value.ToString() + "!!");
                pris = value;
            }
        }

        public double PrisMedMoms()
        {
        return this.pris * 1.25;
        }
    }
}
