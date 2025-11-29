Solution sol = new Solution();
sol.DailyTemperatures(new int[] { 30, 40, 10, 10, 15, 15, 50, 60 });

public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int n = temperatures.Length;
        int[] res = new int[n];
        Stack<int> st = new Stack<int>(); 

        for (int i = 0; i < n; i++)
        {
            // While current temp is hotter than temp at index on stack top
            while (st.Count > 0 && temperatures[i] > temperatures[st.Peek()])
            {
                int prevIndex = st.Pop();
                res[prevIndex] = i - prevIndex;
            }

            st.Push(i);
        }

        return res;
    }
    public int[] DailyTemperatures_1(int[] temperatures)//TO
    {
        int[] res = new int[temperatures.Length];
        for (int i = 0; i < temperatures.Length - 1; i++)
        {
            for (int j = i + 1; j < temperatures.Length; j++)
            {
                if (temperatures[j] > temperatures[i])
                {
                    res[i] = j - i;
                    break;
                }
            }
        }

        return res;
    }
}

public class Solution_1
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] res = new int[temperatures.Length];
        for (int i = 0; i < temperatures.Length - 1; i++)
        {
            bool notFound = true;
            for (int j = i + 1; j < temperatures.Length; j++)
            {
                if (temperatures[j] > temperatures[i])
                {
                    temperatures[i] = j - i;
                    notFound = false;
                    break;
                }
            }
            if (notFound)
                temperatures[i] = 0;
        }
        temperatures[temperatures.Length - 1] = 0;

        return temperatures;
    }
}