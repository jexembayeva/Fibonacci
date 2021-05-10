using System;
using System.Numerics;

namespace FibonacciBase
{
    public class MatrixMultiplicationTask : ITask
    {
        public string Run(string[] data)
        {
            var n = Convert.ToInt64(data[0]);

            return Fib(n).ToString();
        }

        public static BigInteger Fib(BigInteger n)
        {
            if (n < 0)
                throw new ArgumentException("The fibo value cannot be negative");
            if (n <= 1)
                return n;

            BigInteger[,] result = { { 1, 0 }, { 0, 1 } };
            BigInteger[,] fiboM = { { 1, 1 }, { 1, 0 } };

            while (n > 0)
            {
                if (n % 2 == 1)
                    Mult2x2Matrix(result, fiboM);
                n /= 2;
                Mult2x2Matrix(fiboM, fiboM);
            }

            return result[1, 0];
        }

        private static void Mult2x2Matrix(BigInteger[,] m, BigInteger[,] n)
        {
            BigInteger a = m[0, 0] * n[0, 0] + m[0, 1] * n[1, 0];
            BigInteger b = m[0, 0] * n[0, 1] + m[0, 1] * n[1, 1];
            BigInteger c = m[1, 0] * n[0, 0] + m[1, 1] * n[0, 1];
            BigInteger d = m[1, 0] * n[0, 1] + m[1, 1] * n[1, 1];

            m[0, 0] = a;
            m[0, 1] = b;
            m[1, 0] = c;
            m[1, 1] = d;
        }
    }
}
