using System;

namespace DefaultLiteralExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DefaultLiteralExpressions");

            // where use default

            // 1 - variables initializers
            int number = default;
            Console.WriteLine(number);

            // 1 - variables assignment
            string text = "new text";
            Console.WriteLine($"{nameof(text)} = {text}");
            text = default;
            Console.WriteLine($"{nameof(text)} = {text}");

            // 3 - Value default in parameters
            Console.WriteLine($"2 + 3 = {Sum(2,3)}");

            // 4 - Function Return
            Console.WriteLine($"2 + -3 = {Sum(2, -3)}");

            // 5 - method call argument
            Console.WriteLine($"{default(int)} + 3 = {Sum(default, 3)}");

            Console.ReadLine();
        }

        static int Sum(int a = default, int b = default)
        {
            if (a < 0 || b < 0)
                return default;

            return a + b;
        }
    }
}
