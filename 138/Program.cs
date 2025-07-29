Node node0 = new Node(7);
Node node1 = new Node(13);
Node node2 = new Node(11);
Node node3 = new Node(10);
Node node4 = new Node(1);

// Link next pointers
node0.next = node1;
node1.next = node2;
node2.next = node3;
node3.next = node4;

// Set random pointers
node0.random = null;
node1.random = node0;
node2.random = node4;
node3.random = node2;
node4.random = node0;

Node head = node0;


Solution solution = new Solution();
solution.CopyRandomList(node0);

public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}

public class Solution
{
    Dictionary<Node, List<Node>> RandomAndNextNode = new Dictionary<Node, List<Node>>();


    Dictionary<Node, Node> OldNewNode = new Dictionary<Node, Node>();
    public Node CopyRandomList(Node head) /// yee works, can be optimised
    {
        Node res = traversal(head);

        return res;
    }

    public Node traversal(Node head) {
        if (head != null)
        {
            Node nextNode = traversal(head.next);

            Node newNode = new Node(head.val);
            newNode.next = nextNode;

            OldNewNode.Add(head, newNode);

            if (head.random != null)
            {
                if (OldNewNode.ContainsKey(head.random))
                {
                    newNode.random = OldNewNode[head.random];
                }
            }
            
            if (RandomAndNextNode.ContainsKey(head))
            {
                List<Node> preNode = RandomAndNextNode[head];

                foreach (Node pre in preNode)
                {
                    pre.random = newNode;
                }
            }

            if(head.random != null)
            {
                if(head.random == head)
                {
                    newNode.random = newNode;
                }
                else if (RandomAndNextNode.ContainsKey(head.random))
                {
                    List<Node> list = RandomAndNextNode[head.random];

                    list.Add(newNode);
                }
                else
                    RandomAndNextNode.Add(head.random, [newNode]);
            }

            return newNode;
        }
        else
            return null;
    }
}


//if (head.next == null)
//{
//    Node newNode = new Node(head.val);

//    return newNode;
//}
//else if (head.next != null)
//{
//    Node nextNode = traversal(head.next);

//    Node newNode = new Node(head.val);
//    newNode.next = nextNode;
//    return newNode;
//}