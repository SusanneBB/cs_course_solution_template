using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_9._1_Summeringsopgave
{
    abstract class Person
    {
        protected Person()
        {
            navn = "";
            CprNummer = "";
        }

        protected Person(string navn, string cprnummer)
        {
            this.navn = navn;
            CprNummer = cprnummer;
        }

        private string Navn;

        public string navn
        {
            get { return Navn; }
            set { Navn = value; }
        }

        protected string CprNummer;

        public virtual void Skriv()
        {
            Console.WriteLine($"Navn: [{Navn}] med CPR [{CprNummer}]");
        }

        static bool CprOK(string cpr)
        {
            bool KunTalOgBindestreg = true;

            for (int i = 0; i < cpr.Length; i++)
            {
                if (cpr[i] == '0' || cpr[i] == '1' || cpr[i] == '2' || cpr[i] == '3' || cpr[i] == '4' || cpr[i] == '5' ||
                    cpr[i] == '6' || cpr[i] == '7' || cpr[i] == '8' || cpr[i] == '9' || cpr[i] == '-') 
                {
                }
                else
                {
                    KunTalOgBindestreg = false;
                }
            }
            return (cpr.Length == 11 && cpr[6] == '-' && KunTalOgBindestreg);
        }
    }
}
