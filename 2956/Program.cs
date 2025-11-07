public class Solution
{
    public int[] FindIntersectionValues(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        return new[] { nums1.Count(x => set2.Contains(x)), nums2.Count(x => set1.Contains(x)) };
    }

    public int[] FindIntersectionValues_TA(int[] nums1, int[] nums2)
    {
        bool[] check1 = new bool[101];
        bool[] check2 = new bool[101];
        foreach (var i in nums1)
            check1[i] = true;
        int[] ans = new int[2];
        foreach (var i in nums2)
        {
            if (check1[i]) ans[1]++;
            check2[i] = true;
        }
        foreach (var i in nums1)
        {
            if (check2[i]) ans[0]++;
        }
        return ans;
    }
}