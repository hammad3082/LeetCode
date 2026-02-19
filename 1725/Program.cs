public class Solution
{
    public int CountGoodRectangles(int[][] rectangles)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        int maxLen = 0;

        foreach (int[] r in rectangles)
        {
            int side = Math.Min(r[0], r[1]);

            dict.TryAdd(side, 0);
            dict[side]++;

            maxLen = Math.Max(maxLen, side);
        }

        return dict[maxLen];
    }
}