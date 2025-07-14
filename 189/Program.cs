public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int[] record = nums.ToArray();
        for (int i = 0; i < nums.Length; i++)
        {
            int newIndex = (i + k) % nums.Length;

            nums[newIndex] = record[i];
        }
    }
}