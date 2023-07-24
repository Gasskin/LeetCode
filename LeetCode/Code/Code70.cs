namespace LeetCode
{
    public class Code70
    {
        public int ClimbStairs(int n)
        {
            var f1 = 0;
            var f2 = 0;
            var f = 1;
            for (int i = 1; i <= n; i++)
            {
                f1 = f2;
                f2 = f;
                f = f1 + f2;
            }
            return f;
        }
        
    }
}