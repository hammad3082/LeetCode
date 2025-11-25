public class Solution
{
    public int[] ExclusiveTime(int n, IList<string> logs)
    {
        int[] result = new int[n];
        Stack<int> stack = new Stack<int>();
        int prevTime = 0;

        foreach (var log in logs)
        {
            var parts = log.Split(':');
            int id = int.Parse(parts[0]);
            string type = parts[1];
            int time = int.Parse(parts[2]);

            if (type == "start")
            {
                if (stack.Count > 0)
                {
                    result[stack.Peek()] += time - prevTime;
                }
                stack.Push(id);
                prevTime = time;
            }
            else // end
            {
                // Because end is like incluse of that unit of time so +1
                result[stack.Pop()] += time - prevTime + 1;
                prevTime = time + 1;
            }
        }

        return result;
    }
}

