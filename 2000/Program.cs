Solution sol = new Solution();

sol.ReversePrefix("abcd", 'z');

public class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        int firstIndex = -1;

        //firstIndex = word.IndexOf(ch);
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == ch)
            {
                firstIndex = i;
                break;
            }
        }
        if (firstIndex >= 0)
        {
            char[] chars = word.ToCharArray();

            Array.Reverse(chars, 0, firstIndex + 1);

            //for (int j = 0; j <= firstIndex / 2; j++)
            //{
            //    char temp = chars[j];
            //    chars[j] = chars[firstIndex - j];
            //    chars[firstIndex - j] = temp;
            //}

            return string.Join("", chars);
        }
        else
            return word;
    }
}