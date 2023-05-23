using LUMİA.Models;

namespace LUMİA.ViewModels
{
    public class HomeVM
    {
        public List<CustomService> customServices { get; set; }
        public Slider slider { get; set; }
        public List<Team> Teams { get; set; }
        public List <WhatWeDo> Whats { get; set; }
    }
}
