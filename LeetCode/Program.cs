using System;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var code = new Code27();
            var res = code.RemoveElement(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
            Console.WriteLine(res);
        }
    }
}