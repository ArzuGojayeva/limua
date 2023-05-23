using System.ComponentModel.DataAnnotations.Schema;

namespace Simple.Models
{
    public class About
    {
        public int Id { get; set; } 
        public string? Icon { get; set; }
        public string? Image { get; set; }   
        public string? Title { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
