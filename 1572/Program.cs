//int[][] jagged_arr = new int[3][];

//// Initialize the elements
//jagged_arr[0] = new int[] { 1, 2,3 };
//jagged_arr[1] = new int[] { 4,5,6};
//jagged_arr[2] = new int[] { 7,8,9};

int[][] jagged_arr = new int[4][];

// Initialize the elements
jagged_arr[0] = new int[] { 1, 1,1,1};
jagged_arr[1] = new int[] { 1, 1, 1, 1 };
jagged_arr[2] = new int[] {1, 1, 1, 1 };
jagged_arr[3] = new int[] { 1, 1, 1, 1 };

int result = DiagonalSum(jagged_arr);
int DiagonalSum(int[][] mat)
{
    int sum = 0;
    int inedex = 0;
    for (int i = 0; i < mat.Length; i++)
    {
        sum += Convert.ToInt32(mat[i][i]);
        inedex = mat.Length - 1 - i;
        if (inedex != i)
            sum += Convert.ToInt32(mat[inedex][i]);
    }
    return sum;
}
Console.WriteLine(result);
