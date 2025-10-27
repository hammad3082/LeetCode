public class Solution
{
    public int CountAsterisks(string s)
    {
        bool insideBar = false;
        int count = 0;

        foreach (char c in s)
        {
            if (c == '|')
            {
                insideBar = !insideBar;
            }
            else if (c == '*' && !insideBar)
            {
                count++;
            }
        }

        return count;
    }
}