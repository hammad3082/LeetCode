﻿
int[] nums = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

int res = RemoveDuplicates(nums);


int RemoveDuplicates(int[] nums)
{
    int k = 0;
    int len = nums.Length;
    bool pass = true;
    for (int i = 0; i + 1 < len; i++)
    {
        if (nums[i] == nums[i + 1] && pass)
        {
            nums[k] = nums[i]; k++;
            pass = false;
        }
        else if (nums[i] != nums[i + 1])
        {
            nums[k] = nums[i];
            k++;
            pass = true;
        }
    }
    nums[k] = nums[len - 1];
    return k++;
}

