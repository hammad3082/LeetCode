
//MinStack obj = new MinStack();
//obj.Push(-2);
//obj.Push(0);
//obj.Push(-3);
//int param_2 = obj.GetMin();
//obj.Pop();
//int param_4 = obj.Top();
//int param_5 = obj.GetMin();

MinStack obj = new MinStack();
obj.Push(0);
obj.Push(1);
obj.Push(0);
int param_2 = obj.GetMin();
obj.Pop();
int param_4 = obj.Top();
int param_5 = obj.GetMin();

public class MinStack //final
{
    Stack<int> stack;

    Stack<int> min;
    public MinStack()
    {
        stack = new Stack<int>();
        min = new Stack<int>();
    }

    public void Push(int val)
    {
        //Console.WriteLine($"push: {val}");
        if (min.Count == 0)
        {
            //Console.WriteLine($"O min push: {val}");
            min.Push(val);
        }
        else if (val <= (min.Peek()))
        {
            //Console.WriteLine($"min push: {val}");
            min.Push(val);
        }
        stack.Push(val);
    }
    public void Pop()
    {
        //int tem = stack.Pop();
        // Console.WriteLine($"Min Pop:{tem};");
        if (stack.Pop() == (min.Count == 0 ? 0 : min.Peek()))
        {
            //Console.WriteLine($"Min Pop:{min.Pop()};");
            min.Pop();
        }
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return min.Peek();
    }
}
public class MinStack2//wrong
{
    Stack<int> stack;

    Stack<int> min;
    public MinStack2()
    {
        stack = new Stack<int>();
        min = new Stack<int>();
    }

    public void Push(int val)
    {
        if (min.Count == 0)
        {
            min.Push(val);
        }
        if (val < (min.Peek()))
        {
            min.Push(val);
        }
        stack.Push(val);
    }

    public void Push1(int val)
    {
        Console.WriteLine($"Push:{val}");
        if (val <= (min.Count == 0 ? 0 : min.Peek()))
        {
            Console.WriteLine($"min Push:{val}");
            min.Push(val);
        }
        stack.Push(val);
    }


    public void Pop()
    {
        if(stack.Pop() == (min.Count == 0 ? 0 : min.Peek()))
            min.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return min.Peek();
    }
}
public class MinStack1 //wrong
{

    Stack<int> stack;

    int min = 0;
    public MinStack1()
    {
        stack = new Stack<int>();
    }

    public void Push(int val)
    {
        if (val > min) min = val;
        stack.Push(val);
    }

    public void Pop()
    {
        stack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return min;
    }
}
/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */