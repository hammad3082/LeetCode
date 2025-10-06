
Solution sol = new Solution();

sol.NextPermutation(new int[] { 1, 2, 3 });
public class Solution
{
    public void NextPermutation(int[] nums)
    {
        int n = nums.Length;
        int i = n - 2;

        // Step 1: Find first decreasing element from right
        while (i >= 0 && nums[i] >= nums[i + 1])
            i--;

        if (i >= 0)
        {
            // Step 2: Find next greater element on right of i
            int j = n - 1;
            while (nums[j] <= nums[i])
                j--;

            // Step 3: Swap them
            (nums[i], nums[j]) = (nums[j], nums[i]);
        }

        // Step 4: Reverse suffix
        Array.Reverse(nums, i + 1, n - (i + 1));
    }
    public void NextPermutation_11(int[] nums)// fixed
    {
        int n = nums.Length;

        for (int i = n - 2; i >= 0; i--)
        {
            if (nums[i] < nums[i + 1])
            {
                // Find the smallest number greater than nums[i] to the right
                int nextGreaterIndex = i + 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[j] > nums[i] && nums[j] <= nums[nextGreaterIndex])
                    {
                        nextGreaterIndex = j;
                    }
                }

                // Swap
                (nums[i], nums[nextGreaterIndex]) = (nums[nextGreaterIndex], nums[i]);

                // Reverse everything to the right of i
                Array.Reverse(nums, i + 1, n - (i + 1));

                return;
            }
        }

        // If we didn’t find any dip, array is descending → smallest permutation
        Array.Reverse(nums);
    }

    public void NextPermutation_wr(int[] nums)
    {
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i] < nums[i + 1] )
            {
                int temp = nums[i];

                int replacement = nums[i + 1];
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    if(nums[j] < nums[j + 1] && temp > nums[j])
                        replacement = Math.Min(replacement, nums[j]);

                }

                nums[i] = replacement;
                nums[i + 1] = temp;

                if (i + 2 < nums.Length)
                {
                    for (int k = i + 1; i < nums.Length - 1; k++)
                    {
                        int min_idx = i;

                        for (int j = i + 1; j < nums.Length; j++)
                        {
                            if (nums[j] < nums[min_idx])
                            {
                                min_idx = j;
                            }
                        }

                        int temp1 = nums[min_idx];
                        nums[min_idx] = nums[i];
                        nums[i] = temp1;
                    }
                }

                return;
            }
        }

        Array.Sort(nums);
    }
}