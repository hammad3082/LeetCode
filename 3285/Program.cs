public class Solution
{
    // A Mountain is StableMountain if its preceding mountan's height is greater than threshold.
    public IList<int> StableMountains(int[] height, int threshold)
    {
        List<int> list = new List<int>();

        for (int i = 1; i < height.Length; i++)
        {
            if (height[i - 1] > threshold)
                list.Add(i);
        }

        return list;
    }
}