
Solution sol = new Solution();

int r1 =sol.SubarraySum(new int[] { 1, 1, 1 }, 2);
int r2 = sol.SubarraySum(new int[] { 1, 2, 3 }, 3);

//int r3 = sol.SubarraySum(new int[] { 1, -1, 0 }, 0);
//NumArray numArray = new NumArray(new int[] { 1, 7, 3, 6, 5, 6 });
int f = 1+1;
public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        int res = 0;
        int sum = 0;

        Dictionary<int, int> previous = new Dictionary<int, int>();
        previous[0] = 1;
        foreach (int x in nums)
        {
            sum += x;

            if (previous.ContainsKey(sum - k))
                res += previous[sum - k];

            previous[sum] = previous.GetValueOrDefault(sum)+ 1;
        }
       
        return res;
    }
    public int SubarraySum_rrrrr(int[] nums, int k)
    {
        int res = 0;

        int l = 0, r = 0;

        NumArray numArray = new NumArray(nums);

        while (r >= l && r < nums.Length)
        {
            int subSum = numArray.SumRange(l, r);

            if (subSum == k)
            {
                res++;
                r++;
                l++;
            }
            else if (subSum < k && r + 1 < nums.Length)
            {
                r++;
            }
            else
            {
                l++;
            }
        }
        return res;
    }
    public int SubarraySum_rr(int[] nums, int k)
    {
        int l = 0, r = 0;
        int res = 0, sum = 0;

        int[] sumArr = new int[nums.Length];

        while (r < nums.Length) 
        {
            
            while (nums[r] + sumArr[l] <= k)
            {
                sum += nums[r];
                sumArr[r] = sum;
                if (nums[r] + sumArr[l] == k)
                {
                    res++;
                }
                r++;
            }
            l--;
        }
        return res;
    }
}

public class NumArray
{
    int[] array;
    int[] sumArray;
    public NumArray(int[] nums)
    {
        int sum = 0;
        array = nums;
        sumArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            sumArray[i] = sum;
        }
    }

    public int SumRange(int left, int right)
    {
        if (left == 0)
            return sumArray[right];
        else
            return sumArray[right] - sumArray[left - 1];
    }
}