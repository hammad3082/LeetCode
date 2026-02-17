public class Solution
{
    public int FindLucky(int[] arr)
    {
        int[] numbers = new int[501];

        foreach (int a in arr)
        {
            numbers[a]++;
        }

        for (int i = 500; i > 0; i--)
        {
            if (i == numbers[i]) 
                return i;
        }

        return -1;
    }
}