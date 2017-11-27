using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_11_generisk_klasse
{
    class Personer1
    {
        private List<Person> personer = new List<Person>();

        public void TilFøj(Person p)
        {
            personer.Add(p);
        }
    }
}
