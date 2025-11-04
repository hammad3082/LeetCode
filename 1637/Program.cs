
int dd = 5.CompareTo(6);


Solution solution = new Solution();
solution.MaxWidthOfVerticalArea(new int[][] { new int[] { 1, 4 } , new int[] { 3, 4 }, new int[] { 2, 4 } });
public class Solution
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));

        int maxWidth = 0;

        for (int i = 1; i < points.Length; i++)
        {
            int width = points[i][0] - points[i - 1][0];

            if(width > maxWidth)
                maxWidth = width;
        }

        return maxWidth;
    }
}