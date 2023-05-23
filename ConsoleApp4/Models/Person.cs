namespace ConsoleApp4.Models
{
    internal class Person
    {
        public int Age { get; set; }
        public static bool operator>(Person a, Person b)
        {
            return a.Age > b.Age;
        }
        public static bool operator<(Person a, Person b)
        {
            return a.Age < b.Age;
        }
    }   
}
