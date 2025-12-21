public class Solution
{
    public string RemoveTrailingZeros_TS(string num)
    {
        return num.TrimEnd('0');
    }
    public string RemoveTrailingZeros(string num)
    {
        int i = num.Length - 1;
        for (; i >= 0; i--)
        {
            if(num[i] != '0')
                break;
        }

        return num.Substring(0, i + 1);
    }
}