public class Solution
{
    public int[] RecoverOrder(int[] order, int[] friends)
    {
        int[] result = new int[friends.Length];

        HashSet<int> friendSet = new HashSet<int>(friends);

        int index = 0;

        foreach (int num in order)
        {
            if (friendSet.Contains(num))
            {
                result[index++] = num;
            }
        }

        return result;
    }
    public int[] RecoverOrder_Tp(int[] order, int[] friends)
    {
        var chars = new bool[order.Length];
        int iter = 0;

        for (int i = 0; i < friends.Length; i++)
            chars[friends[i] - 1] = true;

        foreach (var item in order)
            if (chars[item - 1])
                friends[iter++] = item;

        return friends;
    }
}