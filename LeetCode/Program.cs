using System;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var code = new Code575();
            var res = code.MajorityElement(new []{3,1,2,1,2,2,3});
            Console.WriteLine(res);
        }
    }
}