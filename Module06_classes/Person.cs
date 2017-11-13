using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_classes
{
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

    public Person()
    {
            this.Fornavn = "";
            this.Efternavn = "";
    }

        public Person(string fornavn, string efternavn, int fødselsår)
        {
            Fornavn = fornavn.ToUpper();
            Efternavn = efternavn.ToUpper();
            Fødselsår = fødselsår;
        }
    public string FuldtNavn(Person p)
        {
            return p.Fornavn + " " + p.Efternavn;
        }

    public int Alder(Person p)
        {
            DateTime dd;
            dd = DateTime.Now;
            if (dd.Year >= p.Fødselsår)
            {
                return dd.Year - p.Fødselsår;
            }
            else
            {
                return 0;
            }

        }
    }

}
