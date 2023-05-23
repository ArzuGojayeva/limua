using Simple.Models;

namespace Simple.ViewModels
{
    public class HomeVM
    {
        public List<About>Abouts { get; set;}
        public List<Questions> questions { get; set;}
        public Contact Contact { get; set;}
        public Main main { get; set;}
        public Slider slider { get; set;}

    }
}
