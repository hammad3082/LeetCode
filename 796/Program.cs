
Solution sol = new Solution();
sol.RotateString("abcde", "cdeab");
public class Solution
{
    public bool RotateString(string s, string goal)
    {
        if(s.Length != goal.Length) 
            return false;

        string concat = s + s;

        return concat.Contains(goal);
    }

    public bool RotateString_1(string s, string goal)
    {
        if (s.Length != goal.Length)
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            String rotated = s.Substring(i) + s.Substring(0, i);
            if (rotated.Equals(goal))
            {
                // Return true if a match is found
                return true;
            }
        }

        string concat = s + s;

        return concat.Contains(goal);
    }
}