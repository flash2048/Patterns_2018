using System;
using System.Text;

namespace Singleton
{
    sealed class Logger
    {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger(String.Empty));
        private readonly StringBuilder _stringlogs;

        public Logger()
        {
        }

        private Logger(String text)
        {
            _stringlogs = new StringBuilder(text);
        }

        private static Logger Instance => _instance.Value;

        public  void Write(string logs)
        {
            Instance._stringlogs.AppendLine(logs);
        }

        public  string Read()
        {
            return Instance._stringlogs.ToString();
        }
    }
}
