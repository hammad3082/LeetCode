public class Solution
{
    public int ScoreOfString(string s)
    {
        int res = 0;

        for (int i = 1; i < s.Length; i++)
        {
            int dif = s[i - 1] - s[i];

            res += Math.Abs(dif);
        }

        return res;
    }
}