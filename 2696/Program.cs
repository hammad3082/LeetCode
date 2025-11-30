Solution sol = new Solution();
sol.MinLength("ABFCACDB");

public class Solution
{
    public int MinLength(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (stack.Count > 0 && (c == 'B' || c == 'D'))
            {
                char pre = stack.Peek();

                if((pre == 'A' && c == 'B') || (pre == 'C' && c == 'D'))
                    stack.Pop();
                else
                    stack.Push(c);
            }
            else
                stack.Push(c);
        }

        return stack.Count;
    }
}