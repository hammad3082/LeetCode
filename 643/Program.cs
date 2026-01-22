Solution sol = new Solution();

sol.FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4);

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double maxAvg = double.MinValue;

        int left = 0;

        double currentSum = 0;

        for (int i = 0; i < k -1; i++)
        {
            currentSum += nums[i];
        }

        for (int rigth = k - 1; rigth < nums.Length; rigth++)
        {
            currentSum += nums[rigth];

            double subAvg = currentSum / k;

            maxAvg = Math.Max(maxAvg, subAvg);

            currentSum -= nums[left++];
        }

        return maxAvg;
    }

    public double FindMaxAverage_TE(int[] nums, int k)
    {
        double maxAvg = double.MinValue;

        int rigth = k - 1;

        for (int left = 0; rigth < nums.Length; left++)
        {
            double subSum = nums[left];
            int i = left;

            while (i < rigth)
            {
                subSum += nums[++i];
            }

            double subAvg = subSum / k;

            maxAvg = Math.Max(maxAvg, subAvg);

            rigth++;
        }

        return maxAvg;
    }
}