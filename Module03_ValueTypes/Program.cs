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
            Console.WriteLine("mon det virker" + "??");

            DayOfWeek wd = DayOfWeek.Friday;
            switch (wd)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }

            //@ foran string ignore escape char
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
