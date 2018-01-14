using System;
using System.IO;
using System.Linq;

namespace StrategyDelegate.DataReaders
{
    class FileDataReader
    {
        public static string GetValue(string datas)
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
