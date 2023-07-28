using System.Collections.Generic;

namespace LeetCode
{
    public class Code575
    {
        public int DistributeCandies(int[] candyType)
        {
            var hash = new HashSet<int>();
            var sum = candyType.Length / 2;

            for (int i = 0; i < candyType.Length; i++)
            {
                hash.Add(candyType[i]);
                if (hash.Count > sum)
                    return sum;
            }
            var len = hash.Count;
            return sum > len ? len : sum;
        }
    }
}