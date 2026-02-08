public class Solution
{
    public string LargestEven(string s)
    {
        int i;

        for (i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '2') 
                break;
        }

        return s.Substring(0, i + 1);
    }
}