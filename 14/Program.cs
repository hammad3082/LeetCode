using System.Text;

Solution sol = new Solution();
sol.LongestCommonPrefix(new string[] { "flower", "flow", "flight","fla","flbeerdsdfes" });

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        StringBuilder res = new StringBuilder();

        Array.Sort(strs);

        string first = strs[0];
        string last = strs[strs.Length - 1];

        int arrLen = Math.Min(first.Length, last.Length);

        for (int i = 0; i < arrLen; i++)
        {
            if (first[i] != last[i])
                return res.ToString();

            res.Append(first[i]);
        }

        return res.ToString();
    }

    public string LongestCommonPrefix_TL(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (prefix == "")
                    return "";
            }
        }

        return prefix;
    }
}