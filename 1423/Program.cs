public class Solution
{
    public int MaxScore(int[] cardPoints, int k)
    {
        int len = cardPoints.Length;

        int currentKSum = 0;

        for (int i = 0; i < k; i++) 
            currentKSum += cardPoints[i];

        int maxKSum = currentKSum;

        for (int i = 1; i <= k; i++)
        {
            currentKSum -= cardPoints[k - i];
            currentKSum += cardPoints[len - i];

            maxKSum = Math.Max(maxKSum, currentKSum);
        }

        return maxKSum;
    }
}