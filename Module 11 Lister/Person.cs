using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11_Lister
{
    class Person
    {
        public Person(int id, string navn)
        {
            Id = id;
            Navn = navn;
        }
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
