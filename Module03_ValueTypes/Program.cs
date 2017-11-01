using System;

namespace Module03_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dato = new DateTime(1962,11,7);
            string s1 = "Susanne";
            string s2 = MyMethod(s1);
            string s4 = MyToUpper(s1);
            //string s3 = s1.Clone();
            string MyMethod (string i)
            {
                return i;
            }

            string MyToUpper (string i)
            {
                return i.ToUpper();
            }

            s2 = s2.ToUpper();
            //string s3 = s1.Clone();
            System.Console.Write(s1);
            System.Console.Write(" ");
            System.Console.Write(s2);
            System.Console.Write(" ");
            System.Console.WriteLine(s4);
            System.Console.WriteLine(dato.Date.ToString().Substring(1,10));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
