using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektie_11_generisk_klasse
{
    class Personer2<T>
    {
        private List<T> personer2 = new List<T>();

        public void Tilføj (T t)
        {
            personer2.Add(t);
        }
    }
}
