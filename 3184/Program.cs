Solution sol = new Solution();
sol.CountCompleteDayPairs(new int[] { 12, 12, 30, 24, 24 });
public class Solution
{
    public int CountCompleteDayPairs(int[] hours)
    {
        var rests = new int[24];
        var result = 0;
        foreach (var hour in hours)
        {
            var rem = hour % 24;
            var missing = (24 - rem) % 24;
            result += rests[missing];
            rests[rem]++;
        }

        return result;
    }
    public int CountCompleteDayPairs_1(int[] hours)
    {
        int res = 0;

        for (int i = 0; i < hours.Length; i++)
        {
            for (int j = i + 1; j < hours.Length; j++)
            {
                if ((hours[j] + hours[i]) % 24 == 0)
                    res++;
            }
        }

        return res;
    }
}