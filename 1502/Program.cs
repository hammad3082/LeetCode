// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr = { 1, 2, 4 };

CanMakeArithmeticProgression(arr);
bool CanMakeArithmeticProgression(int[] arr)
{
    if(arr.Count() < 3) return false;
    Array.Sort(arr);
    
    List<int> list = new List<int>();

    for (int i = 0; i < arr.Length - 1; i++)
    {
        int a = Math.Abs(arr[i] - arr[i + 1]);
        list.Add(a);
    }

    for(int j = 0; j < list.Count - 1; j++)
    {
        if (list.ElementAt(j) != list.ElementAt(j))
            return false;
    }

    return true;

}