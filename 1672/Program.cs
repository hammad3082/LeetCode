int[][] jagged_arr = new int[3][];

// Initialize the elements
jagged_arr[0] = new int[] { 1, 5};
jagged_arr[1] = new int[] { 7,3 };
jagged_arr[2] = new int[] { 3,5 };

int result = MaximumWealth(jagged_arr);
int MaximumWealth(int[][] accounts)
{
    int max = 0;
    int sum = 0;
    for (int i = 0; i < accounts.Length; i++)
    {
        sum = 0;
        for (int j = 0; j < accounts[i].Length; j++)
        {
            sum += Convert.ToInt32(accounts[i][j]);
            
        }
        if (max < sum)
        {
            max = sum; break;
        }
    }
    return max;
}
Console.WriteLine(result);
