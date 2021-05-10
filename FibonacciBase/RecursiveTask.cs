using System;

namespace FibonacciBase
{
    public class RecursiveTask : ITask
    {
        public string Run(string[] data)
        {
            var n = Convert.ToInt64(data[0]);
            return F(n).ToString();
        }

        long F(long n)
        {
            if (n <= 1)
                return n;
            return F(n - 1) + F(n - 2);
        }
    }
}
