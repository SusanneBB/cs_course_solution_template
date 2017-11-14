using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LektieModule10_NLog
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Debug("Jeg kalder nu test1");
            test1(5, 5);
            logger.Debug("Jeg kalder nu test2");
            test2();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        static void test1(int i, int x)
        {
            logger.Trace("Nu starter test1");
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
            logger.Trace("Nu er test1 færdig");
        }

        static void test2()
        {
            logger.Trace("Nu starter test2");
            try
            {
                Console.WriteLine("test2");
                logger.Error("Her gik det galt - fæøre!");
                throw new ApplicationException("fejl");
            }
            catch (Exception)
            {
                logger.Error("Her gik det også galt - tsk tsk");
            }
            logger.Trace("Nu er test2 færdig");
        }
    }
}
