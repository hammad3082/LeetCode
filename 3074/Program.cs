public class Solution
{
    public int MinimumBoxes(int[] apple, int[] capacity)
    {
        int count = 0;
        int totalApples = 0;

        foreach (int a in apple)
            totalApples += a;

        var ordCapacity = capacity.OrderByDescending(x => x);

        foreach (int cap in ordCapacity)
        {
            totalApples -= cap;
            count++;

            if (totalApples <= 0)
                break;
        }

        return count;
    }
}