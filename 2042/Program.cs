Solution sol = new Solution();
sol.AreNumbersAscending("1 box has 3 blue 4 red 6 green");
public class Solution
{
    public bool AreNumbersAscending(string s)
    {
        string[] parts = s.Split(' ');
        int prev = -1;

        foreach (var part in parts)
        {
            if (int.TryParse(part, out int num))
            {
                if (num <= prev)
                    return false;

                prev = num;
            }
        }

        return true;
    }
}   