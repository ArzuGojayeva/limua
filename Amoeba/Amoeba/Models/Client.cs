using System.ComponentModel.DataAnnotations.Schema;

namespace Amoeba.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string Name { get; set; }
        public Profession? Profession { get; set; }
        public int ProfessionId { get; set; }
        public string? Description { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
      
    }
}
