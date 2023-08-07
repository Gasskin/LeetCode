using System;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var code = new Code121();
            var res = code.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 });
            Console.WriteLine(res);
        }
    }
}