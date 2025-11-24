public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();
        Dictionary<string, Func<int, int, int>> operation = new();

        operation.Add("+", (x, y) => x + y);
        operation.Add("*", (x, y) => x * y);

        // first to be popped is the second number, so first param is actually the selond number
        operation.Add("-", (y, x) => x - y);
        operation.Add("/", (y, x) => x / y);

        foreach(string t in tokens)
        {
            if (operation.ContainsKey(t))
            {
                stack.Push(operation[t](stack.Pop(), stack.Pop()));
            }
            else
                stack.Push(Convert.ToInt32(t));
        }

        return stack.Peek();
    }
}