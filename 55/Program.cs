
int[] nums = { 2, 0 };

bool dd = CanJump(nums);
Console.WriteLine(dd);
bool CanJump(int[] nums)
{
    int len  = nums.Length;
    int cur = 0,jump =0;
    for (int i = 0; i < len; i++)
    {
        if (jump == 0&& i + 1 == len)
            return true;

        if (jump < 0)
            return false;

        cur = nums[i];

        if(cur > jump) jump = cur;

        if(i+ 1 + jump >= len)
            return true;

        jump--;
    }

    return false;
}