public class Solution
{
    public bool DigitCount(string num)
    {
        int[] arr = new int[10];

        for (int i = 0; i < num.Length; i++)
            arr[num[i] - '0']++;

        for (int i = 0; i < num.Length; ++i)
        {
            if (arr[i] != num[i] - '0')
                return false;
        }

        return true;
    }
}