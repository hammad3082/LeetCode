Solution Solution = new Solution();

int[][] arr = new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15,18 } };

int[][] arr1 = new int[][] { new int[] { 1, 3 }, new int[] { 3, 6 } };


int a = 8, b = 5;

int c = a.CompareTo(b);

int g = b.CompareTo(a);
Solution.Merge(arr1);
public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        List<int[]> result = new List<int[]>();

        Array.Sort(intervals,(x,y) => x[0].CompareTo(y[0]));

        int[] pre = intervals[0];
        int[] curr = new int[2];
        for (int i = 1; i < intervals.Length; i++)
        {
            curr = intervals[i];

            if (curr[0] <= pre[1])
            {
                if(curr[1] > pre[1])
                    pre[1] = curr[1];
            }
            else
            {
                result.Add(pre);

                pre = curr;
                //if (i +1 < intervals.Length)
                //    pre = curr;
                //else
                //    result.Add(curr);
            }
        }

        result.Add(pre);
        return result.ToArray();
    }
}