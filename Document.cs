using System;
using System.Collections.Generic;
using System.Text;

namespace SOFTWAREREFACTORING
{
    public class Document
    {
        public bool print()
        {
            return new Printer().print(this);
        }

        public bool preview()
        {
            return new Previewer().preview(this);
        }
    }
}
