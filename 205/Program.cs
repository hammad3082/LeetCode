public class Solution
{
    public bool IsIsomorphic(string s, string t)//nm
    {
        int[] mapST = new int[256];
        int[] mapTS = new int[256];

        for (int i = 0; i < s.Length; i++)
        {
            char c1 = s[i];
            char c2 = t[i];

            if (mapST[c1] != mapTS[c2]) return false;

            mapST[c1] = i + 1;
            mapTS[c2] = i + 1;
        }

        return true;
    }

    public bool IsIsomorphic1(string s, string t)
    {
        Dictionary<char, char> smap = new Dictionary<char, char>();
        Dictionary<char, char> tmap = new Dictionary<char, char>();

        for (int i = 0; i< s.Length; i++)
        {
            if (smap.ContainsKey(s[i]))
            {
                if (smap[s[i]] != t[i])
                    return false;
            }
            else
            {
                smap[s[i]] = t[i];
            }

            if (tmap.ContainsKey(t[i]))
            {
                if (tmap[t[i]] != s[i])
                    return false;
            }
            else
            {
                tmap[t[i]] = s[i];
            }
        }
        return true;
    }
}

public class Solution1
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> map = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(t[i]))
            {
                if (map[t[i]] != s[i])
                    return false;
            }
            // else if (map.ContainsKey(t[i]))
            // {
            //     if (map[t[i]] != s[i])
            //         return false;
            // }
            else
            {
                map[t[i]] = s[i];
            }
        }
        return true;
    }
}