using System;
using System.Text;

namespace TemplateMethod.Templates
{
    class SecretDocumentTemplate: StringTemplate
    {
        public override string GetFirstLine()
        {
            return "TOP SECRET\r\n";
        }

        public override string EncodeString(string text)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(plainTextBytes);
        }

        public override string GetLastLine()
        {
            return $"\r\nDate: {DateTime.UtcNow}";
        }

        public string DecodeString(string text)
        {
            var base64EncodedBytes = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
