using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_9._1_Summeringsopgave
{
    class KursusDeltager : Person
    {
        protected KursusDeltager() : base()
        { }

        public KursusDeltager(string navn, string cprnummer) : base(navn, cprnummer)
        { }
    }
}
