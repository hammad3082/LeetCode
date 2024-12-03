
using System.Collections.Generic;

ListNode list5 = new ListNode(7);
ListNode list4 = new ListNode(7, list5);
ListNode list3 = new ListNode(5, list4);
ListNode list2 = new ListNode(3, list3);
ListNode list1 = new ListNode(1, list2);


ListNode list51 = new ListNode(8);
ListNode list41 = new ListNode(8, list51);
ListNode list31 = new ListNode(8, list41);
ListNode list21 = new ListNode(4, list31);
ListNode list11 = new ListNode(2, list21);

ListNode result = MergeTwoLists(list1, list11);

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    if (list1 == null)
    {
        return list2;
    }
    else if (list2 == null)
    {
        return list1;
    }
    ListNode ResultHead = new ListNode();
    ListNode ResultTail = ResultHead;
    int a = 0, b = 0;

    while (true)
    {
        a = list1.val; b = list2.val;

        if (a <= b)
        {
            ResultTail.next = new ListNode(a);
            ResultTail = ResultTail.next;

            if (list1.next == null)
            {
                ResultTail.next = list2;
                break;
            }
            list1 = list1.next;
        }
        else
        {
            ResultTail.next = new ListNode(b);
            ResultTail = ResultTail.next;
            
            if (list2.next == null)
            {
                ResultTail.next = list1;
                break;
            }
            list2 = list2.next;
        }
    }
    return ResultHead.next;
}

ListNode MergeTwoListst(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        current.next = list1 ?? list2;
        return dummy.next;
    }

ListNode MergeTwoLists22(ListNode list1, ListNode list2)
{
    if (list1 == null)
    {
        return list2;
    }
    else if(list2 == null)
    {
        return list1;
    }
    ListNode ResultHead = null;
    ListNode ResultTail = null;
    bool newL = true;
    int a = 0, b = 0;

    while (true)
    {
        a = list1.val; b = list2.val;


        if (a <= b)
        {
            while (true)
            {
                if (newL)
                {
                    ResultHead = ResultTail = new ListNode(a);
                    newL = false;
                    break;
                }
                else if (ResultTail.next == null)
                {
                    ResultTail.next = new ListNode(a);
                    ResultTail = ResultTail.next;
                    break;
                }
            }

            if (list1.next == null)
            {
                ResultTail.next = list2;
                break;
            }
            list1 = list1.next;
        }
        else
        {
            while (true)
            {
                if (newL)
                {
                    ResultHead = ResultTail = new ListNode(b);
                    newL = false;
                    break;
                }
                else if (ResultTail.next == null)
                {
                    ResultTail.next = new ListNode(b);
                    ResultTail = ResultTail.next;
                    break;
                }
            }

            if (list2.next == null)
            {
                ResultTail.next = list1;
                break;
            }
            list2 = list2.next;
        }

    }
    return ResultHead;
}


ListNode MergeTwoLists1(ListNode list1, ListNode list2)
{
    ListNode pList1 = list1;
    ListNode pList2 = list2;
    ListNode newl = null;

    ListNode Head = null;



    bool sort = false;
    int first = 0, second = 0, inter = 0;
    while (true)
    {
        first = pList1.val;

        second = pList2.val;
        if (first <= second)
        {
            while (true)
            {
                if (newl == null)
                {
                    newl = new ListNode(first);
                    Head = newl;
                    break;
                }
                else if (newl.next == null)
                {
                    newl.next = new ListNode(first);
                    newl = newl.next;
                    break;
                }
            }

            if (pList1.next == null)
            {
                newl.next = list2;
                break;
            }
            pList1 = pList1.next;
        }
        else
        {
            addAtEnd(newl, second);
            if (pList2.next == null)
            {
                newl.next = list1;
                break;
            }
            pList2 = pList2.next;
        }

        //if (first <= second)
        //{
        //    //ListNode temp = list1.next;

        //    ListNode newNode = new ListNode(second, list1.next);
        //    list1.next = newNode;
        //}
        //if (sort)
        //{
        //    first = list1.val;
        //    second = list1.next.val;
        //}
        //else 
        //{
        //    if (lastnole.next == null)
        //    {
        //        lastnole.next = list2;
        //        sort = true;
        //        //break;
        //    }
        //    lastnole = lastnole.next;
        //}
    }

    return new ListNode();
}
void addAtEnd(ListNode list, int val)
{
    while (true)
    {
        if (list == null)
        {
            list = new ListNode(val);
            break;
        }
        else if (list.next == null)
        {
            list.next = new ListNode(val);
            break;
        }
    }
}
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


