namespace TemplateMethod.Templates
{
    public abstract class StringTemplate
    {
        public virtual string GetTemplate(string text)
        {
            return $"{EncodeString(GetFirstLine()+text+GetLastLine())}";
        }

        public abstract string GetFirstLine();
        public abstract string EncodeString(string text);
        public abstract string GetLastLine();
    }
}
