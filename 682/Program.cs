

string[] operations = { "5", "2", "C", "D", "+" };

int result = CalPoints(operations);
int CalPoints(string[] operations)
{
    List<int> ints = new List<int>();
    int index = -1;
    int Sum = 0;
    int rNum = 0;
    for (int i=0;i< operations.Length;i++)
    {
        if (operations[i] == "+")
        {
            rNum = ints[index - 1] + ints[index];
            ints.Add(rNum);
            Sum += rNum;
            index++;
        }
        else if (operations[i] == "D")
        {
            rNum = ints[index] * 2;
            ints.Add(rNum);
            Sum += rNum;
            index++;
        }
        else if(operations[i] == "C") 
        {
            rNum = ints[index];
            ints.Remove(rNum);
            Sum -= rNum;
            index--;
        }
        else
        {
            rNum = Convert.ToInt32(operations[i]);
            ints.Add(rNum);
            Sum += rNum;
            index++;
        }
    }
    //int sum = 0;
    //foreach (int i in ints)
    //{
    //    sum += i;
    //}
    return Sum;
}
Console.WriteLine(result);
