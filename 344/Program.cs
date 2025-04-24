// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ReverseString(new char[] { 'h','e','l' ,'t', 'o', '1'});
void ReverseString(char[] s)
{
    int l = s.Length - 1;
    int hl = l / 2;
    char t;
    for (int i = 0; i < hl; i++)
    {
        t = s[i];
        //Console.WriteLine("t " + t);
        s[i] = s[l - i];
        //Console.WriteLine(s[i]);
        s[l - i] = t;
    }
}