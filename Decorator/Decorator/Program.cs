using System;
using Decorator.WorkWithText;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Hello!\n This article is about the pattern \"Decorator\"";

            var editText = new ToHtmlTemplate(new ToBase64(new ToUpperText(new ReplaceSpacesWithLog())));

            Console.WriteLine(editText.GetFormattedText(text));
        }
    }
}
