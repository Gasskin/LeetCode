using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Code1160
    {
        public int CountCharacters(string[] words, string chars)
        {
            var all = new Dictionary<char, int>();
            var now = new Dictionary<char, int>();
            foreach (var c in chars)
            {
                if (all.ContainsKey(c))
                    all[c]++;
                else
                    all[c] = 1;
            }

            var sum = 0;
            foreach (var word in words)
            {
                now.Clear();
                for (int i = 0; i < word.Length; i++)
                {
                    var w = word[i];
                    if (!all.ContainsKey(w))
                    {
                        break;
                    }

                    if (!now.ContainsKey(w))
                    {
                        now[w] = 1;
                    }
                    else
                    {
                        now[w]++;
                    }

                    if (now[w] > all[w])
                    {
                        break;
                    }

                    if (i == word.Length - 1)
                    {
                        sum += word.Length;
                    }
                }
            }

            return sum;
        }
    }
}