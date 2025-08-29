Solution sol = new Solution();

sol.MissingNumber(new int[] { 9,6,4,2,3,5,7,0,1 });

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int xor = 0;
        for (int x = 0; x< nums.Length; x++)
        {
            xor ^= x + 1;
            xor ^= nums[x];
        }
        return xor;
    }
}