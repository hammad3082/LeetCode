Solution sol = new Solution();
int res = sol.LengthOfLongestSubstring("bbtablud");

int a = 1 + 1;
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        List<char> previos = new List<char>();
        int count = 0, maxCount = 0, removeCount = 0;
        int i = 0;
        while(i != s.Length)
        {
            int index = previos.IndexOf(s[i]);
            if (index > -1)
            {
                do
                {
                    previos.RemoveAt(0);
                    removeCount++;
                }
                while (previos.Contains(s[i]));

                maxCount = Math.Max(count++, maxCount);

                count -= removeCount;
                removeCount = 0;
                previos.Add(s[i]);
            }
            else
            {
                previos.Add(s[i]);
                count++;
            }
            i++;
        }

        return Math.Max(count, maxCount);
    }
}
public class Solution15
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> previos = new HashSet<char>();
        int count = 0, maxCount = 0;
        foreach (char c in s)
        {
            if (previos.Contains(c))
            {
                previos = new HashSet<char> ();

                maxCount = Math.Max(count,maxCount);

                count = 1;
                previos.Add(c);
            }
            else
            {
                previos.Add(c);
                count++;
            }
        }

        return Math.Max(count, maxCount);
    }
}