
Solution sol = new Solution();

sol.SortVowels("lEetcOde");
public class Solution
{
    public string SortVowels(string s)
    {
        var vowelSet = new HashSet<char>("aeiouAEIOU");

        var list = new List<char>();
        foreach (char c in s)
        {
            if (vowelSet.Contains(c))
                list.Add(c);
        }
        list.Sort();

        int listIndex = 0;

        var charS = new char[s.Length];


        for (int i = 0; i < s.Length; i++)
        {
            if (list.Contains(s[i]))
                charS[i] = list[listIndex++];
            else
                charS[i] = s[i];
        }

        return new string(charS);
    }
    public string SortVowels2(string s)
    {
        var vowelSet = new HashSet<char>("aeiouAEIOU");
       
        var list = new List<char>();
        foreach (char c in s)
        {
            if(vowelSet.Contains(c))
                list.Add(c);
        }
        list.Sort();

        int listIndex = 0;

        var charS = s.ToCharArray();

        int listCount = list.Count;

        for (int i = 0; i < s.Length; i++)
        {
            if (listIndex == listCount)
                break;

            if (list.Contains(s[i]))
                charS[i] = Convert.ToChar(list[listIndex++]);

        }

        return new string(charS);
    }
    static readonly int[] vowels = { 97, 101, 105, 111, 117, 65, 69, 73, 79, 85 };
    public string SortVowels1(string s)
    {
        char[] charS = s.ToCharArray();

        var arSVowels = charS.Where(x => vowels.Contains(x)).Order().ToArray();

        int vowelArrayIndex = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if(vowelArrayIndex == arSVowels.Length)
                break;

            if (arSVowels.Contains(s[i]))
                charS[i] = Convert.ToChar(arSVowels[vowelArrayIndex++]);

        }

        return string.Concat(charS);
    }
}