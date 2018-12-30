using System;

namespace SOFTWAREREFACTORING
{
    class Program
    {
        static void Main(string[] args)
        {
            PDFDoc pdf = new PDFDoc();
            pdf.Print();
            pdf.Preview();

            Console.ReadLine(); 
        }
    }
}