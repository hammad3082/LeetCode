public class Solution
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        string[] res = new string[names.Length];

        Dictionary<int, string> heightNames = new Dictionary<int, string>();

        for (int i = 0; i < heights.Length; i++)
        {
            heightNames.Add(heights[i], names[i]);
        }

        Array.Sort(heights);

        int ind = 0;
        for (int i = heights.Length - 1; i >= 0; i--)
        {
            res[ind] = heightNames[heights[i]];
            ind++;
        }

        return res;
    }
    public string[] SortPeople_ot(string[] names, int[] heights)
    {
        Array.Sort(heights, names);
        var name = names.ToList<string>();
        name.Reverse();
        return name.ToArray();
    }
}