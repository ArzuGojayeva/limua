namespace asp.intro.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string GenreId { get; set; }
        public Genre genre { get; set; }
        public string AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
