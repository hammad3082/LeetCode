public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        HashSet<string> hasPathsToOtherCities = new HashSet<string>();

        HashSet<string> uniqueCities = new HashSet<string>();

        foreach (var path in paths)
        {
            hasPathsToOtherCities.Add(path[0]);
            uniqueCities.Add(path[0]);
            uniqueCities.Add(path[1]);
        }

        string destinationCity = string.Empty;
        foreach (var city in uniqueCities)
        {
            if (!hasPathsToOtherCities.Contains(city))
            {
                destinationCity = city;
                break;
            }
        }

        return destinationCity;
    }
}