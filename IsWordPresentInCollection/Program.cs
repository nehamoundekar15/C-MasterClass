namespace IsWordPresentInCollection
{
    internal class Program
    {
        public static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == wordToBeChecked)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************");
            var words = new string[] { "apple", "banana", "cherry", "date" };
            var wordToBeChecked = "banana";
            var isPresent = IsWordPresentInCollection(words, wordToBeChecked);
            Console.WriteLine("Is word present = " + isPresent);
            Console.ReadLine(); 
        }
    }
}
