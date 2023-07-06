using System;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var code = new Code20();
            var res = code.IsValid("([)]");
            Console.WriteLine(res);
        }
    }
}