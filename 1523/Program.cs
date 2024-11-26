

int result = CountOdds(8, 10);
int CountOdds(int low, int high)
{
    bool x = true;
    int num = low;
    int result = 0;
    while (x)
    {
        if (num % 2 != 0)
        {
            result++;
        }
        if(num == high)
            x = false;
        num++;
    }
    return result;
}
Console.WriteLine(result);
