int[] nums = { 1, 2, 1, 10 };
double result = LargestPerimeter(nums);
int LargestPerimeter(int[] nums)
{
    Array.Sort(nums, (x,y) => y.CompareTo(x));
    //int[] newarr = nums.Reverse();
    //int result = 0;
    //int sum = 0;
    int abSides = 0;
    int cSide = 0;

    for (int i = 0; i < nums.Length - 2; i++)
    {
        abSides = nums[i + 1] + nums[i + 2];
        cSide = nums[i];

        if (abSides > cSide)
        {
           return abSides + cSide;
        }
    }
    return 0;
}
int LargestPerimeter22(int[] nums)
{
    Array.Sort(nums); 
    int result = 0;
    int sum = 0;
    int abSides = 0;
    int cSide = 0;

    for (int i = 0; i < nums.Length - 2; i++)
    {
        abSides = nums[i] + nums[i + 1];
        cSide = nums[i + 2];

        if (abSides > cSide)
        {
            sum = abSides + cSide;
            if (sum > result)
                result = sum;
        }
    }
    return result;
}
int LargestPerimeter11(int[] nums)
{
    Array.Sort(nums);
    int a = 0, b = 0, c = 0, len = nums.Length - 2;
    int result = 0;
    int sum = 0;

    for (int i = 0; i < len; i++)
    {
        a = nums[i];
        b = nums[i + 1];
        c = nums[i + 2];

        if (a + b > c)
        {
            sum = a + b + c;
            if (sum > result)
                result = sum;
        }
        else
        {
            if (i + 1 >= len)
                return result;
        }
    }
    return result;
}
Console.WriteLine(result);
