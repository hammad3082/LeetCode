
using System;

int[][] jagged_arr = new int[4][];

//Initialize the elements
jagged_arr[0] = new int[] { 1, 2, 3 };
jagged_arr[1] = new int[] { 4, 5, 6 };
jagged_arr[2] = new int[] { 7, 8, 9 };
jagged_arr[3] = new int[] { 71, 82, 93 };

//int[][] jagged_arr = new int[4][];

//// Initialize the elements
//jagged_arr[0] = new int[] { 1, 1, 1, 1 };
//jagged_arr[1] = new int[] { 1, 1, 1, 1 };
//jagged_arr[2] = new int[] { 1, 1, 1, 1 };
//jagged_arr[3] = new int[] { 1, 1, 1, 1 };

var result = SpiralOrder(jagged_arr);
IList<int> SpiralOrder(int[][] matrix)
{
    List<int> result = new List<int>();

    int i = 0, j = 0;
    int layer = 1; 
    bool igI = false;
    bool igJ = false;
    bool x = false;
    bool pos = true;
    int ilen = matrix[i].Length - layer;
    int jlen = matrix[j].Length - layer;
    while (matrix != null)
    {

        result.Add(matrix[i][j]);

        if (i == matrix[i].Length - layer/2 && j== matrix[j].Length - layer/2) {
            break;
        }

        if (pos)
        {
            if (!x && j != jlen)
            {
                j++;
                if (j == jlen)
                {
                    x = !x;
                }
            }
            else if (x && i != ilen)
            {
                i++;
                if (i == ilen)
                {
                    x = !x;
                }
            }
            else if (i == ilen && j == jlen)
            {
                j--;
                pos = false;
            }
        }
        else
        {
            if (!x && j != jlen)
            {
                j--;
                if (j == 0)
                {
                    x = !x;
                    layer++;
                    jlen--;
                    ilen--;
                }
            }
            else if (x && i != ilen)
            {
                i--;
                if (i == ilen)
                {
                    x = !x;
                    pos = true;
                }
            }
        }
        
        //if (!igJ && i !=  j != matrix[j].Length - layer)
        //{
        //    j++;
        //}
        //else if (!igI && i != matrix[i].Length - layer)
        //{
        //    i++;
        //}
        //else if(igJ || j == matrix[j].Length - layer)
        //{
        //    j--;
        //    igJ = true;
        //}
        //else if (igI || i == matrix[i].Length - layer)
        //{
        //    i--;
        //    igI = true;
        //}
    }    

    return result;
}
Console.WriteLine(result);