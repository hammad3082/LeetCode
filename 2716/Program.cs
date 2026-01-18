public class Solution
{
    public int MinimizedStringLength(string s)
    {
        HashSet<char> result = new (s);

        return result.Count;
    }
}