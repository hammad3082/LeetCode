public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        int[] cArr = new int[26];

        foreach (char c in magazine)
        {
            cArr[c - 'a']++;
        }

        foreach (char c in ransomNote)
        {
            if (cArr[c - 'a'] > 0)
                cArr[c - 'a']--;
            else
                return false;
        }

        return true;
    }
    public bool CanConstruct(string ransomNote, string magazine)
    {
        List<char> list = new List<char>(magazine);

        //foreach (char c in ransomNote) 
        //{ 
        //    list.Add(c);
        //}

        foreach (char c in ransomNote)
        {
            if (list.Contains(c))
            {
                list.Remove(c);
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}