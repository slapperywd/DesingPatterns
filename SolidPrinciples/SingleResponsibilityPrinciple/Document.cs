namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    using System;

    public class Document
    {
        public void GoToPage(int pageNumber)
        {
            Console.WriteLine($"You are on the page #{pageNumber}");
        }

        public void PrintDocument(IDocumentPrinter docPrinter)
        {
            docPrinter.Print();
        }
    }
}
