using System;

namespace SOFTWAREREFACTORING
{
    internal class Previewer
    {
        internal bool preview(Document document) 
        {
            Console.WriteLine("Document Previewed of type {0}", document.GetType());
            return true;
        }
    }
}