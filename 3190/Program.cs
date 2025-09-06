
Solution Solution = new Solution();

Solution.MinimumOperations(new int[] { 1, 2, 3, 4 });
public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        int sumRem = 0;

        foreach (int num in nums)
        {
            int rem = num % 3;

            if (rem == 2)// instead of adding 2 subtract 1
                rem = 1;
            sumRem += rem;
        }
        //foreach (int num in nums)
        //{
        //    sumRem += num >= 3 ? num % 3 : Math.Min(3 - num, num % 3);
        //}
        return sumRem;
    }
}