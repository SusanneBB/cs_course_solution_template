using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_9._1_Summeringsopgave
{
    class Instruktør : KursusDeltager
    {
        public Instruktør() : base()
        {
            Nøgle = "";
        }

        public Instruktør(string navn, string cprnummer, string nøgle) : base(navn, cprnummer)
        {
            Nøgle = nøgle;
        }

        public string Nøgle { get; set; }

        public override void Skriv()
        {
            Console.WriteLine($"Navn {Navn} med CPR {CprNummer} og nøgle {Nøgle}"); 
        }
    }
}
