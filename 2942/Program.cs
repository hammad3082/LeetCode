public class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        IList<int> res = new List<int>();

        for (int i = 0; i < words.Length; i++)
        {
            bool present = false;
            string word = words[i];

            foreach (char c in word)
            {
                if (c == x)
                {
                    present = true;
                    break;
                }
            }

            if (present)
            {
                res.Add(i);
            }
        }

        return res;
    }
}