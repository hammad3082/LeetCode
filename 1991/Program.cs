Solution sol = new Solution();

int res1 = sol.FindMiddleIndex(new int[] { 1, 7, 3, 6, 5, 6 });
public class Solution
{
    public int FindMiddleIndex(int[] nums)
    {
        int Total = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            Total += nums[i];
        }
        int leftSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            leftSum += nums[i];

            if (leftSum == Total)
            {
                return i;
            }
            Total -= nums[i];
        }
        return -1;
    }
    public int FindMiddleIndex_me(int[] nums)
    {
        int sum = 0;
        int leftSum = 0, rightSum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }

        for (int j = 0; j < nums.Length; j++)
        {
            rightSum = sum - leftSum - nums[j];
            if (rightSum == leftSum)
                return j;
            leftSum += nums[j];
        }
        return -1;
    }
}