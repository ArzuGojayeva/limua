using System.Text;

namespace ConsoleApp7.Models
{
    internal class Car
    {
        public int id;
        private string _name;
        private int _speed;
        private int _price;
        public string carcode;
        public static int IdCount;
        public static int codecount = 1000;

       
        public string Name { get { return _name;} set { if(value.Length> 2) { _name = value;} } }
        public int Speed { get { return _speed; } set { if (value > 40) { _speed = value; } } }
        public int Price { get { return _price; } set { if (value > 99) { _price = value; } } }
        public Car(string name,int speed,int price)
        {
            Price= price;
            Speed= speed;
            Name = name;
            IdCount++;
            id = IdCount;
            codecount++;

            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append(name[0]);
            stringBuilder.Append(name[1]);
            carcode=stringBuilder +codecount.ToString();
        }
        public void ToString()
        {
            Console.WriteLine($"Name:{Name}, Id:{id}, Price:{Price},Carcode:{carcode}");

        }

    }
}
