public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        HashSet<int> hNum1 = new (nums1);
        HashSet<int> hNum2 = new(nums2);

        List<int> res1 = new();
        List<int> res2 = new();

        foreach (int i in hNum1)
        {
            if(!hNum2.Contains(i))
                res1.Add(i);
        }

        foreach (int i in hNum2)
        {
            if (!hNum1.Contains(i))
                res2.Add(i);
        }

        return new List<IList<int>> { res1, res2 };
    }
}