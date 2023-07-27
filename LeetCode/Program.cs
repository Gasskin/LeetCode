using System;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var code = new Code1160();
            var res = code.CountCharacters(new []{"cat","bt","hat","tree"},"atach");
            Console.WriteLine(res);
        }
    }
}