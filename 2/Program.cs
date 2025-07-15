int a = (4 + 4) / 10;

int a1 = (4 + 4) % 10;


int a2 = (4 + 6) / 10;
int a21 = (4 + 6) % 10;
int a3 = (4 + 7) / 10;
int a31 = (4 + 7) % 10;

int aa = 1 + 1;

Console.WriteLine("sss");
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int rem = 0;

        ListNode res = new ListNode(-1);
        int a = 0, b = 0, c = 0;

        ListNode lastNode = res;
        while (l1 != null || l2 != null)
        {
            a = 0; b = 0;
            if (l1 != null)
            {
                a = l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                b = l2.val;
                l2 = l2.next;
            }

            c = a + b + rem;

            // if(c > 9)
            // {
            rem = c / 10;
            c %= 10;
            // }
            // else
            //     rem = 0;
            if (lastNode.val == -1)
                lastNode.val = c;
            else
            {
                lastNode.next = new ListNode(c);

                lastNode = lastNode.next;
            }
        }

        if (rem > 0)
            lastNode.next = new ListNode(rem);

        return res;
    }
}