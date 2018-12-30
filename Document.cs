namespace SOFTWAREREFACTORING
{
    public class Document  
    {
        public bool PrintDocument()
        {
            return new Printer().PrintDocument(this);
        }

        public bool PreviewDocument()
        {
            return new Previewer().PreviewDocument(this);
        }

    }
}
