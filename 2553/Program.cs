

public class Solution
{
    public int[] SeparateDigits(int[] nums)//TL
    {
        List<int> res = new List<int>();

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            while (nums[i] > 0)
            {
                res.Add(nums[i] % 10);

                nums[i] /= 10;
            }
        }

        res.Reverse();
        return res.ToArray();
    }
    public int[] SeparateDigits_1(int[] nums)
    {
        List<int> res = new List<int>();

        for(int i  = 0; i < nums.Length; i++)
        {
            if (nums[i] > 9)
            {
                Stack<int> stack = new Stack<int>();

                while (nums[i] > 0)
                {
                    int lastDigit = nums[i] % 10;

                    stack.Push(lastDigit);

                    nums[i] /= 10;
                }

                while(stack.Count > 0)
                    res.Add(stack.Pop());
            }
            else
                res.Add(nums[i]);
        }

        return res.ToArray();
    }
}