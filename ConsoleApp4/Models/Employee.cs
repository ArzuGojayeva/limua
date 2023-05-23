namespace ConsoleApp4.Models
{
    internal class Employee:Iperson
    {
        private  int _id;

        public static int IdCount = 0;

        public Employee(int salary,string name,int age)
        {
            Age= age;
            Name= name;
            Age= age;
            IdCount++;
            IdCount = _id;
           
        }

        private int _salary;
        public int Salary { get { return _salary; } set { if (value > 0 && value < 200) { _salary = value; } } }

        private string _name;
        public string Name { get { return _name; } set { if (value.Length > 2) { _name = value; } } }
        private int _age;
        public int Age { get { return _age;} set { if(value> 0) { _age = value; } } }

       
        public override string ToString()
        {
            return Showinfo();
        }

        public string Showinfo()
        {
            return $"{Name} {Age}";

        }
    }
}
