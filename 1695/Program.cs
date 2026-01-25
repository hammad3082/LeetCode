Solution sol = new Solution();
sol.MaximumUniqueSubarray(new int[] { 4, 2, 4, 5, 6 });

public class Solution
{
    public int MaximumUniqueSubarray(int[] nums)
    {
        int res = 0;
        int left = 0;
        int subSum = 0;

        bool[] visited = new bool[10001];

        for (int right = 0; right < nums.Length; right++)
        {
            subSum += nums[right];

            while (visited[nums[right]])
            {
                subSum -= nums[left];

                visited[nums[left]] = false;

                left++;
            }

            visited[nums[right]] = true;

            res = Math.Max(res, subSum);
        }

        return res;
    }
    public int MaximumUniqueSubarray_1(int[] nums)
    {
        int res = 0;
        int left = 0;
        int subSum = 0;

        HashSet<int> visited = new HashSet<int>();

        for (int right = 0; right < nums.Length; right++)
        {
            subSum += nums[right];

            while (visited.Contains(nums[right]))
            {
                subSum -= nums[left];

                visited.Remove(nums[left]);

                left++;
            }

            visited.Add(nums[right]);

            res = Math.Max(res, subSum);
        }

        return res;
    }
}