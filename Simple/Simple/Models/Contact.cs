namespace Simple.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public List<SocialMedia> socialMedias { get; set; }

    }
}
