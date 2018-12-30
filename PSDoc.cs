namespace SOFTWAREREFACTORING
{
    public class PSDoc : Document
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
