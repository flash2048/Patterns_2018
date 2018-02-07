namespace Decorator.WorkWithText
{
    /// <summary>
    /// It's a concrete decorator - return upper text
    /// </summary>
    class ToUpperText : EditOfTextBase
    {
        public ToUpperText(EditOfTextBase editOfTextBase = null) : base(editOfTextBase)
        {
        }

        public override string GetFormattedText(string text)
        {
            return base.GetFormattedText(text)?.ToUpper();
        }
    }
}
