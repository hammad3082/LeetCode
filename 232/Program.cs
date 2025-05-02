MyQueue obj = new MyQueue();
obj.Push(1);
obj.Push(2);
obj.Push(3);
obj.Push(4);
int param_2 = obj.Pop();
int param_3 = obj.Peek();
bool param_4 = obj.Empty();





public class MyQueue
{
    Stack<int> one = new Stack<int>();
    Stack<int> two = new Stack<int>();

    int tem = 0;
    public MyQueue()
    {
        
    }

    public void Push(int x)
    {
        if (one.Count == 0)
        {
            one.Push(x);
        }
        else
        {
            while (one.Count !=0)
            {
                tem = one.Pop();
                two.Push(tem);
            }
            one.Push(x);
            while (two.Count != 0)
            {
                tem = two.Pop();
                one.Push(tem);
            }
        }
    }

    public int Pop()
    {
        return one.Pop();
    }

    public int Peek()
    {
        return one.Peek();
    }

    public bool Empty()
    {
        return one.Count == 0;
    }
}



