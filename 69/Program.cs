public class Solution
{
    public int MySqrt(int x)
    {
        if (x < 2) 
            return x;

        int left = 1, right = x / 2;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            long square = (long)mid * mid;

            if (square == x)
            {
                return mid;
            }
            else if (square < x)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return right;
    }
    public int MySqrt_1(int x)
    {
        if (x < 2)
            return x;


        int i = 2;

        while (i * i <= x)
            i++;


        return i - 1;
    }
}