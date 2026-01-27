Solution sol =  new Solution();
sol.AreOccurrencesEqual("abacbc");

public class Solution
{
    public bool AreOccurrencesEqual(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in s)
            dict[c] = dict.TryGetValue(c, out int val) ? ++val : 1;

        int tfreq = dict.First().Value;

        foreach (var freq in dict.Values)
        {
            if (tfreq != freq)
                return false;
        }

        return true;
    }
}