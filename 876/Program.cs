using System.Linq.Expressions;

ListNode n1 = new(5);
ListNode n2 = new(4, n1);
ListNode n3 = new(3, n2); 

ListNode n4 = new(2, n3);

ListNode n5 = new(1, n4);
ListNode n6 = new(0, n5);
ListNode n7 = new(8, n6);

Solution solution = new Solution();

solution.MiddleNode(n7);
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

    public ListNode MiddleNode(ListNode head)
    {
        ListNode h = head;
        int i = 1;

        while (true)
        {
            if (head.next != null)
            {
                head = head.next;
            }
            else
                break;
            i++;
        }
        i /= 2;
        head = h;
        while (i > 0)
        {
            head = head.next;

            i--;
        }

        return head;
    }
}