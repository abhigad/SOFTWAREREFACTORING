using System;

namespace SOFTWAREREFACTORING
{
    internal class Printer
    {
        internal bool PrintDocument(Document document)
        {
            Console.WriteLine("Document Printed of type {0}", document.GetType());
            return true;
        }
    }
}