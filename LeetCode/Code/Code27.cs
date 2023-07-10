namespace LeetCode
{
    public class Code27
    {
        public int RemoveElement(int[] nums, int val)
        {
            var len = nums.Length;
            for (int i = 0; i < len;)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[len - 1];
                    len--;
                }
                else
                {
                    i++;
                }
            }
            return len;
        }
    }
}