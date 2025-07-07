namespace FactorialOfNum
{
    internal class Program
    {
        public static int Factorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Factorial of Number");
            Console.WriteLine("Result of Factorial: "+ Factorial(5));
            Console.ReadKey();
        }
    }
}
