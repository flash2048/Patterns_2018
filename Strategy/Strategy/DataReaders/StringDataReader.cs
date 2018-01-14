using System;
using System.Linq;
using Strategy.Interfaces;

namespace Strategy.DataReaders
{
    class StringDataReader: IReader
    {
        public string GetValue(string datas)
        {
            if (string.IsNullOrEmpty(datas))
            {
                return String.Empty;
            }
            var dataArray = datas.Trim().Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
            var resultValues = dataArray.Select((x, i) => $"{i+1}: {x}");
            return string.Join("\n", resultValues);

        }
    }
}
