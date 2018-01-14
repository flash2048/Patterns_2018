using System;
using Strategy.DataReaders;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new DataReader();
            Console.WriteLine(dataReader.GetValue(new StringDataReader(), "Просто строка\nВторая строка\nЭто третья строка"));
            Console.WriteLine("---");
            Console.WriteLine(dataReader.GetValue(new FileDataReader(), @"C:\Temp\file.txt"));
        }
    }
}
