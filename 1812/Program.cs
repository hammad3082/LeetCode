public class Solution
{
    public bool SquareIsWhite(string coordinates)
    {
        char column = coordinates[0];
        int row = coordinates[1] - '0';

        return ((column - 'a') + row) % 2 != 1;
    }
}