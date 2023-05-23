using ConsoleApp5.Models;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book = new Book("Qala");
            Book book1 = new Book("Sefiller");
            Book book2 = new Book("Dirilis");
            library.Addbook(book);
            library.Addbook(book1);
            library.Addbook(book2);
            book.ShowInfo();
  



           

        }
    }
}