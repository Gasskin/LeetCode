using System;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var code = new Code14();
            var res = code.LongestCommonPrefix(new [] { "flower", "flow", "flight" });
            Console.WriteLine(res);
        }
    }
}