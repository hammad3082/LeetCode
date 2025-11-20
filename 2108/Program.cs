Solution sol = new Solution();
sol.FirstPalindrome(new string[] { "abc", "car", "ada", "racecar", "cool" });
public class Solution
{
    public string FirstPalindrome(string[] words)//TP yee
    {
        foreach (var word in words)
        {
            bool Continue = false;

            for (var i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    Continue = true;
                    break;
                }
            }

            if (Continue)
                continue;

            return word;
        }

        return "";
    }

    public string FirstPalindrome_1(string[] words)
    {
        foreach (var word in words)
        {
            if (word == string.Concat(word.Reverse()))
                return word;
        }
        return "";
    }
}