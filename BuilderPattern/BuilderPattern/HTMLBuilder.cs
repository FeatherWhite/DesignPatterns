using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class HTMLBuilder : Builder
    {
        private string fileName;
        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void MakeItems(string[] items)
        {
            throw new NotImplementedException();
        }

        public override void MakeString(string str)
        {
            throw new NotImplementedException();
        }

        public override void MakeTitle(string title)
        {
            throw new NotImplementedException();
        }
        public string GetResult()
        {
            return fileName;
        }
    }
}
