using System.Collections.Generic;

namespace LeetCode
{
    public class Code575
    {
        public int MajorityElement(int[] nums)
        {
            var cur = -1;
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    cur = nums[i];
                }

                if (cur == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return cur;
        }
    }
}