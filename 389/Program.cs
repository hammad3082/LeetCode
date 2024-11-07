// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

string s = "abcd", t ="abcde";


int result = 0;

foreach (char c in t) result += c;

foreach (char c in s) result -= c;

char ddd =  (char)result;





char[] sa = s.ToCharArray();
char missing = new char();
        int index = -1;
        foreach (char c in t)
        {
            index = Array.IndexOf(sa,c);

            if (index == -1)
            {
                missing = c;
                break;
            }
            else
            {
                sa[index] = '1';
            }
        }
        return missing;
Console.WriteLine(missing);


////bool check = true;
////char missing = new char();
////foreach (char c in t)
////{
////    if (!s.Contains(c))
////    {
////        missing = c;
////        break;
////    }
////}
////return missing;
