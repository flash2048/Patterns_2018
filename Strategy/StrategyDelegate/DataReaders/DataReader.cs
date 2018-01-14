using System;
namespace StrategyDelegate.DataReaders
{
    class DataReader
    {
        public string GetValue(Func<string, string> dataReader, string datas)
        {
            return dataReader.Invoke(datas);
        }
    }
}
