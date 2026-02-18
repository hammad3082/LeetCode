public class Solution
{
    public int MinimumLength(string s)
    {
        int[] charFrequency = new int[26];
        int res = 0;

        foreach (char c in s)
            charFrequency[c - 'a']++;

        foreach (int frequency in charFrequency)
        {
            if (frequency == 0) 
                continue;

            if (frequency % 2 == 0)
                res += 2;
            else
                res += 1;
        }

        return res;
    }
}