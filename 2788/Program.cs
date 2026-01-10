public class Solution
{
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
    {
        List<string> result = new List<string>();

        foreach (string word in words)
        {
            var sRes = word.Split(separator);

            foreach (string s in sRes)
            {
                if(s != "")
                    result.Add(s);
            }
        }

        return result;
    }
}