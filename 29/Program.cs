int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };

int res = RemoveElement(nums, 2);

int RemoveElement(int[] nums, int val)
{
    int k = 0;
    for (int i = 0; i < nums.Length;i++)
    {
        if (nums[i] == val)
        {
            k++;
            nums[i] = 101;
        }
    }
    Array.Sort(nums);
    return k;
}
