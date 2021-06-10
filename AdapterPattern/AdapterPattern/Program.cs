using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Print p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();
        }
    }
}
