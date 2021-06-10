using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class BookShelf : Aggregate
    {
        private List<Book> books;
        private int last = 0;

        public BookShelf(int maxsize)
        {
            this.books = new List<Book>();
        }
        public Book GetBookAt(int index)
        {
            return books[index];
        }
        public void AppendBook(Book book)
        {
            books.Add(book);
            last++;
        }

        public int Length
        {
            get { return last; }
        }

        public Iterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
