public class Solution
{
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        int res = 0;
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            bool canType = true;
            //HashSet<char> charSet = new HashSet<char>(word);

            foreach (char c in brokenLetters)
            {
                if (word.Contains(c))
                {
                    canType = false;
                    break;
                }
            }

            if (canType)
                res++;
        }
        return res;
    }
}