using System;

namespace SOFTWAREREFACTORING
{
    class Program
    {
        static void Main(string[] args)
        {
            Document pdf = new PDFDoc();

            pdf.PrintDocument();
            pdf.PreviewDocument();

            Console.ReadLine(); 
        }
    }
}