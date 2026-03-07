public class Solution
{
    public int[] ApplyOperations(int[] nums)
    {
        int[] result = new int[nums.Length];
        int count = 0;
        int i;

        for (i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != 0)
            {
                if (nums[i] == nums[i + 1])
                {
                    result[count] = nums[i] * 2;
                    i++;
                }
                else
                    result[count] = nums[i];

                count++;
            }
        }

        if (i != nums.Length)
            result[count] = nums[nums.Length - 1];

        return result;
    }
}