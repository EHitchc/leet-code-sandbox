using LeetCodeSandbox.Problems.Problem10;
using System;

namespace LeetCodeSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new RegExMatching();
            Console.WriteLine(test.IsMatch("dfhasjfhasdkjf", "df.*f"));
        }
    }
}
