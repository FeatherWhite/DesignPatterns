using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Banner
    {
        private string str;
        public Banner(string str)
        {
            this.str = str;
        }
        public void ShowWithParen()
        {
            Console.WriteLine("(" + str + ")");
        }
        public void ShowWithAster()
        {
            Console.WriteLine("*" + str + "*");
        }
    }
}
