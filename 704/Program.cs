
Solution sol = new Solution();
sol.Search(new int[] { 9}, 9);
public class Solution
{
    public int Search(int[] nums, int target)
    {
        return binarySearch(nums, 0, nums.Length - 1, target);
    }

    public static int binarySearch(int[] nums, int l, int r, int target)
    {
        if (l > r) return -1;

        int mid = (l + r) / 2;

        if (nums[mid] == target)
        {
            return mid;
        }
        else if (target > nums[mid])
        {
            return binarySearch(nums, mid + 1, r, target);
        }
        else
        {
            return binarySearch(nums, l, mid - 1, target);
        }
    }
    public int Search_1(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1;
        int mid = 0;

        while (l < r)
        {
            mid = (l + r) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }
        return -1;
    }
    public int Search_w(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1;
        int mid = r / 2;

        while (l < r)
        {
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                r = mid - 1;
                mid -= r / 2;
            }
            else
            {
                l = mid + 1;
                mid += (r - l) / 2;
            }
        }
        return -1;
    }
}