
Solution Solution = new Solution();

Solution.NumIdenticalPairs(new int[] { 1, 2, 3, 1, 1, 3 });
public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        int res = 0;

        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int i in nums)
        {
            map[i] = map.GetValueOrDefault(i, 0) + 1;
        }
            
        foreach(int count in map.Values)
        {
            res += count * (count - 1) / 2;
        }

        return res;
    }
}