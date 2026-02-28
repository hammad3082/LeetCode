using System.Text;

public class Solution
{
    public string MapWordWeights(string[] words, int[] weights)
    {
        StringBuilder ans = new StringBuilder();
        foreach (var s in words)
        {
            int cnt = 0;

            for (int i = 0; i < s.Length; i++)
            {
                cnt += weights[s[i] - 'a'];
            }
            ans.Append((char)('a' + (25 - (cnt % 26))));
        }
        return ans.ToString();
    }
}