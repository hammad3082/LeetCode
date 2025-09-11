public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int x = 0;

        foreach (string operation in operations)
        {
            if (operation.Contains("-"))
                x--;
            else
                x++;
        }
        return x;
    }
}