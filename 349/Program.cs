int[] nums1 = { 1, 2, 2, 1 };
int[] nums2 = { 2, 2 };
Intersection(nums1, nums2);
int[] Intersection(int[] nums1, int[] nums2)
{
    Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();

    foreach (int i in nums1)
    {
        keyValuePairs[i] = 1;
    }
    foreach (int i in nums2.Distinct())
    {
        keyValuePairs[i] = keyValuePairs.GetValueOrDefault(i) + 1;
    }

    int[] res  = keyValuePairs.Where(x => x.Value > 1).ToDictionary().Keys.ToArray();
    return res;
}