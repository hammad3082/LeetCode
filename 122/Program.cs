int[] prices = { 7, 1, 5, 3, 6, 4 };

int res = MaxProfit(prices);
Console.WriteLine(res);
int MaxProfit(int[] prices)
{
    int profit = 0, buyingPrice = prices[0], currentPrice = 0;
    for (int i = 1; i < prices.Length; i++)
    {
        currentPrice = prices[i];
        if (currentPrice < buyingPrice)
            buyingPrice = currentPrice;
        else if (currentPrice - buyingPrice > 0)
        {
            profit += currentPrice - buyingPrice;
            buyingPrice = currentPrice;
        }

    }
    return profit;
}
