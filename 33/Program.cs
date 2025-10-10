
Solution sol = new Solution();

sol.Search(new int[] { 5, 1, 3 }, 1);
public class Solution
{
    public int Search(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1;
        int mid = 0;
        int pivot = 0;

        for (int i = nums.Length - 1; i > 0; i--)
        {
            if (nums[i] <= nums[i - 1])
            {
                pivot = nums.Length - i;
                break;
            }
        }

        while (l <= r)
        {
            mid = (l + r) / 2;

            //int realMid = (mid + pivot) % nums.Length;

            int realMid = (mid - pivot + nums.Length) % nums.Length;//finding the actual num present in this mid before the shift

            if (nums[realMid] == target)
            {
                return realMid;
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
    public int Search_(int[] nums, int target)// gpt modifed mine but kida ulta
    {
        int n = nums.Length;
        int l = 0, r = n - 1;

        // Step 1️⃣: Find pivot — index of smallest element
        int pivot = 0;
        for (int i = 1; i < n; i++)
        {
            if (nums[i] < nums[i - 1])
            {
                pivot = i;   // smallest element (start of rotation)
                break;
            }
        }

        // Step 2️⃣: Standard binary search, but shifted by pivot
        while (l <= r)
        {
            int mid = (l + r) / 2;

            // Map mid to actual index in rotated array (left rotation)
            int realMid = (mid + pivot) % n;

            if (nums[realMid] == target)
                return realMid;

            if (nums[realMid] < target)
                l = mid + 1;
            else
                r = mid - 1;
        }

        return -1;
    }
   
}