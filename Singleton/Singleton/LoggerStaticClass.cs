using System.Text;

namespace Singleton
{
    static class LoggerStaticClass
    {
        private static readonly StringBuilder Stringlogs = new StringBuilder();

        public static  void Write(string logs)
        {
            Stringlogs.AppendLine(logs);
        }

        public static  string Read()
        {
            return Stringlogs.ToString();
        }
    }
}
