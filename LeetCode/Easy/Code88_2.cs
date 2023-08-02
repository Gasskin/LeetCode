namespace LeetCode
{
    public class Code88_2
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var last = m + n - 1;
            m--;
            n--;
            while (n >= 0)
            {
                while (m >= 0 && nums2[n] < nums1[m])
                {
                    nums1[last--] = nums1[m--];
                }

                nums1[last--] = nums2[n--];
            }
        }
    }
}