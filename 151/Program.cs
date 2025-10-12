using System.Text;

Solution sol = new Solution();
string ss = sol.ReverseWords("  hello world  ");

int a = 1 + 2;

public class Solution
{
    public string ReverseWords(string s)
    {
        var sArr = s.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(sArr);
        return string.Join(" ", sArr);
    }
    public string ReverseWords_hehe(string s)
    {
        var sArr = new Stack<string>();

        var word = new List<char>();
        foreach (char c in s)
        {
            if(c != ' ')
                word.Add(c);
            else if(word.Count > 0)
            {
                sArr.Push(new string(word.ToArray()));
                word.Clear();
            }
        }

        if (word.Count > 0)
        {
            sArr.Push(new string(word.ToArray()));
            word.Clear();
        }

        StringBuilder stringBuilder = new StringBuilder();
        bool notFirst = false;
        foreach (string cw in sArr)
        {
            if(notFirst) stringBuilder.Append(" ");
            notFirst = true;
            stringBuilder.Append(cw);
        }
        return stringBuilder.ToString();
    }
    public string ReverseWords_2(string s) 
    { 
        var sArr = new Stack<string>(); 
        var word = new List<char>(); 
        foreach (char c in s) 
        { 
            if (c != ' ') 
                word.Add(c); 
            else if (word.Count > 0) 
            { 
                sArr.Push(string.Join("", word)); 
                word = new List<char>(); 
            } 
        } 
        if (word.Count > 0) 
        { 
            sArr.Push(string.Join("", word)); 
            word = new List<char>();
        } 
        StringBuilder stringBuilder = new StringBuilder();
        bool notFirst = false; 
        foreach (string cw in sArr) 
        { 
            if (notFirst) stringBuilder.Append(" "); 
            notFirst = true; stringBuilder.Append(cw); 
        } 
        return stringBuilder.ToString(); 
    }
    public string ReverseWords_1(string s)
    {
        var sArr = s.Split(' ').Where(x => x.Length > 0).ToArray();

        return string.Join(" ", sArr.Reverse());
    }
}