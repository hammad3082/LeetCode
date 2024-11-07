// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");


Console.WriteLine(RepeatedSubstringPattern("aaaa"));


bool RepeatedSubstringPattern(string s)
{
    string sub = Substring(s);

    int len = sub.Length;

    var res = s.Length % len;

    if (res != 0)
    {
        return false;
    }
    //int counter = 0;
    //bool result = true;
    //while (result)
    //{
    //    if (counter > len)
    //        break;
    //    if (sub != s.Substring(counter, len))
    //    {
    //        result =  false;
    //        break;
    //    }
    //    counter += len;
    //}

    return true;
}
string Substring(string s)
{
    string substring = "";
    string Asubstring = "";

    for (int i = 0; i < s.Length; i++)
    {
        string SString = s.Substring(i + 1);

        substring += s[i];
        if (!SString.Contains(substring) && substring.Length > SString.Length && Asubstring.Length != 1)
        {
            break;
        }
        else
        {
            Asubstring += s[i];

            if(SString.Length == 1)
            {
                break;
            }

            if(Asubstring == s.Substring(i + 1, Asubstring.Length))
            {
                bool loop = true;
                while (loop)
                {
                    int len = Asubstring.Length;
                    if (Asubstring.Length + i + 1! > s.Length && s.Substring(i + 1 + len) != "")
                    {
                        if (s.Substring(i + 1 + len).Length > len)
                        {
                            if (Asubstring == s.Substring(i + 1 + len, len))
                            {
                                loop = true;
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    else
                        break;
                }
                break;
            }
        }
    }
    return Asubstring;
}

bool ddd(string s)
{
    char[] c = s.ToCharArray();

    char first = c[0];
    int resSum = 0;
    bool doSum = true;
    int firstSum = 0;
    for(int i = 0; i < c.Length;i++)
    {
        if (i > 0 && first == c[i])
        {
            if (c.Length > i + 1)
            {
                if (c[i] == c[i + 1] || c[i] != c[i - 1])
                {
                    doSum = doSum == false;

                    if (firstSum == 0)
                    {
                        firstSum = resSum;
                    }
                }
            }
            else
                doSum = doSum == false;

        }

        if (doSum)
        {
            resSum += c[i];
        }
        else
        {
            resSum -= c[i];
        }

        //if (resSum == 0) doSum = true;
    }
    if(resSum == 0 || resSum == firstSum)
        return true;

    return false;

}


bool ddd1(string s)
{

    char[] c = s.ToCharArray();

    //Array.Sort(c);

    var unique = c.Distinct();

    int count = 0;
    foreach(var i in unique)
    {
        var dd = c.Where(a => a == i);

        if(count == 0)
            count += dd.Count();
        else
            count -= dd.Count();

    }
    if (count != 0)
    {
        return false;
    }
    return true;
}













bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
        return false;

    char[] sa = s.ToCharArray();
    char[] ta = t.ToCharArray();

    Array.Sort(sa);

    Array.Sort(ta);

    if (sa.SequenceEqual(ta)) return true;
    if (sa.ToString()== ta.ToString()) return true; 
    return false;
}
bool IsAnagram3(string s, string t)
{
    int[] charcount = new int[26];
    
    foreach (char c in s)
    {
        charcount[c - 'a']++;
    }

    foreach (char c in t)
    {
        charcount[c - 'a']--;
        if(charcount[c - 'a'] < 0)
            return false;
    }
    return true;
}
bool IsAnagram2(string s, string t)
{

    char[] sa = s.ToCharArray();
    char[] ta = t.ToCharArray();
    int ss = 0, tt = 0;
    foreach (char c in sa)
    {
        ss += c;
    }
    foreach (char c in ta)
    {
        tt += c;
    }

    return (ss == tt);
}
bool IsAnagram1(string s, string t)
{
    if(s.Length> t.Length)
    {
        string temp = s;
        s = t;
        t = temp;
    }
        
    char[] sa = s.ToCharArray();
    bool anagram = true;
    int index = -1;
    foreach (char c in t)
    {
        index = Array.IndexOf(sa, c);

        if (index == -1)
        {
            anagram = false;
            break;
        }
        else
        {
            sa[index] = '1';
        }
    }
    return anagram;
}
//Console.WriteLine(IsAnagram("anagram", "nagaram"));