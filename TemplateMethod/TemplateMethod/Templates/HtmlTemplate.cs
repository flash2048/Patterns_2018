using System;
using System.Web;

namespace TemplateMethod.Templates
{
    public class HtmlTemplate: StringTemplate
    {
        private readonly string _htmlPage = "<!DOCTYPE html><html><body >{0}</body></html>";
        private readonly string _title;

        public HtmlTemplate(string title)
        {
            _title = title;
        }

        public override string GetFirstLine()
        {
            return $"<h1>{_title}</h1>\n";
        }

        public override string EncodeString(string text)
        {
            return HttpUtility.HtmlEncode(string.Format(_htmlPage, $"<div>{text}</div>"));
        }

        public override string GetLastLine()
        {
            return $"<p>{DateTime.UtcNow}</p>";
        }
    }
}
