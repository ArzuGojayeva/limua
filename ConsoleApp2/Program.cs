using ConsoleApp2.Models;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Magazanin adini daxil edin:");
            string StoreName=Console.ReadLine();
            while (StoreName.Length <2)
            {
                Console.WriteLine("Magaza adi sehvdir");
                Console.WriteLine("Magazanin adini daxil edin:");
                StoreName = Console.ReadLine();
            }
            Store str=new Store(StoreName);
            int input;
            do
            {
                Console.WriteLine("1-Magazaydaki telefonlari goster");
                Console.WriteLine("2-Magazaya yeni telefon elave et");
                Console.WriteLine("3-Qiymete uygun telefon tap");
                Console.WriteLine("4-Telefonu sil");
                Console.WriteLine("5-Cixis");

                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        str.ShowAllPhone();
                        break;
                    case 2:
                        Console.Write("Phone Id: ");
                        int phoneId = int.Parse(Console.ReadLine());

                        Console.Write("Phone Name: ");
                        string phoneName = Console.ReadLine();

                        Console.Write(" Phone BrandName: ");
                        string phoneBrand = Console.ReadLine();

                        Console.WriteLine("Phone Price");
                        int phonePrice = int.Parse(Console.ReadLine());
                        Phone phone = new Phone(phoneId, phoneName, phoneBrand, phonePrice);
                        str.Addphone(phone);
                        break;
                    case 3:
                        Console.WriteLine("min Price");
                        int min = int.Parse(Console.ReadLine());
                        Console.WriteLine("max price");
                        int max = int.Parse(Console.ReadLine());
                        str.ShowPhone(min, max);
                        break;
                    case 4:
                        Console.WriteLine("Phone id");
                        int id = int.Parse(Console.ReadLine());
                        str.RemovePhone(id);
                        break;

                }

            } while (input != 5);
        }
    }
}