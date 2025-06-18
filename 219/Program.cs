using System;

Solution sol = new Solution();

sol.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2);
public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> keyValues = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int prevoiusIndex = keyValues.GetValueOrDefault(nums[i]);

            if (prevoiusIndex > 0)
            {
                if(i +1 - prevoiusIndex <= k)
                    return true;
            }
            keyValues[nums[i]] = i + 1;
        }
        return false;
    }
}