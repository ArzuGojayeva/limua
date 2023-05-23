using ConsoleApp7.Models;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gallery gallery=new Gallery();

            Car car = new Car("Mersedes", 200, 12000);
            Car car1 = new Car("Bmw", 150, 5000);
            Car car2 = new Car("Kia", 130, 10000);
            gallery.AddCar(car);
            gallery.AddCar(car1);
            gallery.AddCar(car2);
            gallery.ShowAllCars();
            gallery.CheapCar();
            gallery.ExpensiveCar();

            gallery.DeleteCar(1);
            gallery.FindByCarCode("ME1001");
            gallery.FindCarsBySpeedInterval(120,160);
        }
    }
}