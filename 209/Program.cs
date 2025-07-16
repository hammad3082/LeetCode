Solution s = new Solution();
s.MinSubArrayLen(7, new int[] { 2, 3, 1, 2, 4, 3 });

public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int minlength = 0;

        int left = 0, right = 0;
        int sum = 0; int len = 0;
        while(left <= right)
        {
            if(sum < target)
            {
                if (right >= nums.Length)
                    break;
                sum += nums[right];
                right++;
            }
            else
            {
                len = right - left;
                if (minlength == 0)
                    minlength = len;
                else
                    minlength = Math.Min(minlength, len);
                sum -= nums[left];
                left++;
            }
        }
        return minlength;
    }
    public int MinSubArrayLen2232(int target, int[] nums)
    {
        int minlength = 0;

        int left =0, right = 0;
        int sum = 0; int len = 0;
        while (left != nums.Length)
        { 
            for(int i = left; sum < target; i++)
            {
                sum += nums[right];
                //right++;
            }

            if(sum >= target)
            {
                len = right - left + 1;
                minlength= Math.Min(minlength, left);
            }
        }
        return minlength;
    }
}