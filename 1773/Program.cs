public class Solution
{
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        int index = 0, count = 0;

        if (ruleKey == "color")
            index = 1;
        if (ruleKey == "name")
            index = 2;

        foreach (var item in items)
        {
            if (item[index] == ruleValue)
            {
                count++;
            }
        }
        return count;
    }
}