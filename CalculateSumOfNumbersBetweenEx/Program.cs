namespace CalculateSumOfNumbersBetweenEx
{
    internal class Program
    {
        public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
        {
            int result = 0;
            //your code goes here
            while (firstNumber <= lastNumber)
            {
                result = result + firstNumber;
                firstNumber++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("While loop - CalculateSumOfNumbersBetween");
            int sumOfNum = CalculateSumOfNumbersBetween(5, 10);
            Console.WriteLine("Result: "+sumOfNum);
            Console.ReadLine();
        }
    }
}
