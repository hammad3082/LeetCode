int[] salary = { 2, 3, 4, 5 };
double result = Average(salary);
double Average(int[] salary)
{
    Array.Sort(salary);
    double sum = 0.0;
    int s = 0;
    for (int i = 1; i < salary.Length -1; i++)
    {
        sum += salary[i];
        s++;
    }

    return Math.Round(sum/s,5);
}
Console.WriteLine(result);
