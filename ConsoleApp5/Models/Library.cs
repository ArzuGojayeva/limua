namespace ConsoleApp5.Models
{
    internal class Library
    {
        List<Book> books = new List<Book>();
        public void Addbook(Book book)
        {
            books.Add(book);
        }
        public void FindAllBooksbyName(Book book)
        {
            foreach (Book books in books)
            {
                if (book.Name.Equals(books))
                {
                    Console.WriteLine(books.Name);
                }

            }
        }
        public void RemoveAllBooksByCode(string code)
        {
            for(int i=0;i<books.Count;i++)
            {
                if (books[i].Code == code)
                {
                    books.RemoveAt(i);
                }
            }
            
        }
        public void SearchBook(string name) {
            foreach (var books in books) {
                if (books.Name.Contains(name) || books.AuthorName.Contains(name)) {
                    Console.WriteLine(books.Name);
                }
            }
        }
     public void FindAllBooksbyPageCountRange(int max, int min) { 
            foreach(var books in books)
            {
                if(books.PageCount>min &&books.PageCount<max) {
                Console.WriteLine(books.PageCount);}
            }
        }
        public void FindBookByCode(string code)
        {
            foreach (var books in books)
            {
                if (books.Code.Equals(code)){
                    Console.WriteLine(books.Code);
                }
            }
        }
    }

 }



 
