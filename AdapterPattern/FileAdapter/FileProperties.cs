using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAdapter
{
    public class FileProperties : FileIO
    {
        string path = 
            @"D:\Project\DesignPatterns\AdapterPattern\FileAdapter\bin\Debug";
        public void GetValue(string key)
        {
            throw new NotImplementedException();
        }

        public void ReadFromFile(string filename)
        {
            throw new NotImplementedException();
        }

        public void SetValue(string key, string value)
        {
            throw new NotImplementedException();
        }

        public void WriteToFile(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
