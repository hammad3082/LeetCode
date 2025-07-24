
Solution sol = new Solution();

sol.MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
public class Solution
{
    public int[] MaxSlidingWindow1(int[] nums, int k)
    {
        LinkedList<int> dequeue = new LinkedList<int>();
        List<int> result = new List<int>();

        for (int i = 0; i< nums.Length; i++)
        {
            if(dequeue.Count > 0 && dequeue.First.Value <= i - k)
                dequeue.RemoveFirst();

            while(dequeue.Count > 0 && nums[dequeue.Last.Value] < nums[i])
                dequeue.RemoveLast();

            dequeue.AddLast(i);

            if(i >= k -1)
                result.Add(nums[dequeue.First.Value]);
        }
        return result.ToArray();
    }

    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        List<int> result = new();
        for (int i = 0; i <= nums.Length - k; i++)
        {
            int max = int.MinValue;
            for (int j = i; j < i + k; j++)
            {
                max = Math.Max(max, nums[j]);
            }
            result.Add(max);
        }
        return result.ToArray();
    }
}