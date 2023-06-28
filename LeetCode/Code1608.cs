using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Code1608
    {
        public int SpecialArray(int[] nums)
        {
            // var dic = new Dictionary<int, int>();
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     for (int j = 1; j <= nums[i]; j++)
            //     {
            //         if (dic.ContainsKey(j))
            //         {
            //             dic[j] += 1;
            //         }
            //         else
            //         {
            //             dic[j] = 1;
            //         }
            //     }
            // }
            //
            // foreach (var pair in dic)
            // {
            //     if (pair.Key == pair.Value)
            //     {
            //         return pair.Value;
            //     }
            // }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums.Length - i;
                var start = i == 0 ? 1 : nums[i - 1] + 1;
                var end = nums[i];
                for (int j = start; j <= end; j++)
                {
                    if (num == j)
                    {
                        return j;
                    }
                }
            }

            return -1;
        }
    }
}