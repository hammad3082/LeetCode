public class Solution
{
    public int MaxProduct(int[] nums)//TL
    {
        int ans = nums[0];

        int len = nums.Length;

        int sumFromLeft = 1, sumFromRight = 1;

        for (int i = 0; i < len; i++)
        {
            sumFromLeft = (sumFromLeft == 0 ? 1 : sumFromLeft) * nums[i];

            sumFromRight = (sumFromRight == 0 ? 1 : sumFromRight) * nums[len - 1 - i];

            ans = Math.Max(ans, Math.Max(sumFromLeft, sumFromRight));
        }

        return ans;
    }
    public int MaxProduct_TX(int[] nums)
    {
        int maxproduct = -10;

        for (int i = 0; i < nums.Length; i++)
        {
            int subProd = 1;
            for (int j = i; j < nums.Length; j++)
            {
                subProd *= nums[j];

                maxproduct = Math.Max(maxproduct, subProd);
            }
        }

        return maxproduct;
    }
}