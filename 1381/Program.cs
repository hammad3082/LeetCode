public class CustomStack
{
    int[] arr;
    int i = -1;
    int length = 0;

    public CustomStack(int maxSize)
    {
        length = maxSize;
        arr = new int[maxSize];
    }

    public void Push(int x)
    {
        Console.WriteLine($"S push: {x}, index: {i}");
        if (i < length - 1)
            arr[++i] = x;
        Console.WriteLine($"E push: {x}, index: {i}");
    }

    public int Pop()
    {
        Console.WriteLine($"S pop, index: {i}");
        if (i < 0)
            return -1;
        else
        {
            Console.WriteLine($"E pop, index: {i}");
            return arr[i--];
        }
    }

    public void Increment(int k, int val)
    {
        int index = Math.Min(k, length);
        Console.WriteLine($"S Increment, index: {i}, k: {k}, index2: {index}");

        for (int i = 0; i < index; i++)
        {
            Console.WriteLine($"Increment loop , index: {i}");
            arr[i] += val;
        }

        Console.WriteLine($"E Increment, index: {i}, k: {k}, index2: {index}");
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */