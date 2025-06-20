public class MyHashSet
{
    List<int>[] arrList;
    int size = 251;
    public MyHashSet()
    {
       
        arrList = new List<int>[size];

        for (int i = 0; i < size; i++)
        {
            arrList[i] = new List<int>();
        }
    }

    public void Add(int key)
    {
        int pos = key % size;
        if(!arrList[pos].Contains(key))
            arrList[pos].Add(key);
    }

    public void Remove(int key)
    {
        int pos = key % size;

        arrList[pos].Remove(key);
    }

    public bool Contains(int key)
    {
        int pos = key % size;
        return arrList[pos].Contains(key);
    }
}