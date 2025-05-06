
Solution solution = new Solution();
 int[] res = solution.SortedSquares(new int[] { 1 });

int a = res[0];

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int i = 0, a = 0;
        int len = nums.Length;

        int[] result = new int[len];

        while (a < len)
        {
            if (nums[a] >= 0)
            {
                break;
            }
            a++;
        }
        
        int b = a + 1;
        
        while (a >= 0 && b < len)
        {
            if (Math.Abs(nums[a]) < Math.Abs(nums[b]))
            {
                result[i] = nums[a] * nums[a];
                a--;
            }
            else
            {
                result[i] = nums[b] * nums[b];
                b++;
            }
            i++;
        }

        while (b < len)
        {
            result[i] = nums[b] * nums[b];
            b++;
            i++;
        }

        while (a >= 0)
        {
            result[i] = nums[a] * nums[a];
            a--;
            i++;
        }
        return result;
    }
}