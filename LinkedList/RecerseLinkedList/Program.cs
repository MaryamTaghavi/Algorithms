

ListNode head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(4);

ReverseList(head);

ListNode ReverseList(ListNode head)
{
    ListNode current = head;
    ListNode pre = null;

    if (current != null)
    {
        while (current != null)
        {
            ListNode next = current.next;
            current.next = pre;
            pre = current;
            current = next;
        }
    }

    return pre;
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