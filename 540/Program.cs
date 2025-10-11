Solution sol = new Solution();

sol.SingleNonDuplicate(new int[] { 3, 3, 7, 7, 10, 11, 11 });

public class Solution
{
    public int SingleNonDuplicate(int[] nums)
    {
        int left = 0, right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (mid % 2 == 1)
                mid--;

            // Check if mid is the single element
            if (mid > 0 && nums[mid] != nums[mid - 1] && nums[mid] != nums[mid + 1])
                return nums[mid];

            if (nums[mid] == nums[mid + 1])
                left = mid + 2;
            else
            {
                right = mid;
            }
        }

        return nums[left];
    }
    public int SingleNonDuplicate_11(int[] nums)
    {
        int left = 0, right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (mid % 2 == 1)
                mid--;

            if (nums[mid] == nums[mid + 1])
                left = mid + 2;
            else
            {
                if(nums[mid] != nums[mid - 1])
                    return nums[mid];
                right = mid;
            }
        }
        
        return nums[left];
    }
    public int SingleNonDuplicate_0(int[] nums)
    {
        int n = nums.Length;

        if (n == 1)
            return nums[0];
        if (nums[0] != nums[1])
            return nums[0];
        if (nums[n - 1] != nums[n - 2])
            return nums[n - 1];

        int low = 1, high = n - 2;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            // If nums[mid] is the single element
            if (nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
                return nums[mid];

            // We are in the left (pairs are perfect so far)
            if ((mid % 2 == 1 && nums[mid] == nums[mid - 1]) ||
                (mid % 2 == 0 && nums[mid] == nums[mid + 1]))
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return -1;
    }
}