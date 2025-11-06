public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        int res = 0;

        foreach (int i in nums)
        {
            if (i < k)
                res++;
        }

        return res;
    }
}