public class Solution
{
    public int Reverse(int x)
    {
        long res = 0;

        while (x != 0)
        {
            res = (res * 10) + (x % 10);

            if (res > int.MaxValue || res < int.MinValue)
                return 0;

            x /= 10;
        }

        return Convert.ToInt32(res);
    }

    public int Reverse_1(int x)
    {
        long res = 0;

        while (x != 0)
        {
            int lastDigit = x % 10;

            res = res * 10 + lastDigit;

            if (res > int.MaxValue || res < int.MinValue)
                return 0;

            //// Check overflow before actually multiplying or adding
            //if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && lastDigit > 7))
            //    return 0;
            //if (res < int.MinValue / 10 || (res == int.MinValue / 10 && lastDigit < -8))
            //    return 0;


            x /= 10;
        }

        return Convert.ToInt32(res);
    }
}