using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        public static void Main()
        {
            var fib = new FibonacciMemoized(100);
            for (int i = 1; i < 93; i++)
            {
                Console.WriteLine($"Fibonachi for {i}: {fib.Fib(i)}");
            }
            Console.ReadLine();
        }
    }
}
