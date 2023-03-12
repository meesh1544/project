using System;
namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 100);
            }
            
            var sum = (int x, int y) => x + y;
            
            var result = (int x, int y) => x * y;
            var largerValue = (int c, int d) =>
            {
                if (c > d)
                    return c;
                else
                    return d;
            };

            
            for (int x = 0; x < numbers.Length - 1; x++)
            {
                Console.WriteLine($"Numbers you are using: {numbers[x]}  and  {numbers[x + 1]}");
                Console.WriteLine($"The sum is: {sum(numbers[x], numbers[x + 1])}");
                Console.WriteLine($"The difference is: {result(numbers[x], numbers[x + 1])}");
                Console.WriteLine($"The larger value is: {largerValue(numbers[x], numbers[x + 1])}");
                Console.WriteLine();
            }

        }
    }
}

