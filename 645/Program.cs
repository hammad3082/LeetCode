public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int[] res = new int[2];

        int[] arr = new int[nums.Length + 1];

        for (int i = 0; i < nums.Length; i++)
        {
            arr[nums[i]] += 1;
        }


        for (int i = 1; i < nums.Length; i++)
        {
            if (arr[i] > 1)
                res[0] = i;
            else if (arr[i] == 0)
                res[1] = i;
        }

        return res;
    }
}