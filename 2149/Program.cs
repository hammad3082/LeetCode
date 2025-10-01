public class Solution
{
    public int[] RearrangeArray(int[] nums)
    {
        int posIndex = 0;
        int negIndex = 1;
        int[] res = new int[nums.Length];

        foreach (int num in nums)
        {
            if (num > 0)
            {
                res[posIndex] = num;
                posIndex += 2;
            }
            else
            {
                res[negIndex] = num;
                negIndex += 2;
            }
        }
        return res;
    }
    public int[] RearrangeArray_1(int[] nums)
    {
        var pos = new Queue<int>();
        var neg = new Queue<int>();

        foreach (int i in nums)
        {
            if(i >= 0) 
                pos.Enqueue(i);
            else 
                neg.Enqueue(i);
        }

        int j = -1;
        while (pos.Count > 0 || pos.Count > 0)
        {
            if(pos.Count > 0)
                nums[++j] = pos.Dequeue();
            if (neg.Count > 0)
                nums[++j] = neg.Dequeue();
        }

        return nums;
    }
}