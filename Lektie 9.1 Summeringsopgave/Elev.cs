using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_9._1_Summeringsopgave
{
    class Elev : KursusDeltager
    {
        public string ElevId { get; set; }

        public Elev() : base()
        {
            ElevId = "";
        }

        public Elev(string navn, string cprnummer, string elevid) : base(navn, cprnummer)
        {
            ElevId = elevid;
        }

        public override void Skriv()
        {
            Console.WriteLine($"Navn {Navn} med CPR {CprNummer} og ElevId {ElevId}"); ;
        }

    }
}
