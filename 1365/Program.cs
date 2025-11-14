public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    if (nums[j] <  nums[i])
                        count++;
                }
            }
            res[i] = count;
        }

        return res;
    }

    public int[] SmallerNumbersThanCurrent_TA(int[] nums)
    {
        // Step 1: frequency count of values in [0, 100]
        int[] freq = new int[101];
        for (int i = 0; i < nums.Length; i++)
        {
            freq[nums[i]]++;
        }

        // Step 2: prefix sum
        // prefix[i] = how many numbers are strictly less than i
        int[] prefix = new int[101];
        int running = 0;
        for (int v = 0; v < 101; v++)
        {
            prefix[v] = running;
            running += freq[v];
        }

        // Step 3: build result
        int[] res = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = prefix[nums[i]];
        }

        return res;
    }

    public int[] SmallerNumbersThanCurrent_TA2(int[] nums)
    {
        int[] sortedNums = new int[nums.Length];
        Array.Copy(nums, sortedNums, nums.Length);
        Array.Sort(sortedNums);

        int[] result = new int[nums.Length];

        Dictionary<int, int> numsMap = new Dictionary<int, int>();

        for (int i = 0; i < sortedNums.Length; i++)
        {
            if (!numsMap.ContainsKey(sortedNums[i]))
            {
                numsMap[sortedNums[i]] = i;
            }

        }

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = numsMap[nums[i]];
        }
        return result;
    }
}