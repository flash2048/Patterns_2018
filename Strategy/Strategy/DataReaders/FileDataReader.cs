using System;
using System.IO;
using System.Linq;
using Strategy.Interfaces;

namespace Strategy.DataReaders
{
    class FileDataReader: IReader
    {
        public string GetValue(string datas)
        {
            if (string.IsNullOrEmpty(datas))
            {
                return String.Empty;
            }

            using (var fileReader = new StreamReader(datas))
            {
                var dataArray = fileReader.ReadToEnd().Trim().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var resultValues = dataArray.Select((x, i) => $"{i + 1}: {x}");
                return string.Join("\n", resultValues);
            }
        }
    }
}
