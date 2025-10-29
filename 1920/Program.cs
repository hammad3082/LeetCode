public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            //int index = nums[i];

            res[i] = nums[nums[i]];
        }

        return res;
    }
}