Solution sol = new Solution();
sol.IsCircularSentence("leetcode exercises sound delightful");
public class Solution
{
    public bool IsCircularSentence(string sentence)
    {
        int n = sentence.Length;

        if (sentence[0] != sentence[n - 1])
            return false;

        string[] arStrings = sentence.Split(' ');

        if (arStrings.Length > 1)
        {
            for (int i = 1; i < arStrings.Length; i++)
            {
                string preWord = arStrings[i - 1];

                if (preWord[preWord.Length - 1] != arStrings[i][0])
                    return false;
            }
        }
        return true;
    }
    public bool IsCircularSentence_1                    (string sentence)
    {
        int n = sentence.Length;

        if (sentence[0] != sentence[n - 1]) 
            return false;

        for (int i = 1; i < n - 1; i++)
        {
            if (sentence[i] == ' ')
            {
                if (sentence[i - 1] != sentence[i + 1]) 
                    return false;
            }
        }

        return true;
    }
}