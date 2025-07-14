public class Solution
{
    public string SimplifyPath(string path)
    {
        string[] strings = path.Split("/");
        Stack<string> stack = new Stack<string>();
        foreach (string s in strings)
        {
            if (s.Length > 0)
            {
                if(s == "..")
                {
                    if(stack.Count > 0)
                        stack.Pop();
                }
                else if (s != ".")
                {
                    stack.Push(s);
                }
            }
        }

        return "/" + string.Join("/", stack.Reverse());
    }
}