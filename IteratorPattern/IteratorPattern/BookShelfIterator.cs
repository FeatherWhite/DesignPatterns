using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class BookShelfIterator : Iterator
    {
        private BookShelf bookShelf;
        private int index;
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            this.index = 0;
        }

        public bool HasNext()
        {
            if (index < bookShelf.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Next()
        {
            Book book = bookShelf.GetBookAt(index);
            index++;
            return book;
        }
    }
}
