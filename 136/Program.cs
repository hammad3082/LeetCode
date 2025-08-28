Solution sol = new Solution();

//sol.SingleNumber(new int[] { 2, 2, 1 });
sol.SingleNumber(new int[] { 4, 1, 2, 1, 2 });

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int xor = 0;

        foreach (int x in nums)
        {
            xor = xor ^ x;
        }

        return xor;
    }
}