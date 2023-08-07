using System;

namespace LeetCode
{
    public class Code121
    {
        /// <summary>
        /// 想要知道第i天的收益，只需要知道前i天的最低点
        /// f(i)=前i天的最低点
        /// f(i) = min[f(i-1),price(i)]
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            // var res = new int[prices.Length];
            // var profit = 0;    
            // for (int i = 0; i < prices.Length; i++)
            // {
            //     if (i == 0)
            //     {
            //         res[i] = prices[i];
            //     }
            //     else
            //     {
            //         res[i] = Math.Min(res[i - 1], prices[i]);
            //     }
            //
            //     if (prices[i] - res[i] > profit)
            //     {
            //         profit = prices[i] - res[i];
            //     }
            // }
            //
            // return profit;

            var profit = 0;
            var low = prices[0];
            foreach (var t in prices)
            {
                low = Math.Min(low, t);
                profit = t - low > profit ? t - low : profit;
            }

            return profit;
        }
    }
}