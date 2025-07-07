namespace DescribeDay
{
    internal class Program
    {
        public static string DescribeDay(int dayNumber)
        {
            //switch staements
            //switch (dayNumber)
            //{

            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //    case 5:
            //        return "Working day";
            //    case 6:
            //    case 7:
            //        return "Weekend";
            //    default:
            //        return "Invalid day number";
            //}


            //switch expression - more concise and more readable format 
            //return dayNumber switch
            //{
            //    1 or 2 or 3 or 4 or 5 => "Working day",
            //    6 or 7 => "Weekend", 
            //    _ => "Invalid day number"
            //};

            //patern matching
            return dayNumber switch
            {
                <=5 => "Working day",
                <=7 => "Weekend",
                _ => "Invalid day number"
            };

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
