Solution sol = new Solution();
sol.NumSubarrayProductLessThanK(new int[] { 1, 2, 3 }, 0);

public class Solution
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)//TS
    {
        if (k <= 1)
            return 0;

        int res = 0;
        int left = 0;
        int subProd = 1;

        for (int right = 0; right < nums.Length; right++)
        {
            subProd *= nums[right];

            while(subProd >= k)
            {
                subProd /= nums[left];
                left++;
            }

            res += right - left + 1;
        }

        return res;
    }
    public int NumSubarrayProductLessThanK_1(int[] nums, int k)
    {
        int res = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int subProd = 1;
            for (int j = i; j < nums.Length; j++)
            {
                subProd *= nums[j];

                if (subProd < k)
                    res++;
                else
                    break;
            }
        }

        return res;
    }
}