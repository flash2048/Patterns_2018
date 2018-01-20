using System;
using System.Text;

namespace Singleton
{
    sealed class LoggerNestedClass
    {
        private readonly StringBuilder _stringlogs;

        public LoggerNestedClass()
        {
        }

        private LoggerNestedClass(string logs)
        {
            _stringlogs = new StringBuilder(logs);
        }

        private static LoggerNestedClass Instance
        {
            get { return InstanceHolder.Instance; }
        }
        
        public  void Write(string log)
        {
            Instance._stringlogs.AppendLine(log);
        }

        public  string Read()
        {
            return Instance._stringlogs.ToString();
        }

        private class InstanceHolder
        {
            static InstanceHolder() { }
            internal static readonly LoggerNestedClass Instance = new LoggerNestedClass(String.Empty);
        }
    }
}
