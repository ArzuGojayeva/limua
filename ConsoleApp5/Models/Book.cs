using System.Text;

namespace ConsoleApp5.Models
{
    internal class Book
    {
        private string _name;
        private string _authorname;
        private int _pagecount;
        public string Code;
        public static int codecount = 0;
        public string Name { get { return _name; } set { if (value.Length > 2) { _name = value; } } }
        public string AuthorName { get { return _authorname; } set { if (value.Length > 3) { _authorname = value; } } }
        public int PageCount { get { return _pagecount; } set { if (value > 0) { _pagecount = value; } } }


        public Book(string name)
        {
            Name = name;
            codecount++;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(char.ToUpper(name[0]));
            stringBuilder.Append(char.ToUpper(name[1]));

            Code = stringBuilder + codecount.ToString();
            Code = name;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}, AuthorName:{AuthorName}, Code:{Code}");
        }
    }
}
