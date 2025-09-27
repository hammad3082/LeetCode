using System.Text;

public class Solution
{
    public string Interpret(string command)
    {
        return command.Replace("()", "o").Replace("(al)", "al");
    }

    public string Interpret_1(string command)
    {
        StringBuilder res = new StringBuilder(command.Length);

        for (int i = 0; i < command.Length; i++)
        {
            if (command[i] == 'G')
                res.Append('G');

            if (command[i] == '(')
            {
                if (command[i + 1] == ')')
                {
                    res.Append('o');
                    i++;
                }
                else
                {
                    res.Append("al");
                    i = i + 3;
                }
            }
        }
        return res.ToString();
    }
}