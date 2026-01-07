public class Solution
{
    public int[] FrequencySort(int[] nums)
    {
        Dictionary<int, int> keyValues = new Dictionary<int, int>();

        foreach (int i in nums)
        {
            keyValues[i] = (keyValues.TryGetValue(i, out int val) ? val : 0) + 1;
        }

        Array.Sort(nums, (a, b) => 
        {
            if (keyValues[a] != keyValues[b])
                return keyValues[a].CompareTo(keyValues[b]);

            return b.CompareTo(a);
        });

        return nums;
    }
    public int[] FrequencySort_1(int[] nums)//solves but wrong way
    {
        Dictionary<int, int> keyValues = new Dictionary<int, int>();

        List<int> result = new List<int>();

        foreach (int i in nums)
        {
            keyValues[i] = (keyValues.TryGetValue(i, out int val) ? val : 0) + 1;
        }

        int uniqueNumCount = keyValues.Count;

        int loopLength = nums.Length;

        for (int i = 0; i <= loopLength; i++)
        {
            if (uniqueNumCount == 0)
                break;
            int[] arr = keyValues.Where(x => x.Value == i)?.Select(x => x.Key)?.ToArray();

            if (arr.Length > 0)
            {
                Array.Sort(arr, (x, y) => y.CompareTo(x));

                foreach (int x in arr)
                {
                    int loopCount = i;
                    while (loopCount > 0)
                    {
                        result.Add(x);
                        loopCount--;
                    }
                }
                uniqueNumCount--;
            }
        }

        return result.ToArray();
    }
}