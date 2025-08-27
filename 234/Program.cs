
ListNode n1 = new(0);
ListNode n2 = new(1, n1);
ListNode n3 = new(2, n2);
ListNode n4 = new(3, n3);
//ListNode n41 = new(10, n4);
ListNode n5 = new(3, n4);
ListNode n6 = new(2, n5);
ListNode n7 = new(1, n6);
ListNode n8 = new(0, n7);



//ListNode n1 = new(9);
//ListNode n2 = new(8);
//ListNode n3 = new(7, n2);
//ListNode n4 = new(6, n3);
//ListNode n41 = new(5, n4);
//ListNode n5 = new(4, n41);
//ListNode n6 = new(3, n5);
//ListNode n7 = new(2, n6);
//ListNode n8 = new(1, n7);
Solution solution = new Solution();

bool ss = solution.IsPalindrome(n8);

int ddd = 3 + 3;

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
    public bool IsPalindrome(ListNode head)
    {
        ListNode headNode = head;
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;//middle
            fast = fast.next.next;
        }

        ListNode firstHalf = ReverseList(head, slow);

        if (fast != null)//fast is not null for odd number, skip the middle number
            slow = slow.next;
        ListNode secondHalf = slow;

        while (firstHalf != null && secondHalf != null)
        {
            if(firstHalf.val != secondHalf.val)
                return false;

            firstHalf = firstHalf.next;
            secondHalf = secondHalf.next;
        }

        if(firstHalf == null && secondHalf == null)
            return true;
        else
            return false;
    }

    public ListNode ReverseList(ListNode head, ListNode stopper)
    {
        ListNode prev = null;
        ListNode current = head;
        while (current != null && current !=  stopper)
        {
            ListNode tempNext = current.next;

            current.next = prev;
            prev = current;
            current = tempNext;
        }
        return prev;
    }
}