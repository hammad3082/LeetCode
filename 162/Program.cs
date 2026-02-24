Solution sol = new Solution();

sol.FindPeakElement(new int[] { 1, 2, 3, 1 });

public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        int l = 0;
        int r = nums.Length - 1;

        while (l < r)
        {
            int m = (l + r) / 2;

            int lm = Math.Max(m-1, l);
            int rm = Math.Min(m+1, r);

            if(nums[m] > nums[lm] && nums[m] > nums[rm])
                return m;
            else if(nums[m] < nums[rm])
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }

        return l;
    }
}