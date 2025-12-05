public class Solution
{
    public int[] NextGreaterElements(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
            result[i] = -1;

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < 2 * n; i++)
        {
            int idx = i % n; // circular index

            while (stack.Count > 0 && nums[idx] > nums[stack.Peek()])
            {
                int top = stack.Pop();
                result[top] = nums[idx];
            }

            // Only push indices from first pass
            if (i < n)
            {
                stack.Push(idx);
            }
        }

        return result;
    }
}