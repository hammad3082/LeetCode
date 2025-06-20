public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] arr = s.Split(' ');

        if (arr.Length != pattern.Length)
            return false;

        Dictionary<char, string> dict = new Dictionary<char, string>();

        for (int i = 0; i < pattern.Length; i++)
        {
            if (dict.TryGetValue(pattern[i], out string res))
            {
                if (arr[i] != res)
                    return false;
            }
            else
            {
                if (dict.ContainsValue(arr[i]))
                    return false;

                dict[pattern[i]] = arr[i];
            }
        }

        return true;
    }
}
