namespace DogClass
{
    internal class Program
    {
        public class Dog
        {
            private string _name;
            private string _breed;
            private int _weight;
            public Dog(string name, string breed, int weight)
            {
                _name = name;
                _breed = breed;
                _weight = weight;

            }
            // constructor with default parameters value
            public Dog(string name, int weight) : this(name, "mixed-breed", weight)
            {
            }
            private string DescribeSize()
            {
                if (_weight < 5)
                {
                    return "tiny";
                }
                if (_weight < 30)
                {
                    return "medium";
                }
                return "large";
            }
            public string Describe()
            {
                return $"This dog is named {_name}, it's a {_breed}," +
                $"and it weighs {_weight} kilograms, so it's a {DescribeSize()} dog.";
            }

            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************");
            Dog dog = new Dog("Buddy", "Golden Retriever", 25);
            Console.WriteLine(dog.Describe());
            Dog dog2 = new Dog("Max", 4);
            Console.WriteLine(dog2.Describe());
            Console.ReadLine();


        }
    }
}
