namespace ConsoleApp6
{
    internal class Program
    {
        public delegate int Calculator(int n1,int n2);
        static void Main(string[] args)
        {
            Calculator calculator = Divide;
            Console.WriteLine(calculator(30,3));
            calculator += Multiply;
            Console.WriteLine(calculator.Invoke(20, 2));
            
        }
        static  int Multiply(int n,int m)
        {
            return n * m;
        }
        static int Divide(int n,int m)
        {
            return n / m;
        }

         
        

    }
}