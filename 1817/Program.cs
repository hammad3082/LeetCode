public class Solution
{
    public int[] FindingUsersActiveMinutes(int[][] logs, int k)
    {
        int[] res = new int[k];

        Dictionary<int,HashSet<int>> userIdTimes = new Dictionary<int,HashSet<int>>();

        foreach (int[] log in logs)
        {
            if(userIdTimes.ContainsKey(log[0]))
                userIdTimes[log[0]].Add(log[1]);
            else
                userIdTimes[log[0]] = new HashSet<int>() { log[1] };
        }

        foreach(var Counts in userIdTimes.Values)
        {
            res[Counts.Count - 1]++;
        }

        return res;
    }
}