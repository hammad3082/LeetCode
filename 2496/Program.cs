public class Solution
{
    public int MaximumValue(string[] strs)
    {
        int max = 0;

        foreach (string str in strs)
        {
            if(int.TryParse(str, out int val))
                max = Math.Max(max, val);
            else
                max = Math.Max(max, str.Length);
        }

        return max;
    }
}