public class Solution
{
    public int CountPrefixes(string[] words, string s)
    {
        int count = 0;
        foreach (var x in words)
        {
            if (x.Length > s.Length) continue;
            if (s.Substring(0, x.Length) == x)
            {
                count = count + 1;
            }
        }

        return count;
    }
    public int CountPrefixes_1(string[] words, string s)
    {
        int res = 0;

        foreach (var word in words) 
        {
            if(s.StartsWith(word))
                res++;
        }

        return res;
    }
}