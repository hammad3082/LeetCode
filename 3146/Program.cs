Solution sol = new Solution();
sol.FindPermutationDifference("abcde", "edbac");

public class Solution
{
    public int FindPermutationDifference(string s, string t)
    {
        int res = 0;

        Dictionary<char,int> p = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++) 
        { 
            p[s[i]] = i;
        }

        for (int i = 0; i < t.Length; i++)
        {
            res += Math.Abs(p[t[i]] - i);
        }

        return res;
    }
    public int FindPermutationDifference_2(string s, string t) //alt
    {
        int res = 0;

        int[] arr = new int[28];

        Dictionary<char, int> p = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            arr[s[i] - 'a'] = i;
        }

        for (int i = 0; i < t.Length; i++)
        {
            res += Math.Abs(arr[t[i] - 'a'] - i);
        }

        return res;
    }
}