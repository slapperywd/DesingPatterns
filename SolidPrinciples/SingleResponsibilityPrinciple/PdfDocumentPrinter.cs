namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    using System;

    public class PdfDocumentPrinter : IDocumentPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing in PDF format ...");
        }
    }
}
