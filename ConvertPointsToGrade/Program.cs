namespace ConvertPointsToGrade
{
    internal class Program
    {
        static string GetGrade(int points)
        {
            switch (points)
            {
                case 10:
                case 9:
                    return "A grade";
                case 8:
                case 7:
                case 6:
                    return "B grade";
                case 5:
                case 4:
                case 3:
                    return "C grade";
                case 2:
                case 1:
                    return "D grade";
                case 0:
                    return "Fail";
                default:
                    return "Invalid points";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Convert points to grade");
            Console.WriteLine("Enter ponits");
            int userPoints = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetGrade(userPoints));
            
            Console.ReadLine();
        }
    }
}
