namespace Decorator.WorkWithText
{
    /// <summary>
    /// It's a decorator - return text without changes
    /// </summary>
    public abstract class EditOfTextBase
    {
        private readonly EditOfTextBase _editOfTextBase;

        protected EditOfTextBase(EditOfTextBase editOfTextBase = null)
        {
            _editOfTextBase = editOfTextBase;
        }

        public virtual string GetFormattedText(string text)
        {
            if (_editOfTextBase != null)
            {
                text = _editOfTextBase.GetFormattedText(text);
            }
            return text;
        }
    }
}
