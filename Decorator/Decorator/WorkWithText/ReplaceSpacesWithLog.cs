using System;

namespace Decorator.WorkWithText
{
    /// <summary>
    /// It's a concrete decorator - replace all ' ' to '+'
    /// </summary>
    class ReplaceSpacesWithLog : EditOfTextBase
    {
        public ReplaceSpacesWithLog(EditOfTextBase editOfTextBase = null) : base(editOfTextBase)
        {
        }

        public override string GetFormattedText(string text)
        {
            Console.WriteLine($"All ' ' will replace to '+'");
            return base.GetFormattedText(text)?.Replace(' ', '+');
        }
    }
}
