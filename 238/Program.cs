
Solution Solution = new Solution();

Solution.ProductExceptSelf(new int[] { 1, 2, 3, 4 });
public class Solution
{
    public int[] ProductExceptSelf(int[] nums) // not mine but !!!!!
    {
        int length = nums.Length;
        int[] answer = new int[length];

        answer[0] = 1;
        for (int i = 1; i < length; i++)
        {
            answer[i] = answer[i - 1] * nums[i - 1];
        }

        int right = 1;

        for (int j = length - 1; j >= 0; j--)
        {
            answer[j] *= right;
            right *= nums[j];
        }

        return answer;
    }
    public int[] ProductExceptSelf1(int[] nums)//works
    {
        int[] prefix = new int[nums.Length];
        int[] sufix = new int[nums.Length];

        prefix[0] = nums[0];
        sufix[nums.Length - 1] = nums[nums.Length - 1];

        int i = 1, j = nums.Length - 2;
        while (i < nums.Length && j >= 0)
        {
            prefix[i] = prefix[i - 1] * nums[i];
            sufix[j] = sufix[j + 1] * nums[j];

            i++;
            j--;
        }
        nums[0] = sufix[1];

        nums[nums.Length - 1] = prefix[nums.Length - 2];
        for (int k  = 1; k < nums.Length - 1; k++)
        {
            nums[k] = prefix[k - 1] * sufix[k + 1];
        }

        return nums;
    }
}