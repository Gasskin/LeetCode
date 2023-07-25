namespace LeetCode
{
    public class Code35
    {
        public int SearchInsert(int[] nums, int target)
        {
            var index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }

                if (nums[i] <= target)
                {
                    index = i + 1;
                }
            }
            
            return index;
        }
    }
}