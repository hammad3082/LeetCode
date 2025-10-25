Solution sol = new Solution();
sol.CheckIfPangram("thequickbrownfoxjumpsoverthelazydog");
public class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        var visited = new HashSet<char>();

        foreach (var word in sentence)
        {
            if (visited.Count == 26)
                return true;

            visited.Add(word);
        }

        if(visited.Count == 26)
            return true;
        return false;
    }
}