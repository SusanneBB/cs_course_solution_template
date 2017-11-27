using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11_collection
{
    class KortBunke
    {
        private Stack<Kort> Bunke = new Stack<Kort>();

        public void TilføjKort(Kort k)
        {
            Bunke.Push(k);
        }

        public Kort FjernKort()
        {
            return Bunke.Pop();
        }

        public void VisKort()
        {
            foreach (var kort  in Bunke)
            {
                Console.WriteLine(kort.ToString()); 
            }
        }
    }
}
