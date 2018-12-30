namespace SOFTWAREREFACTORING
{
    public class ASCIIDoc : Document
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
