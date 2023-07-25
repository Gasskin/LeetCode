using System;
using System.Text.RegularExpressions;

namespace LeetCode
{
    public class Code2485
    {
        public int PivotInteger(int n)
        {
            // if (n == 1)
            // {
            //     return 1;
            // }
            //
            // int GetSum(int idx)
            // {
            //     return (1 + idx) * idx / 2;
            // }
            //
            // var sum = GetSum(n);
            //
            // for (int i = 1; i < n; i++)
            // {
            //     var preSum = GetSum(i);
            //     if (preSum == sum - preSum + i)
            //     {
            //         return i;
            //     }
            // }

            var t2 = (n * n + n) / 2;
            var t = (int)Math.Sqrt(t2);
            if (t * t == t2)
                return t;
            return -1;
        }
    }
}