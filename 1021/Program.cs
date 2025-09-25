using System.Text;

Solution sol = new Solution();

sol.RemoveOuterParentheses("(()())(())");

public class Solution
{
    public string RemoveOuterParentheses(string s)
    {
        StringBuilder ss = new StringBuilder();

        int c = 1;

        for (int i = 1; i < s.Length; i++)
        {
            if (c > 1 || (s[i] == '(' && c > 0))
                ss.Append(s[i]);
           
            if (s[i] == '(')
                c++;
            else
                c--;
        }

        return ss.ToString();
    }
}