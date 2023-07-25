namespace LeetCode
{
    public class Code2078
    {
        public int MaxDistance(int[] colors)
        {
            var a = 0;
            var b = 0;
            var first = colors[0];
            var end = colors[colors.Length - 1];
            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i] != end)
                {
                    a = colors.Length - i - 1;
                    break;
                }
            }

            for (int i = colors.Length - 1; i >= 0; i--)
            {
                if (colors[i] != first)
                {
                    b = i;
                    break;
                }
            }

            return a > b ? a : b;
        }
    }
}