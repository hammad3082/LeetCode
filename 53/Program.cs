Solution sol = new Solution();

sol.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int maxSum = int.MinValue, carryForward = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            carryForward += nums[i];

            if(carryForward > maxSum)
                maxSum = carryForward;

            if(carryForward <= 0)
                carryForward = 0;
        }

        return maxSum;
    }
    public int MaxSubArray_1(int[] nums)// time out :) 205 / 210 testcases passed
    {
        int maxSum = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            int subArraySum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                subArraySum += nums[j];

                if (subArraySum > maxSum)
                    maxSum = subArraySum;
            }
        }

        return maxSum;
    }
}