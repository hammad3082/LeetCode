public class Solution
{
    public IList<IList<int>> FindMatrix(int[] nums)
    {
        var freqMap = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (freqMap.ContainsKey(num))
            {
                freqMap[num]++;
            }
            else
            {
                freqMap[num] = 1;
            }
        }

        int maxFreq = 0;
        foreach (var count in freqMap.Values)
        {
            maxFreq = Math.Max(maxFreq, count);
        }

        var result = new List<IList<int>>();
        for (int i = 0; i < maxFreq; i++)
        {
            result.Add(new List<int>());
        }

        foreach (var kvp in freqMap)
        {
            int num = kvp.Key;
            int count = kvp.Value;

            for (int i = 0; i < count; i++)
            {
                result[i].Add(num);
            }
        }

        return result;
    }
}