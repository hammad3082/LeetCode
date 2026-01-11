Solution sol = new Solution();
sol.IsSumEqual("j", "j", "bi");

public class Solution
{
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
    {
        int a = 0, b = 0, c = 0;
        for (int i = 0; i < firstWord.Length; i++)
            a = (a * 10) + (firstWord[i] - 'a');
        for (int i = 0; i < secondWord.Length; i++)
            b = (b * 10) + (secondWord[i] - 'a');
        for (int i = 0; i < targetWord.Length; i++)
            c = (c * 10) + (targetWord[i] - 'a');
        return a + b == c;
    }
    public bool IsSumEqual_1(string firstWord, string secondWord, string targetWord)
    {
        if(getSum(firstWord) + getSum(secondWord) == getSum(targetWord))
            return true;
        else 
            return false;
    }

    private int getSum(string word)
    {
        string sCon = "";

        foreach (char c in word)
        {
            sCon += (c - 'a');
        }

        return Convert.ToInt32(sCon);
    }
}