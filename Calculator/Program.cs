namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Calculator");
            int num1, num2;
            string operation;
            Console.WriteLine("Enter 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operation");
            Console.WriteLine("[A]ddition operation");
            Console.WriteLine("[S]ubtraction operation");
            Console.WriteLine("[M]ultiplication operation");

            
            operation = Console.ReadLine();
            if (operation != "")
            {
                if (EqualsCaseInsensitive(operation, "A"))
                {
                    DisplayResult("+", (num1 + num2) );
                }
                else if (EqualsCaseInsensitive(operation, "S"))
                {
                    DisplayResult("-", (num1 - num2));
                }
                else if (EqualsCaseInsensitive(operation, "M"))
                {
                    DisplayResult("*", (num1 * num2));
                }
                else
                {
                    Console.WriteLine("Operation is not valid");
                }

            }
            else
            {
                Console.WriteLine("Operation is not valid");
            }
            bool EqualsCaseInsensitive(string enteredOperation, string actualOperation)
            {
                return (enteredOperation.ToUpper() == actualOperation.ToUpper());
            }

            void DisplayResult(string operation, int result)
            {
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}" ); // string interpolation
                //Console.WriteLine($"Only result is {result}");
            }
            Console.ReadLine();

        }
    }
}
