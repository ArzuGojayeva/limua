namespace ConsoleApp7.Models
{
    internal class Gallery
    {
        private string _name;
        public string Name { get; set; }
        List<Car>cars=new List<Car>();
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public void ShowAllCars() {
            if (cars.Count > 0)
            {
                cars.ForEach(car =>
                {
                    Console.WriteLine(car.Name);
                });
            }
            else
            {
                Console.WriteLine("Elave edilecek masin yoxdur");
            }
        }
        public void FindById(int Id)
        {
            var carId=cars.Find(x=>x.Equals(Id));
            Console.WriteLine(carId);
        }
        
        public void FindByCarCode(string carCode)
        {
           var Carcode=cars.Find(x=>x.carcode.Equals(carCode));
            Console.WriteLine(Carcode);
          

        }
        public void DeleteCar(int Id)
        {
            var CarId = cars.Find(x => x.id.Equals(Id));
            cars.Remove(CarId);
        }
        public void FindCarsBySpeedInterval(int min,int max)
        {
            var CarSpeed=cars.FindAll(x=>x.Speed>min&& x.Speed<max);
            CarSpeed.ForEach(x =>
            {
                Console.WriteLine(CarSpeed);

            });
        }
        public void SumofAllCarsPrice()
        {
           var Sum=cars.Sum(x=>x.Price);
           Console.WriteLine(Sum);
        }
        public void ExpensiveCar()
        {
            var Expensive=cars.Max(x=>x.Price);
            Console.WriteLine(Expensive);
        }
        public void CheapCar()
        {
            var Cheap=cars.Min(x=>x.Price);
            Console.WriteLine(Cheap);
        }



        
    }
}
