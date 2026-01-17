public class Solution
{
    public bool HalvesAreAlike(string s)
    {
        int midIndex = s.Length / 2;

        string firstHalf = s.Substring(0, midIndex);
        string secondHalf = s.Substring(midIndex);

        return CountVowels(firstHalf) == CountVowels(secondHalf);
    }

    int CountVowels(string str)
    {
        int count = 0;
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        
        foreach (char c in str)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }
}