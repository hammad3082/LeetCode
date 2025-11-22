Solution sol = new Solution();

sol.CellsInRange("K1:L2");
public class Solution
{
    public IList<string> CellsInRange(string s)//cp
    {
        var res = new List<string>();

        char startCol = s[0];
        char endCol = s[3];

        int startRow = s[1] - '0';
        int endRow = s[4] - '0';

        for (char col = startCol; col <= endCol; col++)
        {
            for (int row = startRow; row <= endRow; row++)
            {
                res.Add(col.ToString() + row.ToString());
            }
        }

        return res;
    }
}