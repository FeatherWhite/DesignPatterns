using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAdapter
{
    public class MyPath
    {
        public string GetCurrentPath()
        {
            return Environment.CurrentDirectory;
        }
    }
}
