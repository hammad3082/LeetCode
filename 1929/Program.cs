public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] newArr = new int[nums.Length * 2];

        for (int i = 0; i < nums.Length; i++)
        {
            newArr[i] = nums[i];

            newArr[i + nums.Length] = nums[i];
        }

        return newArr;
    }
}