
Dictionary<int, int> map = new Dictionary<int, int>();
int ClimbStairs(int n)
{

    //Dictionary<int, int> map = new Dictionary<int, int>();
    return fib(n);
}

int fib(int a)
{
    int res = 0;

    if (map.ContainsKey(a))
    {
        res = map[a];
    }
    else
    {
        if (a == 1)
            res = 1;
        else if (a == 2)
            res = 2;
        else
            res = fib(a - 2) + fib(a - 1);

        map[a] = res;
    }
    return res;
}


//Dictionary<int, int> map = new Dictionary<int, int>();
int res = fun(100);

Console.WriteLine(res);
int fun(int a)
{
    if (map.ContainsKey(a))
    {
        return map[a];
    }

    if (a == 1)
        return 1;
    else if (a == 2)
        return 2;
   
    int res = fun(a - 2) + fun(a - 1);

    map[a] = res;
    return res;
}


int fun1(int a)
{
    int res = 0;

    if (map.ContainsKey(a))
    {
        res = map[a];
    }
    else
    {
        if (a == 1)
            res = 1;
        else if (a == 2)
            res = 2;
        else
            res = fun(a - 2) + fun(a - 1);

        map[a] = res;
    }
    return res;
}