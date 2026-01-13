public class Solution
{
    public int MaxFrequencyElements(int[] nums)
    {
        int res = 0, maxFreq = 0;
        int[] arr = new int[101];

        foreach (int n in nums)
        {
            int freq = ++arr[n];
            if (freq > maxFreq)
            {
                maxFreq = freq;
                res = freq;
            }
            else if (freq == maxFreq)
            {
                res += freq;
            }
        }

        return res;
    }
}