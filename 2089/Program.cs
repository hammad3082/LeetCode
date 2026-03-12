public class Solution
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        int count = 0, lessthan = 0;
        List<int> res = new();

        foreach (int n in nums)
        {
            if (n == target) 
                count++;

            if (n < target) 
                lessthan++;
        }

        for (int i = 0; i < count; i++)
        {
            res.Add(lessthan++);
        }

        return res;
    }
}