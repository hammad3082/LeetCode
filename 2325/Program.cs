using System.Text;

public class Solution
{
    public string DecodeMessage(string key, string message)
    {
        var substitutionMap = new Dictionary<char, char>();

        char nextDecodedChar = 'a';

        foreach (char keyChar in key)
        {
            if (keyChar != ' ')
            {
                if (!substitutionMap.ContainsKey(keyChar))
                {
                    substitutionMap.Add(keyChar, nextDecodedChar);
                    nextDecodedChar++;
                }
            }
        }

        var decodedMessage = new StringBuilder(message.Length);

        foreach (char messageChar in message)
        {
            if (messageChar == ' ')
            {
                decodedMessage.Append(' ');
            }
            else
            {
                if (substitutionMap.TryGetValue(messageChar, out char decodedChar))
                {
                    decodedMessage.Append(decodedChar);
                }
            }
        }

        return decodedMessage.ToString();
    }
}