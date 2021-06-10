using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAdapter
{
    public interface FileIO
    {
        void ReadFromFile(string filename);
        void WriteToFile(string filename);
        void SetValue(string key, string value);
        void GetValue(string key);
    }
}
