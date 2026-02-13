using System.Text;

public class Solution
{
    public string[] DivideString(string s, int k, char fill)//ts
    {
        var res = new List<string>();
        var sb = new StringBuilder();

        for (var i = 0; i < s.Length; i++)
        {
            sb.Append(s[i]);

            if (sb.Length == k)
            {
                res.Add(sb.ToString());
                sb = new StringBuilder();
            }
        }

        if (sb.Length > 0)
        {
            while (sb.Length < k)
                sb.Append(fill);

            res.Add(sb.ToString());
        }

        return res.ToArray();
    }
    public string[] DivideString_1(string s, int k, char fill)
    {
        var res = new List<string>();

        for (int i = 0; i < s.Length; i += k)
        {
            string chunk;
            int remainingLength = s.Length - i;

            if (remainingLength >= k)
            {
                chunk = s.Substring(i, k);
            }
            else
            {
                chunk = s.Substring(i, remainingLength);
                chunk = chunk.PadRight(k, fill);
            }

            res.Add(chunk);
        }

        return res.ToArray();
    }
}