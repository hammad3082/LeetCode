Solution sol = new Solution();

string so = sol.LargestOddNumber("123");

int a = 1 + 2;

public class Solution
{
    public string LargestOddNumber(string num)
    {

        if ((num[num.Length - 1] & 1) == 1)
        {
            return num;
        }

        for (var i = num.Length - 1; i >= 0; i--)
        {
            if ((num[i] & 1) == 1)
            {
                return num.Substring(0, i + 1);
            }
        }

        return string.Empty;
    }
    public string LargestOddNumber_1(string num)// mine
    {
        int i = 0;

        for (i = num.Length - 1; i > -1; i--)
        {
            if (Convert.ToInt32(num[i]) % 2 != 0)
                break;
        }
        return num.Substring(0, i + 1);
    }
}