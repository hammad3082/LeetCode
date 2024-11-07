// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] result = { 9, 9, 9, 9};
int[] resultt = PlusOne(result);
Console.WriteLine(resultt);
int[] PlusOne(int[] digits)
{
    int lastindex = digits.Length - 1;
    int lastNum = digits[lastindex];

    if(lastNum != 9)
    {
        digits[lastindex] += 1;
        return digits;
    }
    else
    {
        digits[lastindex] = 0;
        for (int i = digits.Length - 2; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i] += 1;
                return digits;
            }
            else
            {
                digits[i] = 0;
            }
        }

        List<int> list = new List<int> { 1 };

        list.AddRange(digits);

        return list.ToArray();
    }
}

//int[] newResult = new int[digits.Length + 1];

//bool addOne = true;

int[] PlusOne1(int[] digits)
{
    string sNum = "";

    foreach (int d in digits)
    {
        sNum += d;
    }

    long num = Convert.ToInt32(sNum) + 1;

    string fSnum = num.ToString();
    int[] result = new int[fSnum.Length];
    int i = 0;
    foreach (char ii in fSnum)
    {
        result[i] = ii - '0';
        i++;
    }

    return result;
}