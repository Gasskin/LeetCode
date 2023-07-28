using System;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var code = new Code575();
            var res = code.DistributeCandies(new []{6,6,6,6});
            Console.WriteLine(res);
        }
    }
}