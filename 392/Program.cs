bool res = IsSubsequence("abc", "ahbgdc");

bool IsSubsequence(string s, string t)
{
    if (t.Length < s.Length)
    {
        return false;
    }
    int count = s.Length;
    int i = 0, j = 0;
    while (j <  s.Length)
    {
        while(i < t.Length)
        {
            if (s[j] == t[i])
            {
                i++;
                count--;
                break;    
            }
            if (i == t.Length - 1)
            {
                i++;
                return false;
            }
            i++;
        }
        j++;
    }
    if(count != 0)
        return false;
    else
        return true;
}


//public bool IsSubsequence(string s, string t)
//{
//    if (t.Length < s.Length)
//    {
//        return false;
//    }
//    int i = 0;
//    foreach (char x in s)
//    {
//        while (i < t.Length)
//        {
//            if (x == t[i])
//            {
//                i++;
//                break;
//            }
//            if (i == t.Length - 1)
//            {
//                return false;
//            }
//            i++;
//        }
//    }
//    return true;
//}