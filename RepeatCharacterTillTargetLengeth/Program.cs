namespace RepeatCharacterTillTargetLengeth
{
    internal class Program
    {
        public static string RepeatCharacter(char character, int targetLength)
        {
            string result = "";
            do
            {
                result += character;
            }
            while (result.Length < targetLength);

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("RepeatCharacter till targeted length");
            Console.WriteLine("Result: "+ RepeatCharacter('*', 4));
            Console.ReadKey();  
        }
    }
}
