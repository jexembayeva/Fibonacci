using System;
using System.Numerics;

namespace FibonacciBase
{
    public class IterativeTask : ITask
    {
        public string Run(string[] data)
        {
            var n = Convert.ToInt64(data[0]);
            return F(n).ToString();
        }

        BigInteger F(long n)
        {
            if (n <= 1)
                return n;

            BigInteger x = 0;
            BigInteger y = 1;
            BigInteger ans = 0;

            for (var i = 2; i <= n; i++)
            {
                ans = x + y;
                x = y;
                y = ans;
            }
            return ans;
        }
    }
}
