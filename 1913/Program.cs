public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        int FirstMax = int.MinValue;
        int SecondMax = FirstMax;

        int FirstMin = int.MaxValue;
        int SecondMin = FirstMin;

        for (int i = 0; i < nums.Length; i++)
        {
            if (FirstMax < nums[i])
            {
                SecondMax = FirstMax;
                FirstMax = nums[i];
            }
            else if (nums[i] > SecondMax)
                SecondMax = nums[i];

            if (FirstMin > nums[i])
            {
                SecondMin = FirstMin;
                FirstMin = nums[i];
            }
            else if (nums[i] < SecondMin)
                SecondMin = nums[i];
        }

        return (FirstMax * SecondMax) - (FirstMin * SecondMin);
    }
}