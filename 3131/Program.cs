public class Solution
{
    public int AddedInteger(int[] nums1, int[] nums2)
    {
        int sum1 = 0, sum2 = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            sum1 += nums1[i];
            sum2 += nums2[i];
        }

        return (sum2 - sum1) / nums1.Length;
    }

    public int AddedInteger_1(int[] nums1, int[] nums2)
    {
        var result = 0;

        for (var i = 0; i < nums2.Length; i++)
            result += nums2[i] - nums1[i];

        return result / nums1.Length;
    }
}