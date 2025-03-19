
int[] numbers = { 2, 7, 11, 15 };

int[] res = TwoSum(numbers, 9);

Console.WriteLine(res[0] + " " + res[1]);

int[] TwoSum(int[] numbers, int target)
{
    int[] result = new int[2];
    int i = 0, j = numbers.Length- 1;

    while (i < j)
    {
        if (numbers[i] + numbers[j] > target)
        {
            j--;
        }
        else if (numbers[i] + numbers[j] < target)
        {
            i++;
        }
        else
        {
            result[0] = i + 1;
            result[1] = j + 1;
             
            return result;
        }
    }

    return result;
}


//int[] TwoSum(int[] numbers, int target)
//{
//    int[] result = new int[2];
//    int i = 0, j = numbers.Length - 1;

//    while (i < j)
//    {
//        if (numbers[i] + numbers[j] == target)
//        {
//            result[0] = i + 1;
//            result[1] = j + 1;

//            return result;
//        }

//        j--;
//        if (j == i)
//        {
//            i++;
//            j = numbers.Length - 1;
//        }
//    }

//    return result;
//}