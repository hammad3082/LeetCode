Solution sol = new Solution();

sol.FindMissingElements(new int[] { 19, 84, 30, 59, 13, 100 });
public class Solution
{
    public IList<int> FindMissingElements(int[] nums)
    {
        List<int> res = new List<int>();

        bool[] visited = new bool[101];

        int min = nums[0];
        int max = nums[0];
        visited[nums[0]] = true;

        for (int i = 1; i < nums.Length; i++)
        {
            min = Math.Min(nums[i], min);
            max = Math.Max(nums[i], max);

            visited[nums[i]] = true;
        }

        for (int i = min; i <= max; i++)
        {
            if (!visited[i])
                res.Add(i);
        }

        return res;
    }
    public IList<int> FindMissingElements_1(int[] nums)
    {
        List<int> res = new List<int>();

        HashSet<int> visited = new HashSet<int>();

        int min = nums[0];
        int max = min;
        visited.Add(min);

        for (int i = 1; i < nums.Length; i++)
        {
            min = Math.Min(nums[i], min);
            max = Math.Max(nums[i], max);

            visited.Add(nums[i]);
        }

        for (int i = min; i <= max; i++)
        {
            if(!visited.Contains(i))
                res.Add(i);
        }

        return res;
    }
}