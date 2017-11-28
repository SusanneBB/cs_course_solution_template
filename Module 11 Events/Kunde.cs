using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11_Events
{
    class Kunde
    {
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax  {get; set; }

        public event EventHandler KreditOverskredet;

        public void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
            {
                KreditOverskredet(this, new EventArgs());
            }
        }

        public void Indsæt(int værdi)
        {
            this.Saldo += værdi;
        }
    }
}
