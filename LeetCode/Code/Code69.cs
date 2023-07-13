namespace LeetCode
{
    public class Code69
    {
        public int MySqrt(int x)
        {
            var l = 0;
            var r = x;
            var res = -1;
            while (l <= r)
            {
                var mid = (l + r) / 2;
                if ((long)mid*mid<=x)
                {
                    res = mid;
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return res;
        }
        
        // int mySqrt(int x) {
        //     int l = 0, r = x, ans = -1;
        //     while (l <= r) {
        //         int mid = l + (r - l) / 2;
        //         if ((long long)mid * mid <= x) {
        //             ans = mid;
        //             l = mid + 1;
        //         } else {
        //             r = mid - 1;
        //         }
        //     }
        //     return ans;
        // }
    }
}