Solution sol = new Solution();
sol.SumOfSquares(new int[] { 1, 2, 3, 4 });

public class Solution
{
    public int SumOfSquares(int[] nums)
    {
        int res = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if (nums.Length % (i + 1)== 0)
                res += nums[i] * nums[i];
        }

        return res;
    }
}