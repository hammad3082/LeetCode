public class Solution
{
    public bool CheckString(string s)
    {
        bool checkForBsNow = false;
        foreach (char c in s)
        {
            if(c == 'b')
                checkForBsNow = true;

            if(checkForBsNow)
                if(c == 'a')
                    return false;
        }

        return true;
    }
}