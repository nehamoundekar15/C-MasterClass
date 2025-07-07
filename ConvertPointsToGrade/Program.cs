namespace ConvertPointsToGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Convert points to grade");
            Console.WriteLine("Enter ponits");
            int userPoints = Convert.ToInt32(Console.ReadLine());

            switch (userPoints)
            {
                case 10:
                case 9:
                    Console.WriteLine("A grade"); 
                    break;
                case 8:
                case 7:
                case 6:
                    Console.WriteLine("B grade");
                    break;
                case 5:
                case 4:
                case 3:
                    Console.WriteLine("C grade");
                    break;
                case 2:
                case 1:
                    Console.WriteLine("D grade");
                    break;
                case 0:
                    Console.WriteLine("E grade");
                    break;
                default:
                    Console.WriteLine("!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
