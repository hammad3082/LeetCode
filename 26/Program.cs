
int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

int res = RemoveDuplicates(nums);


int RemoveDuplicates(int[] nums)
{
    int k = 0;
    int len = nums.Length;
    for (int i = 0; i +1  < len; i++)
    {
        if (nums[i] != nums[i + 1])
        {
            nums[k] = nums[i];
            k++;
        }
    }
    nums[k] = nums[len - 1];
    return  k + 1;
}

int RemoveDuplicatesff(int[] nums)
{
    int k = 0;
    int len = nums.Length;
    for (int i = 0; i + 1 < len; i++)
    {
        if (i == len - 2 || nums[i] != nums[i + 1])
        {
            nums[k] = nums[i];
            k++;
        }
    }
    //Array.Sort(nums);
    return k;
}
int RemoveDuplicates11(int[] nums)
{
    int k = 0;
    int j = 0;
    int rval = 0;
    int len = nums.Length;
    for (int i = 1; i < len; i++)
    {
        
        if (nums[i - 1] == nums[i])
        {
            //k++;
            rval = nums[i];
            nums[i] = 101;
            k++;
            j = i;
            while (j + 1 < len && rval == nums[j+1])
            {
                nums[j + 1] = 101;
                j++;
                k++;
            }
            i = j + 1;
        }
    }
    Array.Sort(nums);
    return len - k;
}
