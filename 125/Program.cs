
using System.Text;
string dd = "0p";
bool res = IsPalindrome(dd);
Console.WriteLine(res);

bool IsPalindrome(string s)
{
    StringBuilder procssedStr = new ();

    foreach (char c in s)
    {
        if(char.IsLetterOrDigit(c))
        {
            procssedStr.Append(char.ToLower(c));
        }
    }
    int len = procssedStr.Length;
    
    if( len > 0)
    {
        len--;
        int hlen = len / 2;
        for (int i = 0; i <= hlen; i++)
        {
            if (procssedStr[i] != procssedStr[len - i])
                return false;
        }
    }

    return true;
}
