Solution sol = new Solution();

int res1 = sol.PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 });
public class Solution
{
    public int PivotIndex(int[] nums)
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
    public int PivotIndex_1(int[] nums)
    {
        int sum = 0;
        int[] sumArr = new int[nums.Length + 1];
        //sumArr[0] = 0;

        int i = 0;
        foreach (int num in nums)
        {
            sum += num;
            sumArr[++i] = sum;
        }
        //int FinalSum = sumArr[sumArr.Length - 1];
        for (int j = 1; j < sumArr.Length; j++)
        {
            if (sum - sumArr[j] == sumArr[j - 1])
                return j - 1;
        }
        return -1;
    }
}