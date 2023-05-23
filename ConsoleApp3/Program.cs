using ConsoleApp3.Models;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Arzu");
            Student student2 = new Student("Jale");

            Console.WriteLine(student1.Code);
            Console.WriteLine(student2.Code);
        }
    }
}