using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileIO f = new FileProperties();
            try
            {
                f.ReadFromFile("file.txt");
                f.SetValue("year", "2004");
                f.SetValue("month", "4");
                f.SetValue("day", "21");
                f.WriteToFile("newfile.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
