
int[] prices = { 7, 1, 5, 3, 6, 4 };

int res = MaxProfit(prices);
Console.WriteLine(res);
int MaxProfit(int[] prices)
{
    int profit = 0, b = prices[0], p = 0;
    for (int i = 1; i < prices.Length; i++)
    {
        p = prices[i];
        if(p < b)
            b = p;
        else
            if (p - b> profit)
                profit = p - b;

    }
    return profit;
}

int MaxProfit_(int[] prices)
{
    int profit = 0, b = 0, s = 0, ch = prices[0];
    for (int i = 0; i < prices.Length; i++)
    {
        b = prices[i];

        if (b < ch || i + 1 == prices.Length)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                s = prices[j];

                if (s - b > profit)
                    profit = s - b;
            }
        }
    }
    return profit > 0 ? profit : 0;
}