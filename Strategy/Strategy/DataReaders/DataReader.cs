using Strategy.Interfaces;

namespace Strategy.DataReaders
{
    class DataReader
    {
        public string GetValue(IReader reader, string datas)
        {
            return reader.GetValue(datas);
        }
    }
}
