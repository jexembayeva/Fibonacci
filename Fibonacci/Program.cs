using FibonacciBase;
using System;

namespace FibonacciTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\algorithms\03._Алгебраические_алгоритмы\4.Fibo-19350-d13012\";

            Console.WriteLine("-------------------Fibonacci------------------------");
            ITask fibonacciTask = new FibonacciRecursiveTask();

            Tester fibonacciTester = new Tester(fibonacciTask, path);
            fibonacciTester.RunTests();

            Console.ReadKey();
        }
    }
}
