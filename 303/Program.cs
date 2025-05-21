NumArray n = new NumArray(new int[] { -2, 0, 3, -5, 2, -1 });

int r1 = n.SumRange(0, 2);
int r2 = n.SumRange(2, 5);
int r3 = n.SumRange(0, 5);

Console.WriteLine();
public class NumArray
{
    int[] array;
    int[] sumArray;
    public NumArray(int[] nums)
    {
        int sum = 0;
        array = nums;
        sumArray = new int[array.Length];
        for (int i = 0; i <array.Length; i++)
        {
            sum += array[i];
            sumArray[i] = sum;
        }
    }

    public int SumRange(int left, int right)
    {
        if (left == 0)
            return sumArray[right];
        else
         return sumArray[right] - sumArray[left - 1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */