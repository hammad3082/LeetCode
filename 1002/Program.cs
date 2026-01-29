Solution sol = new Solution();
sol.CommonChars(new string[] { "bella", "label", "roller" });

public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        List<string> res = new ();

        int[] current = Count(words[0]);

        for (int i = 1; i < words.Length; i++)
            current = Intersection(current, Count(words[i]));

        for (int i = 0; i < 26; i++)
        {
            if (current[i] != 0)
            {
                char a = (char)('a' + i);
                string s = a.ToString();

                while (current[i] > 0)
                {
                    res.Add(s);

                    current[i]--;
                }
            }
        }

        return res;
    }

    private int[] Intersection(int[] a, int[] b)
    {
        int[] t = new int[26];

        for (int i = 0; i < 26; i++)
            t[i] = Math.Min(a[i], b[i]);

        return t;
    }

    private int[] Count(string str)
    {
        int[] t = new int[26];

        foreach (char c in str)
            t[c - 'a']++;

        return t;
    }
}