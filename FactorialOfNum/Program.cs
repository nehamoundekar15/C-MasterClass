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


            // last elemenents of an array from by index operator 
            int[] arr = new int[3] { 1, 22, 33 };
            // by simple way 
            int lastFirstNum = arr[arr.Length - 1];
            int lastSecondNum = arr[arr.Length - 2];
            Console.WriteLine($"lastFirstNum1 = {lastFirstNum} and lastSecondNum1 =  {lastSecondNum}");
            // ^ end operator 
            int lastFirstNum1 = arr[^1];
            int lastSecondNum1 = arr[^2];
            Console.WriteLine($"lastFirstNum1 = {lastFirstNum1} and lastSecondNum1 =  {lastSecondNum1}");

            // without type
            var arr2 = new [] { 1, 2 };
            Console.ReadKey();


        }
    }
}
