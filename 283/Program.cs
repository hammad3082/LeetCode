// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

int[] nums = { 0, 0, 1 };
MoveZeroes2(nums);
Console.WriteLine(nums);

void MoveZeroes(int[] nums)
{ 
}
void MoveZeroes2(int[] nums)
{
    int len = nums.Length;
    for (int i = 0; i < len; i++)
    {
        if (nums[i] == 0)
        {
            int j = i;
            bool repeat = false;
            for (int k = i; k < len - 1; k++)
            {
                if (nums[k + 1] == 0)
                {
                    int sum = 0;
                    if (k + 2 < nums.Length)
                    {
                        for(int s = k + 2; s < len; s++)
                        {
                            sum = nums[s];
                            if (nums[s] != 0)
                                break;
                        }
                    }
                    //long sum = nums.Skip(k + 2).Take(len - (k + 2)).Select(x => (long)x).Sum();

                    if (sum != 0)
                    {
                        if (!repeat)
                        {
                            i = k - 1;
                            repeat = true;
                        }
                        continue;
                    }
                    else
                    {
                        if (!repeat)
                            return;
                        break;
                    }
                }
                int temp = nums[k + 1];
                nums[k + 1] = nums[k];
                nums[k] = temp;
            }

        }
    }
}


void MoveZeroes1(int[] nums)
{
    int len = nums.Length;
    for (int i = 0; i < len; i++)
    {
        if (nums[i] == 0)
        {
            for (int j = len - 1; j >= 0; j--)
            {
                if (i == j)
                    break;
                if (nums[j] != 0)
                {
                    nums[i] += nums[j];
                    nums[j] = nums[i] - nums[j];
                    nums[i] = nums[i] - nums[j];
                    break;
                }
            }
        }
    }
}


