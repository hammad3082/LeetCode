public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int res = 0;

        HashSet<char> values = new (jewels);

        foreach (char c in stones) {
            if (values.Contains(c))
                res++;
        }

        return res;
    }
}