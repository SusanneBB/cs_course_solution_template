using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul02_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Indtast navn");
            var inName = System.Console.ReadLine();
            System.Console.Write("Velkommen ");
            if (inName == "Nina")

            {
                System.Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            else
            {
                System.Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            System.Console.WriteLine(inName.ToUpper());
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine();
            System.Console.WriteLine("Tryk en tast for at fortsætte");
            System.Console.ReadKey();
        }
    }
}

