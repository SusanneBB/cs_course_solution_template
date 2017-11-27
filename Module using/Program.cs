using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_using
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt");
            //while (stream.Peek() != -1)
            //{
            //    string navn = stream.ReadLine();
            //    Console.WriteLine($"Læster : {navn}");
            //}
            //stream.Close();
            //stream = null;

            using (StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                Console.WriteLine($"Læste dette : {stream.ReadLine()}");
                }
            }
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
