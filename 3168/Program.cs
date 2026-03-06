public class Solution
{
    public int MinimumChairs(string s)
    {
        int res = 0;

        int currentPeopleInRoom = 0;

        foreach (var evet in s)
        {
            if (evet == 'E')
                currentPeopleInRoom++;
            else
                currentPeopleInRoom--;

            res = Math.Max(res, currentPeopleInRoom);
        }

        return res;
    }
}