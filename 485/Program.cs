// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int res = FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });
int FindMaxConsecutiveOnes(int[] nums)
{
    int CurrentCount = 0, maxCount = 0;

    foreach (int a in nums)
    {
        if (a == 1)
        {
            CurrentCount++;
            //Console.WriteLine(CurrentCount);
        }
        else
        {
            //Console.WriteLine("else" + CurrentCount);
            if (CurrentCount > maxCount)
                maxCount = CurrentCount;
            CurrentCount = 0;
        }
    }
    if (CurrentCount > maxCount)
        maxCount = CurrentCount;
    return maxCount;
}
