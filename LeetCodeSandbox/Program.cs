using LeetCodeSandbox.Problems.Problem1539;
using System;

namespace LeetCodeSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MissingPositiveNumber();
            Console.WriteLine(test.FindKthPositive(new int[] { 8, 11, 16, 20, 29, 30, 32, 33, 37, 39, 42, 44, 46, 47, 48, 50, 52, 56, 60, 63, 64, 65, 68, 70, 72, 74, 80 }, 45));
        }
    }
}