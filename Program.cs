namespace Static_Hill_Adam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integers 
            Console.WriteLine("Integer Methods");
            Console.WriteLine("21 + 28 is " + Calculate.Add(21, 28));
            Console.WriteLine(Calculate.sub(22, 29));
            Console.WriteLine(Calculate.mult(23, 30));
            Console.WriteLine(Calculate.div(24, 31));

            //Floats
            Console.WriteLine("\nFloat Methods");
            Console.WriteLine(Calculate.Add(25.32f, 32.25f));
            Console.WriteLine(Calculate.sub(25.33f, 33.25f));
            Console.WriteLine(Calculate.mult(26.34f, 34.26f));
            Console.WriteLine(Calculate.div(27.35f, 35.27f));

        }
    }
}
