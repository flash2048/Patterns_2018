using System;
using System.Text;

namespace Decorator.WorkWithText
{
    /// <summary>
    /// It's a concrete decorator - return base64
    /// </summary>
    class ToBase64 : EditOfTextBase
    {
        public ToBase64(EditOfTextBase editOfTextBase = null) : base(editOfTextBase)
        {
        }

        public override string GetFormattedText(string text)
        {
            var textBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(textBytes);
        }
    }
}
