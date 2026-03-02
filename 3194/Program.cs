using System;

public class Solution
{
    public double MinimumAverage(int[] nums)
    {
        double res = 100;

        Array.Sort(nums);

        for (int i = 0; i < nums.Length / 2; ++i)
        {
            res = Math.Min(res, nums[i] + nums[nums.Length - i - 1]);
        }

        return res / 2;
    }
}