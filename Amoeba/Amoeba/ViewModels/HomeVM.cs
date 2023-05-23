using Amoeba.Models;

namespace Amoeba.ViewModels
{
    public class HomeVM
    {
        public List<Client> clients { get; set; }   
        public Profession Profession { get; set; }
        public About About { get; set; }
        public List<Settingone> Services { get; set; }
        public List<Questions> Questions { get; set; }
        public Contact contact { get; set; }
        public Slider slider { get; set; }
    }
}
