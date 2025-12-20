Solution sol = new Solution();
sol.CountPoints("B0B6G0R6R0R6G9");


public class Solution
{
    public int CountPoints(string rings)
    {
        Dictionary<char, HashSet<char>> dict = new Dictionary<char, HashSet<char>>();

        for (int i = 1; i < rings.Length; i = i + 2)
        {
            char rod = rings[i];
            if (!dict.ContainsKey(rod))
                dict[rod] = new HashSet<char>();
            
            dict[rod].Add(rings[i - 1]);
        }

        int res = 0;

        foreach (var val in dict.Values)
        {
            if (val.Count == 3)
                res++;
        }

        return res;
        //return dict.Values.Where(x => x.Count() == 3).Count();
    }
}