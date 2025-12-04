public class Solution
{
    public string SortSentence(string s)
    {

        string[] words = s.Split(" ");
        string[] result = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];

            int index = Convert.ToInt32(word[word.Length - 1].ToString()) - 1;

            result[index] = word.Substring(0, word.Length - 1);
        }

        return String.Join(" ", result);
    }
}