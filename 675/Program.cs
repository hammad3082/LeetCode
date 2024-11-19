// See https://aka.ms/new-console-template for more information


using System.Net.Http.Headers;

bool resukt = Solution.JudgeCircle("LDRRLRUULR");
Console.WriteLine(resukt);
public class Solution
{
    public static bool JudgeCircle(string moves)
    {
        int num = 0;
        for (int i = 0; i < moves.Length; i++)
        {
            switch (moves[i])
            {
                case 'U':
                    num += 77;
                    break;
                case 'D':
                    num -= 77;
                    break;
                case 'L':
                    num += 99;
                    break;
                case 'R':
                    num -= 99;
                    break;

            }
        }
        if (num == 0)
            return true;
        else
            return false;
    }

}

