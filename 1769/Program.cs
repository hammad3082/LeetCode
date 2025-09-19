using System.Drawing;
using System;

Solution sol = new Solution();

sol.MinOperations("110");

public class Solution
{
    public int[] MinOperations(string boxes)
    {
        int len = boxes.Length;
        int[] res = new int[len];

        int BallCount = 0;
        int OperationsToMoveAllTheBalls = 0;

        for (int i = 0; i < len; i++)//move all balls left
        {
            res[i] = OperationsToMoveAllTheBalls;

            if (boxes[i] == '1')
                BallCount++;

            OperationsToMoveAllTheBalls += BallCount;
        }

        BallCount = 0;
        OperationsToMoveAllTheBalls = 0;
        //Move all balls from the right to the current index
        //i.e., add the count of operations needed to move the balls present on the right side to the current index.
        for (int j = len - 1; j >= 0; j--){
            res[j] += OperationsToMoveAllTheBalls;
            if (boxes[j] == '1')
                BallCount++;
            OperationsToMoveAllTheBalls += BallCount;
        }
        return res;
    }
    public int[] MinOperations11(string boxes)
    {
        int[] res = new int[boxes.Length];

        for (int i = 0; i < boxes.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < boxes.Length; j++)
            {
                if(i == j || boxes[j] == '0')
                    continue;
                sum += Math.Abs(i - j);
            }

            res[i] = sum;
        }
        
        return res;
    }
}