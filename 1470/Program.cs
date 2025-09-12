public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        int[] res = new int[nums.Length];

        int ri = 0;
        for (int i = 0; i < n; i++)
        {
            res[ri++] = nums[i];

            res[ri++] = nums[i + n];
        }

        return res;
    }
}