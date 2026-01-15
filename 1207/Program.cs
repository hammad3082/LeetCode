public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> keyValues = new Dictionary<int, int>();
        HashSet<int> uniqueFreq = new HashSet<int>();

        foreach (int num in arr)
            keyValues[num] = keyValues.TryGetValue(num, out int val) ? val + 1 : 1;

        foreach (var freq in keyValues.Values)
        {
            if (uniqueFreq.Contains(freq))
                return false;
            else
                uniqueFreq.Add(freq);
        }

        return true;
    }
}