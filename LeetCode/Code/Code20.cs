using System.Collections.Generic;

namespace LeetCode
{
    public class Code20
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var chr in s)
            {
                // 入栈
                if (chr == '(' || chr == '[' || chr == '{')
                {
                    stack.Push(chr);
                }
                // 出栈
                else
                {
                    if (stack.Count == 0)
                        return false;
                    var t = Get(chr);
                    if (stack.Peek() != t)
                        return false;
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
        // public bool IsValid(string s)
        // {
        //     var index = 0;
        //     var stack = new char[s.Length];
        //     foreach (var chr in s)
        //     {
        //         // 入栈
        //         if (chr == '(' || chr == '[' || chr == '{')
        //         {
        //             stack[index] = chr;
        //             index++;
        //         }
        //         // 出栈
        //         else
        //         {
        //             if (index == 0)
        //                 return false;
        //             var t = Get(chr);
        //             if (stack[index - 1] != t)
        //                 return false;
        //             index--;
        //         }
        //     }
        //
        //     return index == 0;
        // }
        //
        private char Get(char c)
        {
            switch (c)
            {
                case ')':
                    return '(';
                case ']':
                    return '[';
                default:
                    return '{';
            }
        }
    }
}