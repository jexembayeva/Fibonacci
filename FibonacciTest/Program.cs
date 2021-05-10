using FibonacciBase;
using System;

namespace FibonacciTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\algorithms\03._Алгебраические_алгоритмы\4.Fibo-19350-d13012\4.Fibo";

            Console.WriteLine("-------------------GoldenRatio------------------------");
            ITask goldenRatioTask = new GoldenRatioTask();

            Tester goldenRatioTester = new Tester(goldenRatioTask, path);
            goldenRatioTester.RunTests();

            Console.WriteLine("-------------------MatrixMultiplication------------------------");
            ITask matrixMultiplicationTask = new MatrixMultiplicationTask();

            Tester matrixMultiplicationTester = new Tester(matrixMultiplicationTask, path);
            matrixMultiplicationTester.RunTests();

            Console.WriteLine("-------------------Iterative------------------------");
            ITask iterativeTask = new IterativeTask();

            Tester iterativeTester = new Tester(iterativeTask, path);
            iterativeTester.RunTests();

            Console.WriteLine("-------------------Recursive------------------------");
            ITask recursiveTask = new RecursiveTask();

            Tester recursiveTester = new Tester(recursiveTask, path);
            recursiveTester.RunTests();

            Console.ReadKey();
        }
    }
}
