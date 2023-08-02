using System;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var code = new Code88_2();
            // var res = code.Merge(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3);
            // Console.WriteLine(res);
            code.Merge(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3);
        }
    }
}