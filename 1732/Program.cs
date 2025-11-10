
Solution sol = new Solution();

sol.LargestAltitude(new int[] { -4, -3, -2, -1, 4, 3, 2 });
public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        // Cause The biker starts his trip on point 0 with altitude equal 0
        int CurrentAltitude = 0;

        int MaxAltitude = CurrentAltitude;

        for (int i = 0; i < gain.Length; i++)
        {
            CurrentAltitude += gain[i];

            if (CurrentAltitude > MaxAltitude)
                MaxAltitude = CurrentAltitude;
        }

        return MaxAltitude;
    }
}