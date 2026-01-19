public class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        string s = s1 + " " + s2;
        HashSet<string> strings = new();
        HashSet<string> res = new();

        foreach (string str in s.Split(" "))
        {
            if (strings.Contains(str))
            {
                res.Remove(str);
            }
            else
            {
                strings.Add(str);
                res.Add(str);
            }
        }

        return res.ToArray();
    }
    public string[] UncommonFromSentences_1(string s1, string s2)
    {
        Dictionary<string,bool> strings = new ();

        foreach (string s in s1.Split(" "))
        {
            if (strings.TryGetValue(s, out bool a))
            { 
                if (a)
                    strings[s] = false;
            }
            else
                strings[s] = true;
        }

        foreach (string s in s2.Split(" "))
        {
            if (strings.TryGetValue(s, out bool a))
            {
                if (a)
                    strings[s] = false;
            }
            else
                strings[s] = true;
        }

        return strings.Where(x => x.Value).Select(x => x.Key).ToArray();
    }
}