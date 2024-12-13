
int[] nums = { 3,3,2 };

int[] res = TwoSum(nums, 5);

int[] TwoSum(int[] nums, int target)
{
    Dictionary<int,int> result = new Dictionary<int,int>();


    int[] results = new int[2];
    int first = 0, second = 0, diff = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        first = nums[i];

        diff = target - first;

        if (result.ContainsKey(diff))
        {
            result.TryGetValue(diff, out second);

            return new int[] { second,i};
        }
        if (!result.ContainsKey(first))
            result[first] = i;

    }
    return nums;
}


int[] TwoSum2(int[] nums, int target)
{
    int[] temp = new int[nums.Length];
    nums.CopyTo(temp, 0);
    Array.Sort(nums);
    int[] result = new int[2];
    int first = 0, second = 0;
    int j = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        first = nums[i];
        if (first >= target)
        {
            return result;
        }
        j = i + 1;
        while (j < nums.Length)
        {
            second = nums[j];
            if (first >= target)
            {
                break;
            }
            if (target == first + second)
            {
                result[0] = Array.IndexOf(temp, first);
                result[1] = Array.IndexOf(temp, second);

                return result;
            }
            j++;
        }
    }
    return nums;
}
Console.WriteLine(res[0]);
