using System.Collections.Generic;

namespace LeetCode
{
    public class Code119
    {
        public List<int> GetRow(int rowIndex)
        {
            var pre = new List<int>();
            for (int i = 0; i <= rowIndex; ++i)
            {
                var cur = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == i || j == 0)
                    {
                        cur.Add(1);
                    }
                    else
                    {
                        cur.Add(pre[j - 1] + pre[j]);
                    }
                }

                pre = cur;
            }

            return pre;
        }
    }
}