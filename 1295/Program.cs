// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] nums = { 12, 345, 2, 6, 7896 };
int res = FindNumbers(nums);

int FindNumbers(int[] nums)
{
    int c = 0;
    foreach (int n in nums)
    {
        //Console.WriteLine(n.ToString().Length);
        if ((n.ToString().Length) % 2 == 0)
            c++;
    }
    return c;
}
