public class Solution
{
    public int[] GetSneakyNumbers(int[] nums)
    {
        int[] res = new int[2];
        int resIndex = 0;

        HashSet<int> visited = new HashSet<int>();
        

        foreach (int num in nums)
        {
            if (visited.Contains(num))
            {
                res[resIndex++] = num;
            }
            else
            {
                visited.Add(num);
            }
            if (resIndex == 2)
                break;
        }

        return res;
    }
}
