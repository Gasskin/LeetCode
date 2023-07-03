using System.Collections.Generic;

namespace LeetCode
{
    public class Code13
    {
        public int RomanToInt(string s)
        {
            var sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var cur = GetValue(s[i]);
                // 最后一个
                if (i == s.Length - 1)
                {
                    sum += cur;
                }
                else
                {
                    var next = GetValue(s[i + 1]);
                    if (next > cur)
                    {
                        sum += next - cur;
                        i++;
                    }
                    else
                    {
                        sum += cur;
                    }
                }
            }

            return sum;
        }

        private int GetValue(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                default:
                    return 1000;
            }
        }
    }
}