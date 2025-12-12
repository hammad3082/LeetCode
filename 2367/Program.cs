public class Solution
{
    public int ArithmeticTriplets(int[] nums, int diff)
    {
        int res = 0, len = nums.Length;

        for (int i = 0; i < len; i++)
        {
            for (int j = i + 1; j < len; j++)
            {
                for (int k = j + 1; k < len; k++)
                {
                    if (nums[k] - nums[j] == diff && nums[j] - nums[i] == diff)
                        res++;
                }
            }
        }

        return res;
    }
}