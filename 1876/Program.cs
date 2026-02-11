public class Solution
{
    public int CountGoodSubstrings(string s)
    {
        int res = 0;

        for (int i = 1; i < s.Length - 1; i++)
        {
            if (s[i] != s[i - 1] && s[i] != s[i + 1] && s[i - 1] != s[i + 1])
                res++;
        }

        return res;
    }
}