namespace Amoeba.Models
{
    public class Profession
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Client>? clients { get; set; }
    }
}
