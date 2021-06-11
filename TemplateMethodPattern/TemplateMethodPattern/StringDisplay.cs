using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class StringDisplay : AbstractDisplay
    {
        private string str;
        private int width;
        public StringDisplay(string str)
        {
            this.str = str;
            this.width = Encoding.UTF8.GetBytes(str).Length;
        }
        public override void Close()
        {
            PrintLine();
            Console.WriteLine();
        }

        public override void Open()
        {
            PrintLine();
            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine("|" + str + "|");
        }
        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }
    }
}
