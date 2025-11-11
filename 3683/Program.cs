Solution sol = new Solution();
sol.EarliestTime(new int[][] { new int[] { 1, 6 }, new int[] { 2, 3 } });

public class Solution
{
    public int EarliestTime(int[][] tasks)
    {
        int minTime = int.MaxValue, time = 0;

        foreach (int[] task in tasks)
        {
            time = task[0] + task[1];

            if (time < minTime)
                minTime = time;
        }

        return minTime;
    }
}
