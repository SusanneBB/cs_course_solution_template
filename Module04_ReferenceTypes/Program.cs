namespace Module04_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 2;
            System.Console.WriteLine(i);
            i = MyMethod(ref i);
            int MyMethod (ref int j)
            {
                j = j * j;
                return j;
            }
            System.Console.WriteLine(i);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
