using System;
using MyLogger = Singleton.Logger;

namespace Singleton
{
    public class Useless
    {
        public static void DoIt()
        {
            var logger = new MyLogger();
            Console.WriteLine("-From UseLess-");
            Console.Write(logger.Read());
            Console.WriteLine("---");
            logger.Write("Log from useless");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var logger = new MyLogger();

            logger.Write("First log");
            logger.Write("Second log");
            Console.Write(logger.Read());
            Console.WriteLine("---");

            Useless.DoIt();

            logger.Write("More logs");
            Console.Write(logger.Read());
        }
    }
}
