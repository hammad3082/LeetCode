using System.Text;

public class Solution
{
    public string DefangIPaddr(string address)
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (char c in address)
        {
            if (c != '.')
                stringBuilder.Append(c);
            else stringBuilder.Append("[.]");
        }

        return stringBuilder.ToString();
        //return address.Replace(".", "[.]");
        //return string.Join("[.]",address.Split('.'));
    }
}