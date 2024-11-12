// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] nums = { 1, 2, 2, 3 };

 bool result = IsMonotonic3(nums);
Console.WriteLine(result);

bool IsMonotonic(int[] nums)
{
    int dif = 0;
    bool desc = false;
    bool Check = true;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        dif = nums[i] - nums[i + 1];

        if (dif != 0 && Check)
        {
            Check = false;
            if (dif > 0)
                desc = true;
        }

        if (desc)
        {
            if (dif < 0)
                return false;
        }
        else
        {
            if (dif > 0)
                return false;
        }
    }
    return true;
}


bool IsMonotonic3(int[] nums)
{
    int len = nums.Length - 1;
    int mark = 0;
    int same = 0;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i] > nums[i + 1])
        {
            mark++;
        }
        else if (nums[i] == nums[i + 1])
        {
            same++;
        }
        else
        {
            mark--;
        }
    }

    if (len != Math.Abs(mark) + same)
        return false;
    else
        return true;
}

bool IsMonotonic1(int[] nums)
{
    bool asc = true;
    bool again = false;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        if ((i == 0 || again) )
        {
            if(nums[i] != nums[i + 1])
            {
                again = false;
                if (nums[i] > nums[i + 1])
                    asc = false;
            }
            else
            {
                again = true;
                continue;
            }
        }

        if (asc)
        {
            if (nums[i] > nums[i + 1])
            {
                return false;
            }
        }
        else
        {
            if (nums[i] < nums[i + 1])
            {
                return false;
            }
        }
    }

    return true;

}

//
//int dif = nums[i] - nums[i + 1];
// dif != 0 && dif > 0)//nums[i] > nums[i + 1])