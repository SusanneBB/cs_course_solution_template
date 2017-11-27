using System;

namespace BilApp
{
    partial class Program
    {
        public class Personbil : Bil
        {
            public int AntalBarneSæder { get; set; }

            public override void Print()
            {
                Console.WriteLine("Personbil : " + this.Model); ;
            }
        }

    }
}
