
Solution sol = new Solution();

int res = sol.CanCompleteCircuit(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3,4,5,1,2});
int res2 = sol.CanCompleteCircuit(new int[] { 5, 1, 2, 3, 4 }, new int[] { 4, 4, 1, 5, 1 });
int res3 = sol.CanCompleteCircuit(new int[] { 4, 5, 3, 1, 4 }, new int[] { 5, 4, 3, 4, 2 });
int res4 = sol.CanCompleteCircuit(new int[] { 2 }, new int[] { 2 });

int f = 8 - 8;

public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)//smart
    {
        int totalTank = 0;
        int currentTank = 0;
        int startIndex = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            totalTank += gas[i] - cost[i];
            currentTank += gas[i] - cost[i];

            if (currentTank < 0)
            {
                startIndex = i + 1;
                currentTank = 0;
            }
        }

        return totalTank >= 0 ? startIndex : -1;
    }
}
public class Solution11
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int len = gas.Length;
        //int start = -1;
        int Tank = 0;

        Dictionary<int, int> StartPointAndTank = new Dictionary<int,int>();

        for (int i = 0; i < len; i++)
        {
            Tank = gas[i] - cost[i];
            if (Tank >= 0)
            {
                StartPointAndTank.Add(i, Tank);
            }
        }

        if (StartPointAndTank.Count == 0)
            return -1;

        foreach (var (start, tank) in StartPointAndTank)
        {
            Tank = tank;
            int k = start + 1;
            if (start == len - 1)
                k = 0;

            if (k == start)
                return start;

            while (Tank > 0)
            {
                //if (k == start)
                //    return start;
                Tank += Convert.ToInt32(gas[k]) - Convert.ToInt32(cost[k]);

                if (k == len - 1)
                    k = 0;
                else
                    k++;

                if (k == start && Tank >= 0)
                    return start;
            }
        }

        return -1;
    }
    public int CanCompleteCircuit111(int[] gas, int[] cost)
    {
        int len = gas.Length;
        int start = -1;
        int T = 0;

        for (int i = 0; i < len; i++)
        {
            T = Convert.ToInt32(gas[i]) - Convert.ToInt32(cost[i]);
            if (T > 0)
            {
                start = i;
                break;
            }
        }

        if (start < 0)
            return -1;

        int k = start + 1;
        if (start == len - 1)
            k = 0;

        while (T > 0)
        {
            T += Convert.ToInt32(gas[k]) - Convert.ToInt32(cost[k]);

            if (k == len - 1)
                k = 0;
            else
                k++;

            if (k == start)
                return start;
        }

        return -1;
    }
}