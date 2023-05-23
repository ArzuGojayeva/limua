using System.Text;

namespace ConsoleApp3.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public static int IdCount;
        private  string Name { get; set; }
        public string Code { get; set; }
        public static int CodeCount = 100;

        public Student(string name)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Char.ToUpper(name[0]));
            stringBuilder.Append(Char.ToUpper(name[1]));

            Name = name;
            IdCount++;
            Id = IdCount;
            CodeCount++;

            Code= stringBuilder +CodeCount.ToString();

        }
         
            


            

            

           

            
        }


    }

