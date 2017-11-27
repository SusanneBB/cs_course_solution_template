using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11_Lister
{
    class Program
    {
        static void Main(string[] args)
        {
            List< Person> familie = new List<Person>();
            familie.Add(new Person(1, "Susanne"));
            familie.Add(new Person(2, "Torben"));
            familie.Add(new Person(3, "Nina"));
            familie.Add(new Person(4, "Sofia"));
            Console.WriteLine("SOM LISTE");
            foreach (var f in familie)
            {
                Console.WriteLine($"Her er familie medlemd {f.Navn} med id {f.Id}");
            }
            Console.WriteLine("");

            Console.WriteLine("SOM DICTIONARY");
            Dictionary<int, Person> familie2 = new Dictionary<int, Person>();
            familie2.Add(5, new Person(55, "Mor"));
            familie2.Add(6, new Person(66, "Far"));
            familie2.Add(7, new Person(77, "Søster"));
            foreach (var f2 in familie2)
            {
                Console.WriteLine($"Her familie2 medlem {f2.Value.Navn} med id {f2.Value.Id} og nøgle {f2.Key.ToString()}");
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
