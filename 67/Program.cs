
string result = AddBinary("1111", "1111");
string AddBinary(string a, string b)
{
    int carry = 0;
    int i = a.Length-1, j = b.Length-1;
    var List = new List<int>();
    int res = 0;
    while (i>=0 || j>=0)
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
        else if ( res > 1)
        {
            List.Add(res - 2);
            carry = 1;
        }
        res = 0;
    }
    if(carry != 0)
    {
        List.Add(carry);
    }
    List.Reverse();
    return String.Join("", List);

}
string AddBinary22(string a, string b)
{
    int carry = 0;
    int i = a.Length - 1, j = b.Length - 1;
    Stack<int> stack = new Stack<int>();
    int res = 0;
    string result = "";
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
            stack.Push(res);
        }
        else if (res > 1)
        {
            stack.Push(res - 2);
            carry = 1;
        }
        res = 0;
    }
    if (carry != 0)
    {
        stack.Push(carry);
    }
    while (stack.Count > 0)
    {
        result += stack.Pop();
    }
    return result;

}
string AddBinary11(string a, string b)
{
    string inter = "";

    int first = 0, second = 0, carry = 0;
    int i = a.Length - 1, j = b.Length - 1;
    Stack<int> stack = new Stack<int>();
    int res = 0;
    string result = "";
    while (i >= 0 || j >= 0)
    {
        if (i >= 0)
        {
            first = a[i] - '0';
            i--;
        }
        if (j >= 0)
        {
            second = b[j] - '0';
            j--;
        }
        res = first + second + carry;
        if (res <= 1)
        {
            carry = 0;
            stack.Push(res);
        }
        else if (res == 2)
        {
            stack.Push(0);
            carry = 1;
        }
        else if (res == 3)
        {
            stack.Push(1);
            carry = 1;
        }
        first = second = 0;
    }
    if (carry != 0)
    {
        stack.Push(carry);
    }
    while (stack.Count > 0)
    {
        result += stack.Pop();
    }
    return result;

}
Console.WriteLine("Hello, World!");
