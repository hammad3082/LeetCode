int[] citations = { 5, 0, 6, 1, 5 ,5};

int res = HIndex(citations);
Console.WriteLine(res);
int HIndex(int[] citations)
{
    Array.Sort(citations, (x, y) => y.CompareTo(x));
    int res = 0;
    for (int i = 0; i < citations.Length; i++)
    {
        if (citations[i] >= i+1)
            res++;
        else
            return res;
    }
    return res;
}