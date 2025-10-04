public class Solution
{
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        var ans = new List<bool>();
        for (int i = 0; i < l.Length; i++)
        {
            int[] arr = new int[r[i] - l[i] + 1];
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = nums[l[i] + j];
            }

            ans.Add(check(arr));
        }

        return ans;
    }

    public bool check(int[] arr)
    {
        Array.Sort(arr);

        int diff = arr[1] - arr[0];

        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] != diff)
            {
                return false;
            }
        }

        return true;
    }
}