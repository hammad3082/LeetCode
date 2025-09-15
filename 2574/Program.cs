Solution sol = new Solution();

sol.LeftRightDifference(new int[] { 10, 4, 8, 3 });

public class Solution
{
    public int[] LeftRightDifference(int[] nums)
    {
        int len = nums.Length;
        int[] leftSum = new int[len];
        int[] rightSum = new int[len];

        for (int i = 0, j = nums.Length - 1; i < nums.Length - 1; i++, j--)
        {
            leftSum[i + 1] = nums[i] + leftSum[i];
            rightSum[j - 1] = nums[j] + rightSum[j];
        }

        //for (int i = 1; i < len; i++)
        //{
        //    leftSum[i] = leftSum[i - 1] + nums[i - 1];

        //    rightSum[len - 1 - i] = nums[len - i] + rightSum[len - i];
        //}

        for (int i = 0; i < len; i++)
        {
            nums[i] = Math.Abs(leftSum[i] - rightSum[i]);
        }
        return nums;
    }
}