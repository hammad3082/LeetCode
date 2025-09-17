public class Solution
{
    public int MostWordsFound(string[] sentences)
    {
        int max = 0;

        foreach (string sentence in sentences)
            max = Math.Max(max, sentence.Split(' ').Length);

        return max;
    }
}