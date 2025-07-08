namespace BuildHelloString
{
    internal class Program
    {
        public static string BuildHelloString()
        {
            char[] letters = { 'h', 'e', 'l', 'l', 'o' };
            var result = "";
            for (int i = 0; i < letters.Length; ++i)
            {
                result = result + letters[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine(BuildHelloString());
            Console.ReadLine();

    }
    }
}
