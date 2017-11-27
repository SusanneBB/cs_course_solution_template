using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_compare_2
{
    class Hund
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund h1 = this;
            Hund h2 = obj as Hund;
            return h1.Alder - h2.Alder;        }
    }
}
