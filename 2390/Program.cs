public class Solution
{
    public string RemoveStars(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '*')
            {
                stack.Pop();
            }
            else
                stack.Push(c);
        }

        char[] res = new char[stack.Count];
        for (int i = res.Length - 1; i >= 0; i--)
            res[i] = stack.Pop();

        return new string(res);
    }
}