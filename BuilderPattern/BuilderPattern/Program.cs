using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Environment.Exit(0);
            }
            if (args[0].Equals("plain"))
            {
                TextBuilder textBuilder = new TextBuilder();
                Director director = new Director(textBuilder);
                director.Construct();
                string result = textBuilder.GetResult();
                Console.WriteLine(result);
            }
            else if (args[0].Equals("html"))
            {
                HTMLBuilder htmlBuilder = new HTMLBuilder();
                Director director = new Director(htmlBuilder);
                director.Construct();
                string filename = htmlBuilder.GetResult();
                Console.WriteLine(filename + "文件编写完成。");
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
