public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;

        while (l <= r)
        {
            int mid = (l + r) / 2;

            if (nums[mid] == target)
            {
                int first = mid;
                int last = mid;

                while(last < nums.Length)
                {
                    if (nums[last + 1] == target)
                    {
                        last++;
                    }
                    else
                        break;
                }
                while (first >= 0)
                {
                    if (nums[first - 1] == target)
                    {
                        first--;
                    }
                    else
                        break;
                }

                return new int[]{ first, last };
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

        return new int[] { -1, -1 };
    }

    public int[] SearchRange_tp(int[] nums, int target)
    {
        int[] ans = new int[] { -1, -1 };

        int low = 0, high = nums.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] >= target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
            if (nums[mid] == target) ans[0] = mid;
        }

        low = 0;
        high = nums.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] <= target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
            if (nums[mid] == target) ans[1] = mid;
        }

        return ans;
    }
}