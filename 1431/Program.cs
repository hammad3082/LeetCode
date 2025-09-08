public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var res = new List<bool>();

        int max = 0;

        foreach (var c in candies) {
            if (c > max) 
                max = c;
        }

        Array.Sort(candies);
        int NoCandiesToHave = max - extraCandies;

        foreach (var cand in candies)
        {
            res.Add(cand >= NoCandiesToHave);
        }
        return res;
    }

    public IList<bool> KidsWithCandies1(int[] candies, int extraCandies)
    {
        var res = new List<bool>();

        int max = candies.Max();

        int NoCandiesToHave = max - extraCandies;

        foreach (var cand in candies)
        {
            if (cand + extraCandies >= max)
                res.Add(true);
            else
                res.Add(false);
        }
        return res;
    }
}