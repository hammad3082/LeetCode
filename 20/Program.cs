
Solution solution = new Solution();
solution.IsValid("() {} [] {([])}");
public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        char p;
        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == 32)
            {
                continue;
            }
            else
            {
                if (stack.Count == 0)
                    return false;
                p = stack.Pop();
                switch (c)
                {
                    case ')':
                        if (p != '(')
                            return false;
                        break;
                    case ']':
                        if (p != '[')
                            return false;
                        break;
                    case '}':
                        if (p != '{')
                            return false;
                        break;
                    default:
                        return false;
                        
                }
            }
        }
        if (stack.Count > 0)
            return false;
        return true;
    }
}