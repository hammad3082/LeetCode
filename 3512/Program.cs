public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        int sum = 0;

        foreach (int i in nums) 
            sum += i;

        return sum%k;
    }
}