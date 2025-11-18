public class Solution
{
    public bool IsAcronym(IList<string> words, string s)
    {
        if(words.Count != s.Length) 
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            if (!words[i].StartsWith(s[i]))
                return false;
            //    if (words[i][0] != s[i])
            //        return false;
        }
        return true;
    }
}