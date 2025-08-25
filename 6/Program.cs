public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows <= 1 || numRows >= s.Length)
            return s;

        string[] array = new string[numRows];

        int curRow = 0;

        bool goingDown = false;

        foreach (char c in s)
        {
            array[curRow] += c;

            // flip direction at top / bottom
            if (curRow == 0 || curRow == numRows - 1)
                goingDown = !goingDown;

            curRow += goingDown ? 1 : -1;

            // if(curRow == numRows -1)
            // {
            //     curRow--;
            //     goingDown = false;
            // }
            // else
            // {
            //     if(curRow == 0)
            //         goingDown = true;
            //     if (goingDown)
            //         curRow++;
            //     else
            //         curRow--;
            // }
        }
        return string.Join("", array);
    }
}