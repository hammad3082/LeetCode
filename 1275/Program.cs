// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[][] jagged_arr = new int[6][];

// Initialize the elements
jagged_arr[0] = new int[] { 0, 0 };
jagged_arr[1] = new int[] { 1,1 };
jagged_arr[2] = new int[] { 0,1};
jagged_arr[3] = new int[] { 0,2};
jagged_arr[4] = new int[] { 1,0 };
jagged_arr[5] = new int[] { 2, 0 };

string result = Tictactoe(jagged_arr);

Console.WriteLine(result);

string Tictactoe(int[][] moves)
{
    int[] Arow = new int[3];
    int[] Acol = new int[3];

    int[] Brow = new int[3];
    int[] Bcol = new int[3];
    bool A = true;

    int aI = 0;
    int bI = 0;

    for (int i = 0; i < moves.Length; i++)
    {
        if (A)
        {
            A = false;
            Arow[aI] = moves[i][0];

            Acol[aI] = moves[i][1];
            aI++;
        }
        else
        {
            A = true;
            Brow[bI] = moves[i][0];

            Bcol[aI] = moves[i][1];
            bI++;
        }
    }

    if ((Arow[0] == Arow[1] && Arow[1] == Arow[2]) || (Acol[0] == Acol[1] && Acol[1] == Acol[2]) || (Arow[0] == Acol[0] && Arow[1] == Acol[1] && Arow[2] == Acol[2]))
    {
        return "A";
    }
    if ((Brow[0] == Brow[1] && Brow[1] == Brow[2]) || (Bcol[0] == Bcol[1] && Bcol[1] == Bcol[2]) || (Brow[0] == Bcol[0] && Brow[1] == Bcol[1] && Brow[2] == Bcol[2]))
    {
        return "B";
    }
    return "draw";
}


//if(Ar != -2)
//{
//    if (i == 0)
//        Ar = moves[i][0];
//    else if (i == 1)
//    {
//        if (Ar != moves[i][0])
//        {
//            Ar = -2;
//        }
//    }
//    else
//    {
//        if (Ar == moves[i][0])
//        {
//            return "A";
//        }
//    }
//}
