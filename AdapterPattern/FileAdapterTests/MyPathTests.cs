using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAdapter.Tests
{
    [TestClass()]
    public class MyPathTests
    {
        [TestMethod()]
        public void GetCurrentPathTest()
        {
            MyPath myPath = new MyPath();
            string currentPath = myPath.GetCurrentPath();
            Console.WriteLine(currentPath);
        }
    }
}