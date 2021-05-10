using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace FibonacciBase
{
    public class GoldenRatioTask : ITask
    {
        public string Run(string[] data)
        {
            var n = Convert.ToInt64(data[0]);
            var index = Math.Pow(5, 0.5);

            var left = (1 + index) / 2;
            var right = (1 - index) / 2;

            return Math.Round((Math.Pow(left, n) - Math.Pow(right, n)) / index).ToString();
        }
    }
}
