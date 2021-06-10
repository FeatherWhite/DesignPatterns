using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class Book
    {
        private string name;
        public Book(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
