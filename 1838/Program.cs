public class Solution
{
    public int MaxFrequency(int[] nums, int k)
    {
        int res = 0;
        int l = 0, r = 0;
        long sum = 0;
        Array.Sort(nums);
        while (r < nums.Length)
        {
            sum += nums[r];

            while ((long)nums[r] * (r - l + 1) > sum + k)
            {
                sum -= nums[l];
                l++;
            }
            if (res < r - l + 1)
                res = r - l + 1;
            //res = Math.Max(res, r - l + 1);
            r++;
        }
        return (int)res;
    }
}