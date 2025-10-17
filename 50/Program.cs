public class Solution
{
    public double MyPow(double x, int n)
    {
        long N = n;  // use long to handle Int32.MinValue
        if (N < 0)
        {
            x = 1 / x;
            N = -N;
        }

        double result = 1.0;
        while (N > 0)
        {
            if ((N & 1) == 1)  // if N is odd
                result *= x;
            x *= x;  // square the base
            N >>= 1; // divide N by 2
        }

        return result;
    }
    public double MyPow_1(double x, int n)
    {

        if (n == 0)
            return 1;

        long N = n; // convert to long to handle -2147483648
        double result = 1;

        if (N < 0)
        {
            x = 1 / x;
            N = -N;
        }

        for (int i = 0; i < N; i++)
        {
            result *= x;
        }

        return result;
    }
}
