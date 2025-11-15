public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        List<int> result = new List<int>();

        HashSet<int> hashSet = new HashSet<int>(nums);


        for (int i = 1; i <= nums.Length; i++)
        {
            if (!hashSet.Contains(i))
                result.Add(i);
        }

        return result;
    }
}