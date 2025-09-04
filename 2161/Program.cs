public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {

        List<int> Left = new List<int>();
        List<int> Right = new List<int>();

        int same = 0;

        foreach (int x in nums)
        {
            if( x < pivot)
            {
                Left.Add(x);
            }
            else if( x > pivot) 
            {
                Right.Add(x);
            }
            else
                same++;
        }
        while (same > 0)
        {
            Left.Add(pivot);
            same--;
        }
        Left.AddRange(Right);
;
        return Left.ToArray();
            ;
    }
}