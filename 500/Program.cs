Solution sol = new Solution();

sol.FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" });
public class Solution
{
    public string[] FindWords(string[] words)
    {
        List<string> res = new List<string>();

        foreach (string word in words)
        {
            if (canBeTypedUsingRow(word, "qwertyuiopQWERTYUIOP") || canBeTypedUsingRow(word, "asdfghjklASDFGHJKL") || canBeTypedUsingRow(word, "zxcvbnmZXCVBNM"))
            {
                res.Add(word);
            }
        }

        return res.ToArray();
    }

    private bool canBeTypedUsingRow(string word, string row)
    {
        foreach (char c in word)
        {
            if (row.IndexOf(c) == -1)
                return false;
        }

        return true;
    }
}