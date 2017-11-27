using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_compare_2
{
    class HundAlderCompare : IComparer

    {
        public int Compare(object hund1, object hund2)
        {
            Hund h1 = hund1 as Hund;
            Hund h2 = hund2 as Hund;
            return h1.Alder - h2.Alder;
        }
    }
}
