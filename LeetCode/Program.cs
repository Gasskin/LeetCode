using System;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var code = new Code35();
            var res = code.SearchInsert(new[] {1,3,5,6 }, 7);
            Console.WriteLine(res);
        }
    }
}