

int[] nums = { -1, -2, -3 , -4, 0};
int result = ArraySign(nums);
Console.WriteLine(result);
int ArraySign(int[] nums)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 0) { return 0; }
        if (nums[i] < 0) { count++; }
    }
    if (count % 2 != 0)
        return -1;
    return 1;
}
