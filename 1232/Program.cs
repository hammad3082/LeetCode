int[][] jagged_arr = new int[5][];
//[[0,0],[0,1],[0,-1]]
//Initialize the elements
jagged_arr[0] = new int[] { -4, -3 };
jagged_arr[1] = new int[] { 1, 0 };
jagged_arr[2] = new int[] { 3, -1 };
jagged_arr[3] = new int[] { 0, -1 };
jagged_arr[4] = new int[] { -5, 2 };

//[-4,-3],[1,0],[3,-1],[0,-1],[-5,2]
//int[][] jagged_arr = new int[4][];

//// Initialize the elements
//jagged_arr[0] = new int[] { 1, 1, 1, 1 };
//jagged_arr[1] = new int[] { 1, 1, 1, 1 };
//jagged_arr[2] = new int[] { 1, 1, 1, 1 };
//jagged_arr[3] = new int[] { 1, 1, 1, 1 };

var result = CheckStraightLine(jagged_arr);
bool CheckStraightLine(int[][] coordinates)
{
    if (coordinates.Length == 2)
        return true;
    double x = 0;
    double y = 0;
    double xx = 0;
    double yy = 0;
    bool SLine = false;
    double solpe = 0;
    double tSlope = 0;
    for (int i = 0; i < coordinates.Length -1 ; i++)
    {
        x = coordinates[i][0];
        y = coordinates[i][1];

        xx = coordinates[i + 1][0];
        yy = coordinates[i + 1][1];

        if (x == xx)
        {
            if(solpe != 0)
                return false;
            SLine = true;
        }
        else if (SLine)
            return false;

        if (!SLine)
        {
            tSlope = (yy - y) / (xx - x);

            if (solpe != 0 && solpe != tSlope)
                return false;

            solpe = tSlope;
        }
    }

    return true;
}
Console.WriteLine("Hello, World!");
