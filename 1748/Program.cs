public class Solution
{
    public int SumOfUnique(int[] nums)
    {
        int[] arr = new int[101];

        foreach (int i in nums)
            arr[i]++;

        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == 1)
                sum += i;
        }

        return sum;
    }
    public int SumOfUnique_1(int[] nums)
    {
        Dictionary<int,int> keyValues = new Dictionary<int,int>();

        foreach (int i in nums)
        {
            if (keyValues.ContainsKey(i))
                keyValues[i] = keyValues[i] + 1;
            else
                keyValues[i] = 1;
        }
        int sum = 0;

        foreach (var keyValue in keyValues.Where(x => x.Value == 1))
        {
            sum += keyValue.Key;
        }

        return sum;// keyValues.Where(x => x.Value == 1).Select(x => x.Key).Sum();
    }
}