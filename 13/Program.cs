// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

int result = RomanToInt("III");
Console.Write(result);
 int RomanToInt(string s)
{
    Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

    keyValuePairs['I'] = 1;
    keyValuePairs['V'] = 5;
    keyValuePairs['X'] = 10;
    keyValuePairs['L'] = 50;
    keyValuePairs['C'] = 100;
    keyValuePairs['D'] = 500;
    keyValuePairs['M'] = 1000;

    char[] chars = s.ToCharArray();

    int Finalnum = 0;
    int num = 0;
    int pre = 0;

    for (int i = chars.Length - 1; i>=0; i--)
    {
        num = keyValuePairs.GetValueOrDefault(chars[i]);

        if(Finalnum > 0 && num < pre)
            Finalnum = Finalnum - num;
        else
            Finalnum = Finalnum + num;
        pre = num;
    }

    return Finalnum;
}
