using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_classes
{
    class Person2
    {
        public int Fødselsår { get;  private set; }

        public string Fornavn { get; private set; }

        public string Efternavn { get; private set; }

        public void SetFornavn(string fornavn)
        {
            this.Fornavn = fornavn;
        }

        public void SetEfternavn(string efternavn)
        {
            this.Efternavn = efternavn;
        }

        public void SetFødselsår(int år)
        {
            this.Fødselsår = år;
        }

        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }

        public int Alder()        {
            DateTime dd;
            dd = DateTime.Now;
            if (dd.Year >= this.Fødselsår)
            {
                return dd.Year - this.Fødselsår;
            }
            else
            {
                return 0;
            }

        }

    }
}
