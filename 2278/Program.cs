public class Solution
{
    public int PercentageLetter(string s, char letter)
    {
        int letterCount = 0;

        //letterCount = s.Count(x => x == letter);
        foreach (char c in s)
        {
            if (c == letter)
                letterCount++;
        }

        return (letterCount * 100) / s.Length;
    }
}