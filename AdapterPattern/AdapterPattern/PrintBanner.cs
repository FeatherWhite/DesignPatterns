using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class PrintBanner:Banner,Print
    {
        public PrintBanner(string str):base(str)
        {
        }

        public void PrintStrong()
        {
            ShowWithAster();
        }

        public void PrintWeak()
        {
            ShowWithParen();
        }
    }
}
