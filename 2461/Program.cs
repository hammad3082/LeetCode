Solution sol = new Solution();
sol.MaximumSubarraySum(new int[] { 1, 5, 4, 2, 9, 9,5, 9, 9, 4,5,6 }, 3);

public class Solution
{
    public long MaximumSubarraySum(int[] nums, int k)
    {
        int n = nums.Length;
        long subSum = 0;
        long maxSum = 0;
        int left = 0;

        HashSet<int> visited = new HashSet<int>();
        
        for (int right = 0; right < n; right++)
        {
            if (!visited.Contains(nums[right]))
            {
                subSum += nums[right];
                visited.Add(nums[right]);

                if (right - left + 1 == k)
                {
                    maxSum = Math.Max(maxSum, subSum);

                    subSum -= nums[left];
                    visited.Remove(nums[left]);
                    left++;
                }
            }
            else
            {
                while (nums[left] != nums[right])
                {
                    subSum -= nums[left];
                    visited.Remove(nums[left]);
                    left++;
                }
                left++;
            }
        }

        return maxSum;
    }
}