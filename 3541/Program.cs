public class Solution
{
    public int MaxFreqSum(string s)
    {
        int Con = 0, Vow = 0;
        Dictionary<char, int> Freq = new Dictionary<char, int>();
        
        foreach (char c in s)
        {
            if (!Freq.ContainsKey(c)) 
                Freq[c] = 0;
            
            Freq[c]++;
        }

        foreach (var kv in Freq)
        {
            if ("aeiou".Contains(kv.Key))
                Vow = Math.Max(Vow, kv.Value);
            else
                Con = Math.Max(Con, kv.Value);
        }

        return Con + Vow;
    }
}