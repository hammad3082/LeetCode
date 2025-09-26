using System.Text;

Solution s = new Solution();

s.SubdomainVisits(new string[] { "9001 discuss.leetcode.com" });
public class Solution
{
    public IList<string> SubdomainVisits(string[] cpdomains)
    {
        List<string> result = new List<string>();

        var map = new Dictionary<string, int>();

        foreach (string domain in cpdomains)
        {
            var sub = domain.Split(' ');

            int count = Convert.ToInt32(sub[0]);

            string[] subDomais = sub[1].Split('.');

            string subDom = null;

            for (int i = subDomais.Length - 1; i >= 0; i--)
            {
                subDom = subDomais[i].ToString() + (subDom is not null ? "." + subDom : "");

                map[subDom] = map.TryGetValue(subDom, out int val) ? val + count : count;
            }
        }

        foreach (var dic in map)
        {
            result.Add(dic.Value + " " + dic.Key);
        }

        return result;
    }

    public IList<string> SubdomainVisits_1(string[] cpdomains)
    {
        List<string> result = new List<string>();

        var map = new Dictionary<string, int>();

        foreach (string domain in cpdomains)
        {
            var sub = domain.Split(' ');

            int count = Convert.ToInt32(sub[0]);

            string[] subDomais = sub[1].Split('.');

            Stack<string> stack = new Stack<string>();

            string subDom = null;

            for (int i = subDomais.Length - 1; i >= 0; i--)
            {
                stack.Push(subDomais[i]);

                string subDomain = string.Join(".", stack);

                map[subDomain] = map.TryGetValue(subDomain, out int val) ? val + count : count;
            }
        }

        foreach (var dic in map)
        {
            result.Add(dic.Value + " " + dic.Key);
        }

        return result;
    }
}