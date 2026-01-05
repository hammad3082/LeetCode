public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        IList<IList<int>> res = new List<IList<int>>();

        HashSet<int> hNum1 = new (nums1);
        HashSet<int> hNum2 = new(nums2);

        HashSet<int> res1 = new();
        HashSet<int> res2 = new();

        foreach (int i in nums1)
        {
            if(!hNum2.Contains(i))
                res1.Add(i);
        }

        foreach (int i in nums2)
        {
            if (!hNum1.Contains(i))
                res2.Add(i);
        }

        res.Add(res1.ToList());
        res.Add(res2.ToList());

        return res;
    }
}