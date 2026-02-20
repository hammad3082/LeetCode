public class Solution
{
    public int NumberOfMatches(int n)
    {
        return n - 1;
    }
    public int NumberOfMatches_1(int n)
    {
        int answ = 0;
        while (n > 1)
        {
            answ += n / 2;
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = n / 2 + 1;
            }
        }
        return answ;
    }
}