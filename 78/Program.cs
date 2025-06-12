
using System.Linq;

Solution sol = new Solution();

sol.Subsets(new int[]  { 1, 2, 3 });

public class Solution22
{
    IList<IList<int>> res = new List<IList<int>>();

    public IList<IList<int>> Subsets(int[] nums)
    {
        Backtrack(nums, 0, new List<int>());
        return res;
    }

    private void Backtrack(int[] nums, int start, List<int> path)
    {
        res.Add(new List<int>(path));  // Add current subset

        for (int i = start; i < nums.Length; i++)
        {
            path.Add(nums[i]);
            Backtrack(nums, i + 1, path);  // Only go forward
            path.RemoveAt(path.Count - 1); // Backtrack
        }
    }
}
public class Solution
{
    IList<IList<int>> res;
    public IList<IList<int>> Subsets(int[] nums)
    {
        res = new List<IList<int>>();

        List<int> list = new List<int>();

        BackTrack(new List<int>(nums), list, 0);
        return res;
    }

    public void BackTrack(List<int> nums, IList<int> list, int start)
    {
        res.Add(new List<int>(list));
      
        for (int i = start; i < nums.Count; i++)
        {
            list.Add(nums[i]);
            BackTrack(nums, list, i + 1);
            list.Remove(nums[i]);
        }
    }


    public void BackTrack1(List<int> nums, IList<int> list, int start)
    {
        if (!res.Contains(list.OrderByDescending(x => x).ToList()))
        {
            res.Add(new List<int>(list.OrderByDescending(x => x)));
            //return;
        }

        for (int i = 0; i < nums.Count; i++)
        {
            list.Add(nums[i]);
            List<int> nums2 = new List<int>(nums);
            nums2.RemoveAt(i);
            BackTrack1(nums2, list, i + 1);
            list.Remove(nums[i]);
        }

    }
}