//ListNode n1 = new(5);
//ListNode n2 = new(4, n1);
using System.Linq.Expressions;

ListNode n3 = new(3);

ListNode n4 = new(2,n3);

ListNode n5 = new(1, n4);
ListNode n6 = new(0, n5);
ListNode n7 = new(8, n6);

n3.next = n6;
Solution solution = new Solution();

solution.HasCycle(n7);

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null || head.next == null)
            return false;
        ListNode slow = head;
        ListNode fast = head.next;

        while (fast != null && fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
                return true;
        }
        return false;
    }
    public bool HasCycle1(ListNode head)
    {
        //Dictionary<int,int> dict = new Dictionary<int,int>();

       // ListNode mem = head;

        ListNode slow = head;

        ListNode fast = head.next;

       // ListNode temp = null;

        while (fast != null)
        {
            slow = slow.next; 
            fast = fast.next.next;


            if (slow == fast)
                return true;
        }
        return false;
    }
}