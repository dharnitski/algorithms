using System;


namespace Algorithms
{
    public class Fibonacci
    {
        public int Fib(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
    }

    public class FibonacciMemoized
    {
        private readonly Int64[] _memo;

        public FibonacciMemoized(int max)
        {
            _memo = new Int64[max + 1];
        }

        public Int64 Fib(int n)
        {
            if (n > _memo.Length)
                throw new ArgumentException();

            if (n <= 0) return 0;
            if (n == 1) return 1;

            if (_memo[n] > 0)
                return _memo[n];
            
            var fib = Fib(n - 1) + Fib(n - 2);
            _memo[n] = fib;

            return fib;
        }
    }
}
