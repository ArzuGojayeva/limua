namespace Simple.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }


    }
}
