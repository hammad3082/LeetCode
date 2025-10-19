
Solution sol = new Solution();
sol.BalancedStringSplit("LLLLLLR");
public class Solution
{
    public int BalancedStringSplit(string s)
    {
        int res = 0, cnt = 0;
        foreach (char c in s)
        {
            cnt += c == 'L' ? 1 : -1;
            if (cnt == 0) ++res;
        }
        return res;
    }
}