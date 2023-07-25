namespace LeetCode
{
    public class Code14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var first = strs[0];
            var index = 0;
            while (index < first.Length)
            {
                var chr = first[index];
                for (int i = 1; i < strs.Length; i++)
                {
                    if (index >= strs[i].Length || strs[i][index] != chr)
                    {
                        goto end;
                    }
                }

                index++;
            }

            end:

            if (index > 0)
            {
                return strs[0].Substring(0, index);
            }

            return "";
        }
    }
}