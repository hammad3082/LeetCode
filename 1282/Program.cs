Solution sol = new Solution();
sol.GroupThePeople(new int[] { 3, 3, 3, 3, 3, 1, 3 });
sol.GroupThePeople(new int[] { 2, 2, 1, 1, 1, 1, 1, 1 });

public class Solution
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        var res = new List<IList<int>>();

        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

        for (int i = 0; i < groupSizes.Length; i++)
        {
            if (dict.ContainsKey(groupSizes[i]))
                dict[groupSizes[i]].Add(i);
            else
            {
                dict[groupSizes[i]] = new List<int>();
                dict[groupSizes[i]].Add(i);
            }
        }

        foreach (var grop in dict)
        {
            var peoples = grop.Value;
            int groupSize = grop.Key;
            List<int> group = new List<int>();
            for (int i = 0; i < peoples.Count; i++)
            {
                group.Add(peoples[i]);
                if (--groupSize == 0 && i+1 < peoples.Count)
                {
                    res.Add(group);
                    group = new List<int>();
                    groupSize = grop.Key;
                }
            }

            res.Add(group);
        }
        return res;
    }
}