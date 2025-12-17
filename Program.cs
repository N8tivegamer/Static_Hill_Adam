namespace Static_Hill_Adam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integers 
            Console.WriteLine("Integer Methods");

            // Call integer versions of the Calculate methods and display results
            Console.WriteLine("21 + 28 is " + Calculate.Add(21, 28));
            Console.WriteLine(Calculate.Sub(22, 29));
            Console.WriteLine(Calculate.Mult(23, 30));
            Console.WriteLine(Calculate.Div(24, 31));

            //Floats
            Console.WriteLine("\nFloat Methods");

            // Call float versions of the Calculate methods and display results
            Console.WriteLine(Calculate.Add(25.32f, 32.25f));
            Console.WriteLine(Calculate.Sub(25.33f, 33.25f));
            Console.WriteLine(Calculate.Mult(26.34f, 34.26f));
            Console.WriteLine(Calculate.Div(27.35f, 35.27f));

        }
    }
}
