int[] nums = //{ 2, 3, 1, 1, 4 }
{ 7, 0, 9, 6, 9, 6, 1, 7, 9, 0, 1, 2, 9, 0, 3 };

int dd = CanJump(nums);
Console.WriteLine(dd);
int CanJump(int[] nums)
{
    int len = nums.Length;
    int near = 0, far = 0, jump = 0, farthest;

    while (far < len - 1)
    {
        farthest = 0;
        for (int i = near; i <= far; i++) { 
            farthest = Math.Max(farthest, i + nums[i]);
        }
        near = far + 1;
        far = farthest;
        jump++;

    }

    return jump;
}
int CanJump1(int[] nums)
{
    int len = nums.Length;
    int cur = 0, jump = 0, count = 0, max;

    for (int i = 0; i < len; i++)
    {
    //    if (jump == 0 && i + 1 == len)
    //        return jump + 1;

        if (jump < 0)
            return count;

        cur = nums[i];
        if (cur > 0 && (i + 1 == len))
            return count;


        if (cur > jump )
        {
            jump = cur;

            count++;
        }

        if (i + 1 + jump >= len)
            return count;

        jump--;
    }

    return count;
}