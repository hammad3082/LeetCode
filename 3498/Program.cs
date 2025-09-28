public class Solution
{
    public int ReverseDegree(string s)
    {
        int res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int charToInt = 26 - (s[i] - 97);
            res += (charToInt * (i + 1));
        }
        return res;
    }
}