using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.AppendBook(new Book("环游世界80天"));
            bookShelf.AppendBook(new Book("杀死比尔"));
            bookShelf.AppendBook(new Book("Cinderella"));
            bookShelf.AppendBook(new Book("Daddy-Long-Legs"));
            Iterator it = bookShelf.Iterator();
            while (it.HasNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.Name);
            }
            Console.ReadLine();
        }
    }
}
