public class Solution
{
    public string ReversePrefix(string s, int k)
    {
        char[] arr = s.ToCharArray();

        for (int i = 0; i < k / 2; i++)
        {
            char temp = arr[i];
            arr[i] = arr[k - 1 - i];
            arr[k - 1 - i] = temp;
        }

        return new string(arr);
    }
}