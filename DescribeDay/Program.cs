namespace DescribeDay
{
    internal class Program
    {
        public static string DescribeDay(int dayNumber)
        {
            switch (dayNumber)
            {

                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return "Working day";
                case 6:
                case 7:
                    return "Weekend";
                default:
                    return "Invalid day number";
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter day");
            int day = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine(DescribeDay(day));
            Console.ReadLine();
        }
    }
}
