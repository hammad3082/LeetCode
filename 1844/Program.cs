public class Solution
{
    public string ReplaceDigits(string s)
    {
        char[] result = s.ToCharArray();

        for (int i = 1; i < s.Length; i += 2)
        {
            result[i] = (char)(s[i - 1] + (s[i] - '0'));
        }

        return new string(result);
    }
}