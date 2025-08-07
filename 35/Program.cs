Solution sol = new Solution();

sol.SearchInsert(new int[] { 1, 2, 4, 6, 8, 9, 10 }, 10);
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;


        while (left < right)
        {
            int middle = nums.Length / 2;

            if (nums[middle] == target)
            {
                return middle;
            }
            else if (nums[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return left;
    }
    public int SearchInsert1(int[] nums, int target) //works but messy
    {
        if (target > nums[nums.Length - 1])
            return nums.Length;

        if (target <= nums[0])
            return 0;

        int left = 0, right = nums.Length;

        int middle = nums.Length / 2;

        while (left < right)
        {
            if (nums[middle] == target)
            {
                return middle;
            }
            else if (nums[middle] < target)
            {
                if (nums[middle + 1] >= target)
                {
                    return middle + 1;
                }

                left = middle;
            }
            else
            {
                if (nums[middle - 1] < target)
                {
                    return middle;
                }
                right = middle;
            }

            middle = left + (right - left) / 2;
        }

        return 0;
    }
}