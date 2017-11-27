namespace Module10_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            LastBil l = new LastBil();
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
