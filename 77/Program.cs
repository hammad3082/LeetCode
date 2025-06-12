
Solution sol = new Solution();

sol.Combine(2, 1);
public class Solution
{
    IList<IList<int>> List;
    int SubListSize = 0, ArraySize = 0, i = 1;
    int FirstEliment = 0;
    public IList<IList<int>> Combine(int n, int k)
    {
        List = new List<IList<int>>();
        ArraySize = n;
        SubListSize = k;

        List<int> l = new List<int>();
        BackTrack(1, l, k);
        return List;
    }

    public void BackTrack(int start, List<int> l, int k)
    {
        if(k == 0)
        { 
            List.Add(new List<int>(l));
            return;
        }

        for (int i = start; i <= ArraySize; i++) 
        { 
            l.Add(i);
            BackTrack(i + 1, l, k - 1);
            l.RemoveAt(l.Count - 1);
        }
    }
}
public class Solution2
{
    IList<IList<int>> List;
    int SubListSize = 0, ArraySize = 0, i = 1;
    int FirstEliment = 0;
    public IList<IList<int>> Combine(int n, int k)
    {
        List = new List<IList<int>>();
        ArraySize = n;
        SubListSize = k;

        List<int> l = new List<int>();
        l.Add(1);
        FirstEliment = 1;
        BackTrack(l, 1);
        return List;
    }

    public void BackTrack(List<int> l, int k)
    {

        if (k < SubListSize && i < ArraySize)
        {
            l.Add(++i);
            BackTrack(l, ++k);
        }
        else
        {
            List.Add(l);

            if ((FirstEliment + 1 < ArraySize || SubListSize == 1) && FirstEliment + 1 <= ArraySize)
            {
                List<int> l2 = new List<int>();

                if (i == ArraySize)
                {
                    FirstEliment++;
                    i = FirstEliment;
                }
                if (FirstEliment <= ArraySize)
                {
                    l2.Add(FirstEliment);
                    BackTrack(l2, 1);
                }
            }
        }
    }
}
public class Solution1
{
    IList<IList<int>> List;
    int[] arr;
    int SubListSize = 0, ArraySize = 0, i = 1;
    int FirstEliment = 0;
    public IList<IList<int>> Combine(int n, int k)
    {
        List = new List<IList<int>>();
        ArraySize = n;
        SubListSize = k;

        //arr = new int[n];
        //for (int i = 0;i<n; i++)
        //    arr[i] = i + 1;
        List<int> l = new List<int>();
        l.Add(1);
        FirstEliment = 1;
        BackTrack(l, 1);
        return List;
    }

    public void BackTrack(List<int> l, int k)
    {
        
        if (k < SubListSize && i < ArraySize)
        {
            l.Add(++i);
            BackTrack(l, ++k);
        }
        else
        {
            List.Add(l);

            if(FirstEliment + 1 < ArraySize)
            {
                List<int> l2 = new List<int>();

                if (i == ArraySize)
                {
                    FirstEliment++;
                    i = FirstEliment;
                }
                l2.Add(FirstEliment);
                BackTrack(l2, 1);
            }
        }
    }
}