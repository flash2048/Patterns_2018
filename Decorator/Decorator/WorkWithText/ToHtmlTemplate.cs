using System;

namespace Decorator.WorkWithText
{
    /// <summary>
    /// It's a concrete decorator - return HTML template
    /// </summary>
    class ToHtmlTemplate : EditOfTextBase
    {
        private readonly string _htmlPage = "<!DOCTYPE html>\n<html>\n<body>\n<div>{0}</div>\n</body>\n</html>";
        public ToHtmlTemplate(EditOfTextBase editOfTextBase = null) : base(editOfTextBase)
        {
        }

        public override string GetFormattedText(string text)
        {
            var lines = base.GetFormattedText(text).Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
            return string.Format(_htmlPage, string.Join("<br/>\n", lines));
        }
    }
}
