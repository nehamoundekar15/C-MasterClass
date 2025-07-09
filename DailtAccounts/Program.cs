namespace DailtAccounts
{
    internal class Program
    {
        public class DailyAccountState
        {
            public int InitialState { get; }

            public int SumOfOperations { get; }

            public DailyAccountState(
                int initialState,
                int sumOfOperations)
            {
                InitialState = initialState;
                SumOfOperations = sumOfOperations;
            }

            //your code goes here
            public int EndOfDayState => InitialState + SumOfOperations;

            public string Report =>
            $"Day: {DateTime.Now.Day}," +
            $"month: {DateTime.Now.Month}," +
            $"year: {DateTime.Now.Year}," +
            $"initial state: {InitialState}, " +
            $"end of day state: {EndOfDayState}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************");
            DailyAccountState dailyAccountState = new DailyAccountState(1000, -200);
            Console.WriteLine(dailyAccountState.Report);
            Console.ReadLine();
        }
    }
}
