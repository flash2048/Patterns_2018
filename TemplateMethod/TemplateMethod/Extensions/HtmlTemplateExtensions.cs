using System.Web;
using TemplateMethod.Templates;

namespace TemplateMethod.Extensions
{
    public static class HtmlTemplateExtensions
    {
        public static string DecodeString(this HtmlTemplate templace, string text)
        {
            return HttpUtility.HtmlDecode(text);
        }
    }
}
