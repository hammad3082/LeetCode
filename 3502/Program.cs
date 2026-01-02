public class Solution
{
    public int[] MinCosts(int[] cost)
    {
        int min = cost[0];

        for (int i = 1; i < cost.Length; i++)
        {
            if (cost[i] > min)
                cost[i] = min;
            else
                min = cost[i];
        }

        return cost;
    }
}