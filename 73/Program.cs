Solution sol = new Solution();

sol.SetZeroes(new int[][] { [0, 1, 2, 0], [3, 4, 5, 2], [1, 3, 1, 5] });

public class Solution
{
    public void SetZeroes_1(int[][] matrix)// meh
    {
        var xZeroIndex = new HashSet<int>();
        var yZeroIndex = new HashSet<int>();

        int xLen = matrix[0].Length;
        int yLen = matrix.Length;

        for (int i = 0; i < yLen; i++)
        {
            for (int j = 0; j < xLen; j++)
            {
                if (matrix[i][j] == 0)
                {
                    xZeroIndex.Add(i);
                    yZeroIndex.Add(j);
                }
            }
        }

        for (int y = 0; y < yLen; y++)
        {
            for (int x = 0; x < xLen; x++)
            {
                if (yZeroIndex.Contains(x) || xZeroIndex.Contains(y))
                {
                    matrix[y][x] = 0;
                }
            }
        }
    }
    public void SetZeroes(int[][] matrix)
    {
        var xZeroIndex = new HashSet<int>();
        var yZeroIndex = new HashSet<int>();

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if(matrix[i][j] == 0)
                {
                    xZeroIndex.Add(i);
                    yZeroIndex.Add(j);
                }
            }
        }

        foreach (int x in xZeroIndex)
        {
            for(int y = 0; y < matrix[x].Length; y++)
            {
                matrix[x][y] = 0;
            }
        }

        foreach (int y in yZeroIndex)
        {
            for (int x = 0; x < matrix.Length; x++)
            {
                matrix[x][y] = 0;
            }
        }
    }

    public void SetZeroes_TS(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        bool firstRowZero = false;
        bool firstColZero = false;

        // Step 1: Check if first row has any zero
        for (int j = 0; j < n; j++)
        {
            if (matrix[0][j] == 0)
            {
                firstRowZero = true;
                break;
            }
        }

        // Step 2: Check if first column has any zero
        for (int i = 0; i < m; i++)
        {
            if (matrix[i][0] == 0)
            {
                firstColZero = true;
                break;
            }
        }

        // Step 3: Use first row and column as markers
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }

        // Step 4: Zero out cells based on markers
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        // Step 5: Zero out first row if needed
        if (firstRowZero)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[0][j] = 0;
            }
        }

        // Step 6: Zero out first column if needed
        if (firstColZero)
        {
            for (int i = 0; i < m; i++)
            {
                matrix[i][0] = 0;
            }
        }
    }
}