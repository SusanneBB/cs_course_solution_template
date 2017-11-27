using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_11_generisk_klasse
{
    class Personer3<T> where T : Person
    {
        private List<T> personer3 = new List<T>();

        public void TilFøj(T t)
        {
            personer3.Add(t);
        }
    }
}
