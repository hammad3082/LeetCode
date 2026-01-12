public class Solution
{
    public int CountTestedDevices(int[] batteryPercentages)
    {
        int res = 0;

        foreach (int batteryPercentage in batteryPercentages)
        {
            res += batteryPercentage > res ? 1 : 0;
        }

        return res;
    }
}