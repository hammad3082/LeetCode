Solution sol = new Solution();
sol.TruncateSentence("Hello how are you Contestant", 4);

public class Solution
{
    public string TruncateSentence(string s, int k)
    {
        int count = 0, i = 0;
        for (; i < s.Length; i++)
        {
            if (s[i] == ' ')
                count++;

            if (count == k)
                break;
        }

        return s.Substring(0, i);
    }
}