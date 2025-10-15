public class Solution
{
    public string FrequencySort(string s)
    {
        return new string(
            s.GroupBy(c => c)
             .OrderByDescending(g => g.Count())
             .SelectMany(g => Enumerable.Repeat(g.Key, g.Count()))
             .ToArray()
        );
    }
}