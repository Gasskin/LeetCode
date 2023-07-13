namespace LeetCode
{
    public class Code58
    {
        public int LengthOfLastWord(string s)
        {
            var index = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == ' ' && s[i + 1] != ' ')
                {
                    index = i + 1;
                }
            }

            var sum = 0;
            for (int i = index; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    break;
                }
                sum++;
            }

            return sum;
        }
    }
}