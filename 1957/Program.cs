using System.Text;

public class Solution
{
    public string MakeFancyString(string s)
    {
        StringBuilder res = new StringBuilder();

        char prev = s[0];
        int freq = 1;

        res.Append(prev);

        for (int i = 1; i < s.Length; i++)
        {
            char ch = s[i];

            if (ch == prev)
                freq++;
            else
            {
                prev = ch;
                freq = 1;
            }

            if (freq < 3)
                res.Append(ch);
        }

        return res.ToString();
    }
}