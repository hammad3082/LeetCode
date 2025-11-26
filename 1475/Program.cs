Solution sol = new Solution();

sol.FinalPrices(new int[] { 8, 4, 6, 2, 3 });
public class Solution
{
    public int[] FinalPrices(int[] prices)
    {
        //int[] res = new int[prices.Length];

        for (int i = 0; i < prices.Length - 1; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] <= prices[i])
                {
                    prices[i] -= prices[j];
                    break;
                }
            }
        }

        return prices;
    }
}