namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    using System;

    public class HtmlDocumentPrinter : IDocumentPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing in HTML format ...");
        }
    }
}
