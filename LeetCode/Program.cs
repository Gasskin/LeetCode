using System;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var code = new Code1401();
            var res = code.CheckOverlap(2, 8, 6, 5, 1, 10, 4);
            Console.WriteLine(res);
        }
    }
}