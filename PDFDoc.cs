namespace SOFTWAREREFACTORING
{
    public class PDFDoc : Document
    {
        public bool Preview()
        {
            return PreviewDocument();   
        }

        public bool Print()
        {
            return PrintDocument();
        }
    }
}
