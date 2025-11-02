
string result = Multiply("2", "5");
string Multiply(string num1, string num2)
{
    int carry = 0;
    int i = num1.Length - 1, j = num2.Length - 1;
    var List = new List<int>();
    int res = 0;
    while (i >= 0 || j >= 0)
    {
        res += carry;
        if (i >= 0)
        {
            res += a[i] - '0';
            i--;
        }
        if (j >= 0)
        {
            res += b[j] - '0';
            j--;
        }

        if (res <= 1)
        {
            carry = 0;
            List.Add(res);
        }
        else if (res > 1)
        {
            List.Add(res - 2);
            carry = 1;
        }
        res = 0;
    }
    if (carry != 0)
    {
        List.Add(carry);
    }
    List.Reverse();
    return String.Join("", List);
}
Console.WriteLine(result);
