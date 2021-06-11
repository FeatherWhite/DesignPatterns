﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello,world");
            AbstractDisplay d3 = new StringDisplay("你好，世界");
            d1.Display();
            d2.Display();
            d3.Display();
            Console.ReadLine();
        }
    }
}
