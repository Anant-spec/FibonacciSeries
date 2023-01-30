using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci series up to " + n + ":");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + "");
            }
            Console.ReadLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
