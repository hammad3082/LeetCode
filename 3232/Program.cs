public class Solution
{
    public bool CanAliceWin(int[] nums)
    {
        int sumOfSingle = 0, sumOfDouble = 0;

        foreach (int num in nums)
        {
            if(num > 9)
                sumOfSingle += num;
            else
                sumOfDouble += num;
        }

        return sumOfSingle != sumOfDouble;
        //if (sumOfSingle != sumOfDouble)
        //    return true;
        //else 
        //    return false;
    }
}