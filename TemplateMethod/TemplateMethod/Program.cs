using System;
using TemplateMethod.Extensions;
using TemplateMethod.Templates;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var htmlTemplate = new HtmlTemplate("New article");
            var result = htmlTemplate.GetTemplate("This is the page with new C# article");
            Console.WriteLine(result);
            Console.WriteLine("---");
            Console.WriteLine(htmlTemplate.DecodeString(result));

            //var secretTemplate = new SecretDocumentTemplate();
            //var result = secretTemplate.GetTemplate("This is a template of secret document");
            //Console.WriteLine(result);
            //Console.WriteLine("---");
            //Console.WriteLine(secretTemplate.DecodeString(result));

        }
    }
}
