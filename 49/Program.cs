// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> list = new List<string>();

list.Add("abc");
list.Add("bca");
list.Add("ddd");
var plist = new List<List<string>>();
plist.Add(list);

string[] sss = { "bdddddddddd", "bbbbbbbbbbc" };
var result = GroupAnagrams(sss);

foreach (var group in result)
{
    Console.WriteLine($"[{string.Join(", ", group)}]");
}
IList<IList<string>> GroupAnagrams(string[] strs)
{
    var dic = new Dictionary<string, List<string>>();
    foreach (string s in strs)
    {
        int[] arr = new int[28];

        foreach (char c in s)
        {
            arr[c - 'a']++;
        }

        string key2 = string.Join(",", arr);

        if (!dic.ContainsKey(key2))
        {
            dic[key2] = new List<string>();
        }

        dic[key2].Add(s);
    }

    return dic.Values.ToList<IList<string>>();
}
