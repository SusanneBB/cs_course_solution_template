using System;

namespace BilApp
{
    partial class Program
    {
        public class Bil
        {
            public Bil(int bilid)
            {
                this.BilId = bilid;
            }

            public Bil()
            {

            }

            //public int BilId;
            public int BilId { get; set; }
            public string Model { get; set; }
            //public int AntalCylindre { get; set; }
            private int antalCylindre;

            public int AntalCylindre
            {
                get { return antalCylindre; }
                set
                {
                    if (value < 4 || value > 8)
                    {
                        throw new ApplicationException("Forkert antal cylindre!");
                        //    value = 4;
                    }
                    antalCylindre = value;
                }
            }

            public virtual void Print()
            {
                Console.WriteLine("Bil : " + this.Model.ToString());
            }
        }

    }
}
