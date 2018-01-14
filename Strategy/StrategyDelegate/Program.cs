using System;
using StrategyDelegate.DataReaders;

namespace StrategyDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new DataReader();

            Console.WriteLine(dataReader.GetValue(StringDataReader.GetValue, "Первая строка\nВторая строка\nЭто третья строка"));
            Console.WriteLine("---");
            Console.WriteLine(dataReader.GetValue(FileDataReader.GetValue, @"C:\Temp\file.txt"));
        }
    }
}
