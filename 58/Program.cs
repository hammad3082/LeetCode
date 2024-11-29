// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

int result = LengthOfLastWord("   fly me   to   the moon  ");
Console.WriteLine(result);
int LengthOfLastWord(string s)
{
    char[] chars = s.ToCharArray();
    bool start = false;
    int len = 0;
   
    for (int i = chars.Length - 1; i >= 0; i--)
    {
        if (chars[i] != ' ')
            start = true;
        if (start)
        {
            if (chars[i] == ' ')
            {
                return len;
            }
            len++;
        }
    }
    return 0;
}