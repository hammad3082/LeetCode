

using System.Linq.Expressions;

Solution obj = new Solution();

bool res = obj.IsPowerOfTwo(10);

Console.WriteLine(res);

public class Solution
{
    Dictionary<int, int> map = new Dictionary<int, int>();
    //int num = 1;

    public bool IsPowerOfTwo3(int n)
    {
        return n > 0 && (n & (n - 1)) == 0;
    }
    public bool IsPowerOfTwo(int n)
    {
        if(n == 1)
            return true;
        if(n == 0 || n%2 != 0) return false;

        return IsPowerOfTwo(n / 2);
    }
    public bool IsPowerOfTwo2(int n)
    {
        int i = 0, pow = 0;
        while (n >= i)
        {
            i = mul(i);
            if(i == n)
                return true;
            map[pow++] = i;
        }
        return false;
    }


    int mul(int n)
    {
        if(n == 0) return 1;

        return n * 2;
    }

    public bool IsPowerOfTwo111(int n)
    {
        map[0] = 1;
        int a = power(n, 1);

        if (map.ContainsValue(n))
            return true;

        return false;
    }

    int power(int n, int num)
    {
        int val = 0;
        while (true)
        {
            num++;
            val = power(n, num) * 2;
            map[num] = val;

            //return val;
        }
        return val;
    }

    int powerdd(int n)
    {
        if (n == 1)
            return 1;

        int val = powerdd(n - 1) * 2;
        map[n -1] = val;
        return val;
    }
    bool powerwww(int n)
    {

        int num = 1;
        map[0] = 1;
        while (n >= num)
        {
            map[num] = 2 * num;
            num++;
        }

        if(map.ContainsValue(n))
            return true;
        return false;
    }
}
