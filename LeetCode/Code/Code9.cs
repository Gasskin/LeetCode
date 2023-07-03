public class Code9
{
    public bool IsPalindrome(int x)
    {
        // 负数，肯定不是
        if (x < 0)
            return false;
        var str = x.ToString();
        var i = 0;
        var j = str.Length - 1;
        while (i != j && i <= j)
        {
            if (str[i] != str[j])
                return false;
            i++;
            j--;
        }

        return true;
    }
}