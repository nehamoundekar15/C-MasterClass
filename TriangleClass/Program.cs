namespace TriangleClass
{
    internal class Program
    {
        public class Triangle
        {
            private int _base;
            private int _height;
            public Triangle(int @base, int height)
            {
                _base = @base;
                _height = height;

            }

            public int CalculateAreas()
            {
                return (_base * _height) / 2;
            }

            public string AsString()
            {
                return $"Base is {_base}, height is {_height}";
            }
        }
       
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Triangle triangle = new Triangle(10, 5);
            int area = triangle.CalculateAreas();
            Console.WriteLine(triangle.AsString());
            Console.ReadLine(); 
        }
    }
}
