Solution sol = new Solution();

sol.IsArraySpecial(new int[] { 4, 3, 1, 6 });

public class Solution
{
    public bool IsArraySpecial(int[] nums)
    {
        int half = nums.Length / 2;

        int evenIndex = 0;
        int oddIndex = 0;

        if (nums[0] % 2 == 0)
        {
            evenIndex = 2;
            oddIndex++;
        }
        else
        {
            oddIndex = 2;
            evenIndex++;
        }

        //bool evenStart = nums[0] % 2 == 0;

        while (evenIndex < nums.Length || oddIndex < nums.Length)
        {
            if (evenIndex < nums.Length && nums[evenIndex] % 2 != 0)
                return false;
            if (oddIndex < nums.Length && nums[oddIndex] % 2 == 0)
                return false;

            evenIndex += 2;
            oddIndex += 2;
        }
        return true;
    }
}