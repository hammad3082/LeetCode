public class Solution
{
    public int CountPairs(IList<int> nums, int target)
    {
        int count = 0;
        int left = 0;
        int right = nums.Count - 1;

        nums = nums.OrderBy(x => x).ToList();

        while (left < right)
        {
            if (nums[left] + nums[right] < target)
            {
                count += right - left;
                left++;
            }
            else
            {
                right--;
            }
        }

        return count;
    }
}