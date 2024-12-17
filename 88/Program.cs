
int[] nums1 = { 1, 2, 3, 0, 0, 0 };
int[] nums2 = { 2, 5, 6 };

Merge(nums1, 3, nums2, 3);


void Merge(int[] nums1, int m, int[] nums2, int n)
{
    if (n == 0)
    {
        return;
    }
    while(m>0 && n>0)
    {
        if (nums1[m -1] >= nums2[n-1])
        {
            nums1[n + m - 1] = nums1[m - 1];
            m--;
        }
        else
        {
            nums1[n + m - 1] = nums2[n - 1];
            n--;
        }
    }

}
void Merge_(int[] nums1, int m, int[] nums2, int n)
{
    if (n == 0)
    {
        return;
    }
    int[] tmp = new int[m+n];
    tmp = nums1.ToArray();
    int min = 0;
    int a = 0, b = 0;
    for (int i = 0; i < m + n; i++)
    {
        if (b == n || (a < m && tmp[a] <= nums2[b]))
        {
            min = tmp[a];
            a++;
        }
        else
        {
            min = nums2[b]; b++;
        }
        nums1[i] = min;
    }
}