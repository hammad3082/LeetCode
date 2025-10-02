public class Solution
{
    public string ConvertDateToBinary(string date)
    {
        string[] parts = date.Split('-');

        int year = int.Parse(parts[0]);
        int month = int.Parse(parts[1]);
        int day = int.Parse(parts[2]);

        string yearBinary = Convert.ToString(year, 2);
        string monthBinary = Convert.ToString(month, 2);
        string dayBinary = Convert.ToString(day, 2);

        return $"{yearBinary}-{monthBinary}-{dayBinary}";
    }
}